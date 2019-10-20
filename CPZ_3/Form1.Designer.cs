namespace CPZ_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DriverList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviceList = new System.Windows.Forms.ListBox();
            this.GenerateDrivers = new System.Windows.Forms.Button();
            this.DeviceAdd = new System.Windows.Forms.Button();
            this.DeviceDelete = new System.Windows.Forms.Button();
            this.CmpDriver = new System.Windows.Forms.Button();
            this.DeleteDriver = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbIsCompReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriverList
            // 
            this.DriverList.FormattingEnabled = true;
            this.DriverList.Location = new System.Drawing.Point(12, 22);
            this.DriverList.Name = "DriverList";
            this.DriverList.Size = new System.Drawing.Size(157, 121);
            this.DriverList.TabIndex = 0;
            this.DriverList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DriverList_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ДРАЙВЕРЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "УСТРОЙСТВА";
            // 
            // DeviceList
            // 
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.Location = new System.Drawing.Point(216, 22);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(157, 121);
            this.DeviceList.TabIndex = 3;
            this.DeviceList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DeviceList_MouseDoubleClick);
            // 
            // GenerateDrivers
            // 
            this.GenerateDrivers.Location = new System.Drawing.Point(12, 149);
            this.GenerateDrivers.Name = "GenerateDrivers";
            this.GenerateDrivers.Size = new System.Drawing.Size(157, 23);
            this.GenerateDrivers.TabIndex = 5;
            this.GenerateDrivers.Text = "ГЕНЕРАЦИЯ ДРАЙВЕРОВ";
            this.GenerateDrivers.UseVisualStyleBackColor = true;
            this.GenerateDrivers.Click += new System.EventHandler(this.GenerateDrivers_Click);
            // 
            // DeviceAdd
            // 
            this.DeviceAdd.Location = new System.Drawing.Point(216, 149);
            this.DeviceAdd.Name = "DeviceAdd";
            this.DeviceAdd.Size = new System.Drawing.Size(76, 23);
            this.DeviceAdd.TabIndex = 6;
            this.DeviceAdd.Text = "ДОБАВИТЬ";
            this.DeviceAdd.UseVisualStyleBackColor = true;
            this.DeviceAdd.Click += new System.EventHandler(this.DeviceAdd_Click);
            // 
            // DeviceDelete
            // 
            this.DeviceDelete.Location = new System.Drawing.Point(298, 149);
            this.DeviceDelete.Name = "DeviceDelete";
            this.DeviceDelete.Size = new System.Drawing.Size(75, 23);
            this.DeviceDelete.TabIndex = 7;
            this.DeviceDelete.Text = "УДАЛИТЬ";
            this.DeviceDelete.UseVisualStyleBackColor = true;
            this.DeviceDelete.Click += new System.EventHandler(this.DeviceDelete_Click);
            // 
            // CmpDriver
            // 
            this.CmpDriver.Location = new System.Drawing.Point(94, 178);
            this.CmpDriver.Name = "CmpDriver";
            this.CmpDriver.Size = new System.Drawing.Size(75, 23);
            this.CmpDriver.TabIndex = 9;
            this.CmpDriver.Text = "СРАВНИТЬ";
            this.CmpDriver.UseVisualStyleBackColor = true;
            this.CmpDriver.Click += new System.EventHandler(this.CmpDriver_Click);
            // 
            // DeleteDriver
            // 
            this.DeleteDriver.Location = new System.Drawing.Point(12, 178);
            this.DeleteDriver.Name = "DeleteDriver";
            this.DeleteDriver.Size = new System.Drawing.Size(76, 23);
            this.DeleteDriver.TabIndex = 8;
            this.DeleteDriver.Text = "УДАЛИТЬ";
            this.DeleteDriver.UseVisualStyleBackColor = true;
            this.DeleteDriver.Click += new System.EventHandler(this.DeleteDriver_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbIsCompReady});
            this.statusStrip1.Location = new System.Drawing.Point(0, 207);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(391, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbIsCompReady
            // 
            this.lbIsCompReady.Name = "lbIsCompReady";
            this.lbIsCompReady.Size = new System.Drawing.Size(118, 17);
            this.lbIsCompReady.Text = "toolStripStatusLabel1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(175, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(175, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 229);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CmpDriver);
            this.Controls.Add(this.DeleteDriver);
            this.Controls.Add(this.DeviceDelete);
            this.Controls.Add(this.DeviceAdd);
            this.Controls.Add(this.GenerateDrivers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeviceList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DriverList);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СПЗ ЛАБА 3";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DriverList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DeviceList;
        private System.Windows.Forms.Button GenerateDrivers;
        private System.Windows.Forms.Button DeviceAdd;
        private System.Windows.Forms.Button DeviceDelete;
        private System.Windows.Forms.Button CmpDriver;
        private System.Windows.Forms.Button DeleteDriver;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbIsCompReady;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}