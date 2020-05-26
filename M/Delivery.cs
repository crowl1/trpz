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
        public ObservableCollection<Manager> ManagersM { get; set; }
        public ObservableCollection<Driver> DriversM { get; set; }
        public Delivery()
        {
            ManagersM = new Managers();
            DriversM = new Drivers();
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

            foreach (Manager m in ManagersM) //наповнюється додатковий список, який потрібен для знаходження min значення
            {
                manager_time.Add(m.ReleaseTime);
            }
            
            long time_left = manager_time.Min();


            foreach (Manager m in ManagersM)
            {
                if (m.ReleaseTime == time_left)
                {
                    if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() >= m.ReleaseTime)
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

            foreach (Driver d in DriversM)
            {
                driver_time.Add(d.ReleaseTime);
            }

            long time_left = driver_time.Min();


            foreach (Driver d in DriversM)
            {
                if (d.ReleaseTime == time_left)
                {
                    Console.WriteLine(d.ReleaseTime);
                    if (DateTimeOffset.UtcNow.ToUnixTimeSeconds() >= d.ReleaseTime)
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
