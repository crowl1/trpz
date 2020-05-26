using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    public class Json
    {
        public static void Jsons(ObservableCollection<Order> OrdersVM)
        {
            File.WriteAllText(
                "C:/files.json",
                JsonConvert.SerializeObject(
                    OrdersVM.Select(hash => new { url = hash }),
                    Formatting.Indented));
        }
    }
}
