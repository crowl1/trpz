using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    public class Goods : ObservableCollection<Good>
    {
        public Goods()
        {
            this.Add(new Good { Name = "Молоко", ExecutionTime = 450 });
            this.Add(new Good { Name = "Хліб", ExecutionTime = 200 });
            this.Add(new Good { Name = "Торти", ExecutionTime = 1000 });
        }
    }
}
