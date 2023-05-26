using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;

namespace lb6server
{
    public partial class ServerForm : Form
    {
        private const string ServerUrl = "http://localhost:8080/";
        private List<Room> rooms = new();
        private System.Threading.Timer dayTimer;
        private int logDay = 0;
        public ServerForm()
        {
            InitializeComponent();
        }
        private void InitializeRooms()
        {
            rooms = new List<Room>();
            for (int i = 1; i <= 30; i++)
            {
                rooms.Add(new Room
                {
                    RoomNumber = i,
                    Beds = i % 4 + 1,
                    CostPerDay = i % 5 + 5,
                    IsOccupied = false,
                    DaysRemaining = 0
                });
            }
        }
        private void UpdateDay(object state)
        {
            foreach (Room room in rooms)
            {
                if (room.IsOccupied && --room.DaysRemaining <= 0)
                {
                    LogMessage($"Guest has checked out from Room {room.RoomNumber}.");
                    room.IsOccupied = false;
                }
            }
            string roomsJson = JsonSerializer.Serialize(rooms);
            File.WriteAllText("rooms.json", roomsJson);
            logDay++;
            string dayJson = JsonSerializer.Serialize(logDay);
            File.WriteAllText("currentDay.json", dayJson);
            LogMessage($"Day #{logDay}");
        }
        private void HandleRequest(HttpListenerContext context)
        {
            switch (context.Request.Url.LocalPath.Trim('/'))
            {
                case "rooms":
                    GetRooms(context);
                    break;
                case "reservation":
                    MakeReservation(context);
                    break;
                default:
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    context.Response.Close();
                    break;
            }
        }
        private async void StartListening()
        {
            try
            {
                using HttpListener listener = new();
                listener.Prefixes.Add(ServerUrl);
                listener.Start();

                if (listener.IsListening)
                {
                    LogMessage("Listener started successfully.");

                    while (true)
                    {
                        HttpListenerContext context = await listener.GetContextAsync();
                        ThreadPool.QueueUserWorkItem(state => HandleRequest(context));
                    }
                }
                else
                {
                    Console.WriteLine("Listener failed to start.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void GetRooms(HttpListenerContext context)
        {
            string json = SerializeToJson(rooms);
            SendJsonResponse(context, json, HttpStatusCode.OK);
        }

        private void MakeReservation(HttpListenerContext context)
        {
            string requestBody;
            using (StreamReader reader = new(context.Request.InputStream, context.Request.ContentEncoding))
            {
                requestBody = reader.ReadToEnd();
            }
            Guest guest = DeserializeFromJson<Guest>(requestBody);
            Room vacantRoom = FindVacantRoom(guest.NumPeople);
            if (vacantRoom != null)
            {
                vacantRoom.IsOccupied = true;
                vacantRoom.DaysRemaining = guest.Days;
                string json = JsonSerializer.Serialize(rooms);
                File.WriteAllText("rooms.json", json);
                SendJsonResponse(context, "Reservation successful.", HttpStatusCode.OK);
                LogMessage($"Reservation made: Guest with {guest.NumPeople} people has checked into Room {vacantRoom.RoomNumber} for {guest.Days} days");
            }
            else
            {
                SendJsonResponse(context, "No vacant rooms available.", HttpStatusCode.BadRequest);
                LogMessage("Reservation failed: No vacant rooms available");
            }
        }

        private Room? FindVacantRoom(int numPeople)
        {
            return rooms.FirstOrDefault(room => !room.IsOccupied && room.Beds >= numPeople);
        }


        private static string SerializeToJson<T>(T data)
        {
            DataContractJsonSerializer serializer = new(typeof(T));
            using MemoryStream memoryStream = new();
            serializer.WriteObject(memoryStream, data);
            memoryStream.Position = 0;
            using StreamReader reader = new(memoryStream);
            return reader.ReadToEnd();
        }

        private static T DeserializeFromJson<T>(string json)
        {
            DataContractJsonSerializer serializer = new(typeof(T));
            using MemoryStream memoryStream = new(Encoding.UTF8.GetBytes(json));
            return (T)serializer.ReadObject(memoryStream);
        }

        private static void SendJsonResponse(HttpListenerContext context, string json, HttpStatusCode statusCode)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(json);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.OutputStream.Close();
        }

        private void LogMessage(string message)
        {
            if (textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke(new Action(() => textBoxLog.AppendText(message + Environment.NewLine)));
            }
            else
            {
                textBoxLog.AppendText(message + Environment.NewLine);
            }
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("rooms.json"))
            {
                string roomsJson = File.ReadAllText("rooms.json");
                rooms = JsonSerializer.Deserialize<List<Room>>(roomsJson);
            }
            else
            {
                InitializeRooms();
            }
            dayTimer = new System.Threading.Timer(UpdateDay, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));
            if (File.Exists("currentDay.json"))
            {
                string dayJson = File.ReadAllText("currentDay.json");
                logDay = JsonSerializer.Deserialize<int>(dayJson);
            }
            else
            {
                logDay = 0;
            }
            StartListening();
        }
    }
}