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
        private StorageDTO _storageIN;
        private GoodDTO _goodIN;
        public int ID { get; set; }
        public string NameCustomer { get; set; }
        public long TimeLeft { get; set; }

        public StorageDTO StorageIN
        {
            get
            {
                return _storageIN;
            }
            set
            {
                value = _storageIN;
            }
        }
        public GoodDTO GoodIN
        {
            get
            {
                return _goodIN;
            }
            set
            {
                value = _goodIN;
            }
        }
    }
}
