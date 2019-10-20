using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_3
{
    public class DriverManager
    {
        public Dictionary<int, Driver> Drivers { get; }
        public List<Device> Devices { get; }
        private Driver.OS_Type os_type;
        public Driver.OS_Type OS_Type { get { return os_type; } }
        private bool comp_ready;
        public bool Comp_ready { get { return comp_ready; } }
        private int amount_nonactive;

        private void update_amout_nonactive()
        {
            amount_nonactive = 0;
            foreach(var i in this.Devices)
            {
                if (!i.Work_ready)
                    amount_nonactive++;
            }
        }

        public void is_comp_work()
        {
            Device.DeviceType[] Important_Device_Types = {
                Device.DeviceType.MOTHERBOARD,
                Device.DeviceType.CPU,
                Device.DeviceType.GPU,
                Device.DeviceType.RAM,
                Device.DeviceType.HARD_DRIVE,
                Device.DeviceType.KEYBOARD
            };
            foreach (var i in Important_Device_Types)
            {
                bool flag = true;
                foreach (var j in this.Devices)
                {
                    if ((j.Type == i) && j.Work_ready)
                        flag = false;
                }
                if (flag)
                {
                    comp_ready = false;
                    return;
                }
            }
            comp_ready = true;
        }

        public DriverManager(Driver.OS_Type os_type)
        {
            this.os_type = os_type;
            this.Drivers = new Dictionary<int, Driver>();
            this.Devices = new List<Device>();
            this.comp_ready = false;
        }

        public void set_driver(ref Device device, Driver driver)
        {
            if (!device.driver_compatible(driver))
                throw new Exception("Driver is not compatible for this device!");
            device.set_driver(driver);
        }

        public bool driver_cmp(Driver driver, Driver driver_cmp)
        {
            if (driver == driver_cmp)
                return true;

            return false;
        }

        public void delete_driver_fromDevice(ref Device device, Driver driver)
        {
            device.delete_driver();
        }

        public void add_device(string name, Device.DeviceType type)
        {
            this.Devices.Add(new Device(name, type));
        }

        public void delete_device(Device device)
        {
            this.Devices.Remove(device);
        }

        public void delete_driver(int key)
        {
            this.Drivers.Remove(key);
        }

        public void download_drivers()
        {
            Random rand = new Random();

            for(int i = 0; i < rand.Next(1,10); i++)
            {
                string name = ($"{ Guid.NewGuid()}");
                int version = rand.Next(1, 100);
                Driver.OS_Type os_type = (Driver.OS_Type)rand.Next(1, 4);
                Device.DeviceType dev_type = (Device.DeviceType)rand.Next(1, 14);

                Driver driver = new Driver(name, version, os_type, dev_type);
                this.Drivers.Add(driver.GetHashCode(),driver);
            }
        }
    }
}