using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPZ_3
{
    public partial class CreateDevice : Form
    {
        private Device device;
        private bool flagEdit;
        public CreateDevice()
        {
            InitializeComponent();
            InitDeviceType();

            flagEdit = false;
        }

        public CreateDevice(ref Device _device)
        {
            InitializeComponent();
            InitDeviceType();

            device = _device;

            tbName.Text = device.ToString();
            cbDeviceType.SelectedItem = device.Type;
            flagEdit = true;
        }

        private void InitDeviceType()
        {
            cbDeviceType.DataSource = Enum.GetValues(typeof(Device.DeviceType));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var deviceType = (Device.DeviceType)cbDeviceType.SelectedValue;

            if (String.IsNullOrWhiteSpace(name))
                MessageBox.Show("Name cant be null or white spaced", "Error", MessageBoxButtons.OK);
            else
            {
                Form1 main = this.Owner as Form1;
                if (flagEdit)
                {
                    if(this.device.Type != deviceType)
                        this.device.delete_driver();

                    this.device.Name = name;
                    this.device.Type = deviceType;
                }
                else
                {
                    Device newDevice = new Device(name, deviceType);
                    main.manager.Devices.Add(newDevice);
                }

                main.update_devices();
                this.Hide();
            }
        }
    }
}
