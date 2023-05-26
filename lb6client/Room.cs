using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lb6client
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
