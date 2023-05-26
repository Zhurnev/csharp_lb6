using System.Runtime.Serialization;

namespace lb6server
{
    [DataContract]
    public class Guest
    {
        [DataMember]
        public int NumPeople { get; set; }
        [DataMember]
        public int Days { get; set; }
    }
}
