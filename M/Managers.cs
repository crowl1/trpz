using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    class Managers : ObservableCollection<Manager>
    {
        public Managers()
        {
            this.Add(new Manager { Name = "Антон", ExecutionTime = 150000, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            this.Add(new Manager { Name = "Анастасія", ExecutionTime = 250000, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() }); ;
            this.Add(new Manager { Name = "Роман", ExecutionTime = 450000, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
        }
    }
}
