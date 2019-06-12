using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SysMngToolDemo.JsonSample
{
    // [C#] C#でJSONを扱う方法まとめ
    // https://dev.classmethod.jp/etc/c-sharp-json/
    [DataContract]
    public class Person
    {
        [DataMember(Name="name")]
        public string Name { get; set; }

        [DataMember(Name = "age")]
        public int Age { get; set; }
    }
}
