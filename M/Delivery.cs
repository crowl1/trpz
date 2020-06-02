using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M
{
    public class Delivery
    {


        public ObservableCollection<ManagerDTO> ManagersM { get; set; }
        public ObservableCollection<DriverDTO> DriversM { get; set; }
        public Delivery()
        {
            if (ManagersM == null)
            {
                ManagersM = Files<ManagerDTO>.Read("\\manager.json");
                DriversM = Files<DriverDTO>.Read("\\driver.json");
            }
        }


        public long orderProcessing(int meters, int TimeGood)
        {
            return TimeGood + Math.Min(ManagerCalculation(), DriverCalculation(meters));
        }

        List<long> manager_time = new List<long>();
        List<long> driver_time = new List<long>();


        long ManagerCalculation()
        {
            manager_time.Clear();

            foreach (ManagerDTO m in ManagersM) //наповнюється додатковий список, який потрібен для знаходження min значення
            {
                manager_time.Add(m.ReleaseTime);
            }
            
            long time_left = manager_time.Min();


            foreach (ManagerDTO m in ManagersM)
            {
                if (m.ReleaseTime == time_left)
                {
                    if (m.ReleaseTime == 0)
                    {
                        m.ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    }
                    if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() <= m.ReleaseTime)
                    {
                        m.ReleaseTime += m.ExecutionTime;
                    }
                    else
                    {
                        m.ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + m.ExecutionTime;
                    }
                    return m.ReleaseTime;
                }
            }
            return 0;
        }


        long DriverCalculation(int meters)
        {
            driver_time.Clear();

            foreach (DriverDTO d in DriversM)
            {
                driver_time.Add(d.ReleaseTime);
            }

            long time_left = driver_time.Min();


            foreach (DriverDTO d in DriversM)
            {
                if (d.ReleaseTime == time_left)
                {
                    if (d.ReleaseTime == 0)
                    {
                        d.ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    }
                    if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() <= d.ReleaseTime)
                    {
                        d.ReleaseTime += meters / d.MpS;
                    }
                    else
                    {
                        d.ReleaseTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + meters / d.MpS;
                    }
                    return d.ReleaseTime;
                }
            }
            return 0;
        }
    }
}
