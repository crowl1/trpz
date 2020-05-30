﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    public class Jsons<T>
    {
        public static void Write(ObservableCollection<T> OrdersVM)
        {
            File.WriteAllText(
                "C:/files.json",
                JsonConvert.SerializeObject(
                    OrdersVM.Select(hash => new { url = hash }),
                    Formatting.Indented));
        }

        public static ObservableCollection<T> Read()
        {

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"C:/files.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (ObservableCollection<T>)serializer.Deserialize(file, typeof(ObservableCollection<T>));
            }
        }
    }
}
