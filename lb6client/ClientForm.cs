using System.Runtime.Serialization.Json;
using System.Text;

namespace lb6client
{
    public partial class ClientForm : Form
    {
        private const string ServerUrl = "http://localhost:8080";
        public ClientForm()
        {
            InitializeComponent();
        }
        private static async Task<Room[]> GetRoomInformation()
        {
            try
            {
                using HttpClient client = new();
                HttpResponseMessage response = await client.GetAsync($"{ServerUrl}/rooms");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Room[] rooms = DeserializeFromJson<Room[]>(responseBody);
                return rooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private static async Task<bool> MakeReservation(Guest guest)
        {
            try
            {
                using HttpClient client = new();
                string json = SerializeToJson(guest);
                StringContent content = new(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{ServerUrl}/reservation", content);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void DisplayRoomInformation(Room[] rooms)
        {
            if (rooms != null)
            {
                bindingSourceRooms.DataSource = rooms;
                dataGridViewRooms.DataSource = bindingSourceRooms;
            }
            else
            {
                bindingSourceRooms.DataSource = null;
                dataGridViewRooms.DataSource = null;
            }
        }
        private static T DeserializeFromJson<T>(string json)
        {
            DataContractJsonSerializer serializer = new(typeof(T));
            using MemoryStream memoryStream = new(Encoding.UTF8.GetBytes(json));
            return (T)serializer.ReadObject(memoryStream);
        }
        private static string SerializeToJson(object obj)
        {
            DataContractJsonSerializer serializer = new(obj.GetType());
            using MemoryStream memoryStream = new();
            serializer.WriteObject(memoryStream, obj);
            memoryStream.Position = 0;
            using StreamReader reader = new(memoryStream);
            return reader.ReadToEnd();
        }
        private async void buttonGetRoomInfo_Click(object sender, EventArgs e)
        {
            Room[] rooms = await GetRoomInformation();
            DisplayRoomInformation(rooms);
        }
        private async void buttonReserve_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxNumPeople.Text, out int numPeople))
            {
                MessageBox.Show("Invalid number of people.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxNumDays.Text, out int numDays))
            {
                MessageBox.Show("Invalid number of days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Guest guest = new() { NumPeople = numPeople, Days = numDays };
            bool success = await MakeReservation(guest);
            if (success)
            {
                MessageBox.Show("Reservation successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No vacant rooms available.", "Reservation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}