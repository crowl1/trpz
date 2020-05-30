using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace M
{
    public class Jsons<T>
    {
        public static void Write(ObservableCollection<T> OrdersVM, string path)
        {

            File.WriteAllText(path,(JsonConvert.SerializeObject(OrdersVM, Formatting.Indented)));
        }

       public static ObservableCollection<T> Read(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (ObservableCollection<T>)serializer.Deserialize(file, typeof(ObservableCollection<T>));
            }
        }
    }
}
