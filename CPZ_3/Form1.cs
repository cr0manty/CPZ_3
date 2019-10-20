using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPZ_3
{
    public partial class Form1 : Form
    {
        public DriverManager manager;
        public Form1()
        {
            InitializeComponent();
            this.manager = new DriverManager(Driver.OS_Type.MacOS);
            lbIsCompReady.Text = "Готовность к работе: не готово";
        }

        private void DeviceDelete_Click(object sender, EventArgs e)
        {
            int index = this.DeviceList.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                this.manager.delete_device(this.manager.Devices[index]);
                this.update_devices();

                update_comp_work_label();
            }
            else
            {
                MessageBox.Show("No devices have been selected!", "Error", MessageBoxButtons.OK);
            }
        }

        public void update_devices()
        {
            this.DeviceList.Items.Clear();
            foreach (var item in this.manager.Devices)
            {
                this.DeviceList.Items.Add(item);
            }
        }

        public void update_drivers()
        {
            this.DriverList.Items.Clear();
            foreach (var item in this.manager.Drivers)
            {
                this.DriverList.Items.Add(item);
            }
        }

        private void update_comp_work_label()
        {
            this.manager.is_comp_work();
            if (this.manager.Comp_ready)
                lbIsCompReady.Text = "Готовность к работе: готово";
            else
                lbIsCompReady.Text = "Готовность к работе: не готово";
        }

        private void DeviceAdd_Click(object sender, EventArgs e)
        {
            CreateDevice form = new CreateDevice();
            form.Show(this);
        }

        private void GenerateDrivers_Click(object sender, EventArgs e)
        {
            manager.download_drivers();
            this.update_drivers();
        }

        private void DriverList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.DriverList.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                Driver driver = manager.Drivers.ElementAt(index).Value;
                EditDriver form = new EditDriver(ref driver);
                form.Show(this);
            }
        }

        private void DeleteDriver_Click(object sender, EventArgs e)
        {
            int index = this.DriverList.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                this.manager.delete_driver(this.manager.Drivers.ElementAt(index).Key);
                this.update_drivers();
            }
            else
            {
                MessageBox.Show("No drivers have been selected!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int driver_index = this.DriverList.SelectedIndex;
            int device_index = this.DeviceList.SelectedIndex;

            if ((driver_index != ListBox.NoMatches) && (device_index != ListBox.NoMatches))
            {
                var device = this.manager.Devices.ElementAt(device_index);
                var driver = this.manager.Drivers.ElementAt(driver_index).Value;

                if (device.driver_compatible(driver) && driver.check_compatibility(device, this.manager.OS_Type))
                {
                    device.set_driver(driver);

                    update_comp_work_label();
                }
                else
                    MessageBox.Show("Driver is not compatible with device", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("You must select device and driver", "Error", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index = this.DeviceList.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                this.manager.Devices.ElementAt(index).delete_driver();

                update_comp_work_label();
            }
            else
                MessageBox.Show("No devices have been selected!", "Error", MessageBoxButtons.OK);
        }

        private void CmpDriver_Click(object sender, EventArgs e)
        {
            int driver_index = this.DriverList.SelectedIndex;
            int device_index = this.DeviceList.SelectedIndex;

            if ((driver_index != ListBox.NoMatches) && (device_index != ListBox.NoMatches))
            {
                var driver1 = this.manager.Devices.ElementAt(device_index).Driver;
                var driver2 = this.manager.Drivers.ElementAt(driver_index).Value;

                if(driver1 is null)
                {
                    MessageBox.Show("Selected device do not have a driver", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (driver1 == driver2)
                {
                    MessageBox.Show("Drivers are equal", "Comparsion result", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Drivers are NOT equal", "Comparsion result", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("You must select device and driver", "Error", MessageBoxButtons.OK);
        }

        private void DeviceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.DeviceList.SelectedIndex;

            if (index != ListBox.NoMatches)
            {
                var device = manager.Devices.ElementAt(index);
                CreateDevice form = new CreateDevice(ref device);
                form.Show(this);
            }
        }
    }
}
