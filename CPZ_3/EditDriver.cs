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
    public partial class EditDriver : Form
    {
        private Driver driver;

        public EditDriver(ref Driver _driver)
        {
            InitializeComponent();
            InitOSType();
            InitDeviceType();

            driver = _driver;
            textBoxName.Text = driver.Name;
            numericUpDownVersion.Value = driver.Version;
            comboBoxOSType.SelectedItem = driver.OSType;
            comboBoxDeviceType.SelectedItem = driver.DeviceType;
        }

        private void InitOSType()
        {
            comboBoxOSType.DataSource = Enum.GetValues(typeof(Driver.OS_Type));
        }

        private void InitDeviceType()
        {
            comboBoxDeviceType.DataSource = Enum.GetValues(typeof(Device.DeviceType));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int version = (int)numericUpDownVersion.Value;
            Driver.OS_Type osType = (Driver.OS_Type)comboBoxOSType.SelectedValue;
            Device.DeviceType deviceType = (Device.DeviceType)comboBoxDeviceType.SelectedValue;

            if(string.IsNullOrWhiteSpace(name))
                MessageBox.Show("The driver must have a name", "Error", MessageBoxButtons.OK);
            else if(version <= 0)
                    MessageBox.Show("The version of driver must be greater than zero", "Error", MessageBoxButtons.OK);
            else
            {
                driver.Name = name;
                driver.Version = version;
                driver.OSType = osType;
                driver.DeviceType = deviceType;

                Form1 main = this.Owner as Form1;
                main.update_drivers();
                this.Hide();
            }
        }
    }
}
