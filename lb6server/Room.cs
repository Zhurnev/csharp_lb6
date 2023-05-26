using System.Runtime.Serialization;

namespace lb6server
{
    [DataContract]
    public class Room
    {
        [DataMember]
        public int RoomNumber { get; set; }

        [DataMember]
        public int Beds { get; set; }

        [DataMember]
        public decimal CostPerDay { get; set; }

        [DataMember]
        public bool IsOccupied { get; set; }

        [DataMember]
        public int DaysRemaining { get; set; }
    }
}
