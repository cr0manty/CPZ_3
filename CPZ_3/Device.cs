using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_3
{
    public class Device
    {
        public enum DeviceType
        {
            MOTHERBOARD, KEYBOARD,
            MEMORY, CPU, RAM,
            GPU, HARD_DRIVE,
            MOUSE, FLASH_CARD,
            CD_DVD, MONITOR, PRINTER,
            SCANER, NETWORK
        }
        private string name;
        private DeviceType type;
        private Driver driver;
        public Driver Driver { get { return driver; } }
        private bool work_ready;
        public bool Work_ready { get { return work_ready; } }

        public DeviceType Type
        {
            get { return type; }
            set => type = value;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(name))
                    throw new Exception("Name can't be null or white spaced");
                this.name = value;
            }
        }

        public Device(string _name, DeviceType _type)
        {
            if (_name.Length == 0)
                throw new Exception("Device need name!");
            this.name = _name;
            this.Type = _type;
            this.driver = null;
            this.work_ready = false;
        }

        public bool driver_compatible(Driver _driver)
        {
            if (this.Type == _driver.DeviceType)
                return true;
            return false;
        }

        public void set_driver(Driver _driver)
        {
                this.work_ready = true;
                this.driver = _driver;
        }

        public void delete_driver()
        {
            this.work_ready = false;
            this.driver = null;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
