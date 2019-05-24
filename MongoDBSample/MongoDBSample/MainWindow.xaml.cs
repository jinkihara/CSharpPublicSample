using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MongoDBSample.JsonSample;
using System.IO;
using System.Runtime.Serialization.Json;
using Codeplex.Data;
using System.Net;


namespace MongoDBSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person();
            p.Name = "Kihara Hitoshi";
            p.Age = 50;

            using(var ms=new MemoryStream())
            using(var sr = new StreamReader(ms))
            {
                int num = 1;
                // C#でJSONを扱う方法まとめ
                //   https://dev.classmethod.jp/etc/c-sharp-json1/

                // ①DataContractJsonSerializer
                Console.WriteLine("①DataContractJsonSerializer");
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
                serializer.WriteObject(ms, p);

                ms.Position = 0;
                var json1 = sr.ReadToEnd();

                Console.WriteLine("JSONの内容");
                Console.WriteLine("■" + (num++).ToString("00") + "■json1                     = 〔" + json1 + "〕");
                //Console.WriteLine($"{json1}");

                ms.Position = 0;
                var deSerializer = (Person)serializer.ReadObject(ms);
                Console.WriteLine("var deSerializer = (Person)serializer.ReadObject(ms);");
                Console.WriteLine("■" + (num++).ToString("00") + "■deSerializer.Name         = 〔" + deSerializer.Name + "〕");
                Console.WriteLine("■" + (num++).ToString("00") + "■deSerializer.Age          = 〔" + deSerializer.Age + "〕");

                ms.Position = 0;
                var deserializer2 = serializer.ReadObject(ms);
                Console.WriteLine("var deserializer2 = serializer.ReadObject(ms);");
                Console.WriteLine("■" + (num++).ToString("00") + "■deserializer2.ToString()  = 〔" + deserializer2.ToString() + "〕");

                // ②Json.NET
                //     Admin権限がなく、Json.NETパッケージがインストールできなかった

                // ③DynamicJson
                //   http://neue.cc/2010/05/06_257.html
                Console.WriteLine("③DynamicJson");
                //dynamic json3 = DynamicJson.Parse("{ \"_id\" : ObjectId(\"5cdd0c2bea7a99b7f668ac9e\"), \"name\" : \"mr.a\", \"age\" : 100, \"gender\" : \"XXX\", \"hobbies\" : [ \"xi\", \"ZZZ\", \"aa\" ], \"happy\" : \"yes\", \"lucky\" : \"yes\" }");
                dynamic json3 = DynamicJson.Parse(@"{ ""name"" : ""mr.a"", ""age"" : 100, ""gender"" : ""XXX"", ""hobbies"" : [ ""xi"", ""ZZZ"", ""aa"" ], ""happy"" : ""yes"", ""lucky"" : ""yes"" }");
                Console.WriteLine("JSONの内容");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3                     = 〔" + json3 + "〕");
                Console.WriteLine("表示");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.name                = 〔" + json3.name + "〕");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3[\"name\"]             = 〔" + json3["name"] + "〕");
                Console.WriteLine("項目の存在確認");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.IsDefined(\"name\")   = 〔" + json3.IsDefined("name") + "〕");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.name()              = 〔" + json3.name() + "〕");
                Console.WriteLine("項目の削除");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3(\"name\")             = 〔" + json3("name") + "〕  ←　これはobj.Delete(\"name\")と同じ");
                Console.WriteLine("項目の存在確認");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.IsDefined(\"name\")   = 〔" + json3.IsDefined("name") + "〕");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.name()              = 〔" + json3.name() + "〕");

                Console.WriteLine("表示");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.age                 = 〔" + json3.age + "〕");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3[\"age\"]              = 〔" + json3["age"] + "〕");
                Console.WriteLine("項目の存在確認");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.IsDefined(\"age\")    = 〔" + json3.IsDefined("age") + "〕");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.age()               = 〔" + json3.age() + "〕");
                Console.WriteLine("項目の削除");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.Delete(\"age\")       = 〔" + json3("age") + "〕  ←　これはobj(\"age\")と同じ");
                Console.WriteLine("項目の存在確認");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.IsDefined(\"age\")    = 〔" + json3.IsDefined("age") + "〕");
                Console.WriteLine("■" + (num++).ToString("00") + "■json3.age()               = 〔" + json3.age() + "〕");


                // Jsonに含まれるメンバー名の列挙（　GetDynamicMemberNamesメソッドを使う　）
                foreach (var name in ((DynamicJson)json3).GetDynamicMemberNames())
                {
                    Console.WriteLine("■" + (num++).ToString("00") + "■name = 〔" + name + "〕 / json3[name] = 〔" + json3[name] + "〕");
                }

                //// 蛇足（参考）
                //// http://neue.cc/2010/04/30_256.html
                //var publicTL = new WebClient().DownloadString(@"http://twitter.com/statuses/public_timeline.json1");
                //var statuses = DynamicJson.Parse(publicTL);
                //foreach (var status in (dynamic[])statuses)
                //{
                //    Console.WriteLine(status.user.screen_name);
                //    Console.WriteLine(status.text);
                //}


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // DataGrid1
            List<Dictionary<string, string>> dataSrc = new List<Dictionary<string, string>>();
            Dictionary<string, string> line;
            for (int row = 1; row < 10; row++)
            {
                line = new Dictionary<string, string>();
                for (int col = 1; col < 4; col++)
                {
                    line.Add("Field" + col, "value" + (row*10+col));
                }
                dataSrc.Add(line);
            }
            //DataGrid1.ItemsSource = dataSrc;
            DataGrid1.ItemsSource =dataSrc.ToArray();


            // DataGrid1
            List<Object> dataSrc2 = new List<object>();
            for (int i = 1; i < 4; i++)
            {
                dataSrc2.Add(new { Field1 = "Value"+i+"1", Field2 = "Value"+i+"2"});
            }
            DataGrid2.ItemsSource = dataSrc2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StdoutSample win = new StdoutSample();
            win.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Form1 win = new Form1();
            win.Show();
        }
    }
}
