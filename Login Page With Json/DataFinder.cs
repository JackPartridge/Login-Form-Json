using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page_With_Json
{
    class DataFinder
    {
        public static List<Data> _data = new List<Data>();
        public static void Main(string[] args)
        {
            LoadJson1();
            Mainframe.Main1();
        }
        public static void LoadJson1()
        {
            using (StreamReader r = new StreamReader(@"D:\C#\VS\Login Page With Json\passwords.json"))
            {
                string json = r.ReadToEnd();
                _data = JsonConvert.DeserializeObject<List<Data>>(json);
            }

        }
    }
}
