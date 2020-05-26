using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    class Drivers : ObservableCollection<Driver>
    {
        public Drivers()
        {
            this.Add(new Driver { ID = 0, Name = "Олександр", MpS = 30, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            this.Add(new Driver { ID = 1, Name = "Роман", MpS = 20, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            this.Add(new Driver { ID = 2, Name = "Олексій", MpS = 50, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            this.Add(new Driver { ID = 3, Name = "Антон", MpS = 40, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            this.Add(new Driver { ID = 4, Name = "Андрій", MpS = 15, ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
        }
    }
}
