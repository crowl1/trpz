using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public string NameCustomer { get; set; }
        public long TimeLeft { get; set; }

        public int StorageIN { get; set; }
        public int GoodIN { get; set; }
    }
}
