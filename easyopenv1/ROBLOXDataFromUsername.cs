using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace easyopenv1
{
    [DataContract]
    class ROBLOXDataFromUsername
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string AvatarUri { get; set; }
        [DataMember]
        public string AvatarFinal { get; set; }
        [DataMember]

        
        
        public string IsOnline { get; set; }
    }
}
