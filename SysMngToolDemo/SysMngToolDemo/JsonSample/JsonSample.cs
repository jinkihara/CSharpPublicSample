using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace SysMngToolDemo.JsonSample
{
    // [C#] C#でJSONを扱う方法まとめ
    // https://dev.classmethod.jp/etc/c-sharp-json/
    public class JsonSampleClass
    {
        public JsonSampleClass()
        {
            var p = new Person();
            p.Name = "Kihara Hitoshi";
            p.Age = 50;

            using(var ms = new MemoryStream())
            using(var sr = new StreamReader(ms))
            {
                var serializer = new DataContractJsonSerializer(typeof(Person));
                serializer.WriteObject(ms, p);
                ms.Position = 0;

                var json = sr.ReadToEnd();

                System.Console.WriteLine(json.ToString());

                ms.Position = 0;
                var deserialized = (Person)serializer.ReadObject(ms);

                System.Console.WriteLine("Name : {0} / Age : {1}", deserialized.Name, deserialized.Age);
                
            }
        }
    }

}
