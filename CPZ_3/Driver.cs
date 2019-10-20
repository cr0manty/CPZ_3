using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_3
{
    public class Driver
    {
        public enum OS_Type
        {
            Windows, Linux,
            DOS, MacOS
        }

        private string name;
        private int version;
        private OS_Type osType;
        private Device.DeviceType deviceType;

        public Device.DeviceType DeviceType
        {
            get { return deviceType; }
            set => deviceType = value;
        }

        public OS_Type OSType
        {
            get { return osType; }
            set { osType = value; }
        }

        public int Version
        {
            get { return this.version; }
            set
            {
                if (value <= 0)
                    throw new Exception("New driver version must be greater than zero!");
                this.version = value;
            }
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

        public Driver(string _name, int _version, OS_Type _os_type, Device.DeviceType _type)
        {
            if (String.IsNullOrEmpty(_name))
                throw new Exception("Driver need name!");
            else if (_version <= 0)
                throw new Exception("Version can't be negative!");

            this.name = _name;
            this.version = _version;
            this.OSType = _os_type;
            this.DeviceType = _type;
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode() + version.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Driver driver = obj as Driver;
            if (driver as Driver == null)
                return false;

            return this.version == driver.version && this.DeviceType == driver.DeviceType &&
                this.OSType == driver.OSType;
        }

        public static bool operator ==(Driver _this, Driver _driver)
        {
            if (_this.version == _driver.version && _this.deviceType == _driver.deviceType &&
                _this.osType == _driver.osType)
                return true;
            return false;
        }

        public static bool operator !=(Driver _this, Driver _driver)
        {
            if (_this.version != _driver.version || _this.DeviceType != _driver.DeviceType ||
                _this.OSType != _driver.OSType)
                return true;
            return false;
        }

        public bool check_compatibility(Device _device, OS_Type _os_type)
        {
            if (this.DeviceType == _device.Type && this.OSType == _os_type)
                return true;
            return false;
        }

        public void update_version(int newVersion)
        {
            if(newVersion < this.Version)
                throw new Exception("New driver version must be greater than old!");
            this.Version = newVersion;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
