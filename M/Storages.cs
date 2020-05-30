using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    public class Storages : ObservableCollection<Storage>
    {
        public Storages()
        {
            this.Add(new Storage { ID = 0, Name = "Київський склад", Distance = 100000 });
            this.Add(new Storage { ID = 1, Name = "Одеський склад", Distance = 700000 });
            this.Add(new Storage { ID = 2, Name = "Рівненський склад", Distance = 450000 });
        }
    }
}
