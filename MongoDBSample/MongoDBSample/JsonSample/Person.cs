using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization;

namespace MongoDBSample.JsonSample
{
    [DataContract]
    public class Person
    {
        [DataMember(Name="name")]
        public string Name { get; set; }

        [DataMember(Name="age")]
        public int Age { get; set; }

        [DataMember(Name = "birthday")]
        public string BirthDay { get; set; }

        public string Address { get; set; }

        [IgnoreDataMember]
        public string Gender { get; set; }
    }
}
