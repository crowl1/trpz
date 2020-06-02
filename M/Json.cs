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
    public class Files<T>
    {
        static string Dir()
        {
            string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] BaseDirectory_list = BaseDirectory.Split('\\');
            string Directory = "";
            for (int a = 0; a < BaseDirectory_list.Count() - 4; a++)
            {
                Directory = Directory + BaseDirectory_list[a] + "\\";
            }
            Directory = Directory + "M\\Data\\";
            return Directory;
        }

        public static void Write(ObservableCollection<T> OrdersVM, string path)
        {
            File.WriteAllText(Dir() + path,(JsonConvert.SerializeObject(OrdersVM, Formatting.Indented)));
        }

       public static ObservableCollection<T> Read(string path)
        {
            using (StreamReader file = File.OpenText(Dir() + path))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (ObservableCollection<T>)serializer.Deserialize(file, typeof(ObservableCollection<T>));
            }
        }
    }
}
