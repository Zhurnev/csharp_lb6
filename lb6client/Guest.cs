using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lb6client
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
