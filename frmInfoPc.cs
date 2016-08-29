 
// Type: Aptusoft.frmInfoPc
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmInfoPc : Form
  {
    private IContainer components = (IContainer) null;
    private Label lblDisco;
    private Label lblCpu;
    private Label lblMac;

    public frmInfoPc()
    {
      this.InitializeComponent();
      this.lblDisco.Text = this.GetHDSerial();
      this.lblCpu.Text = this.GetCPUId();
      this.lblMac.Text = this.GetMACAddress();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblDisco = new Label();
      this.lblCpu = new Label();
      this.lblMac = new Label();
      this.SuspendLayout();
      this.lblDisco.AutoSize = true;
      this.lblDisco.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDisco.Location = new Point(31, 34);
      this.lblDisco.Name = "lblDisco";
      this.lblDisco.Size = new Size(51, 16);
      this.lblDisco.TabIndex = 0;
      this.lblDisco.Text = "label1";
      this.lblCpu.AutoSize = true;
      this.lblCpu.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblCpu.Location = new Point(31, 62);
      this.lblCpu.Name = "lblCpu";
      this.lblCpu.Size = new Size(51, 16);
      this.lblCpu.TabIndex = 1;
      this.lblCpu.Text = "label2";
      this.lblMac.AutoSize = true;
      this.lblMac.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMac.Location = new Point(31, 90);
      this.lblMac.Name = "lblMac";
      this.lblMac.Size = new Size(51, 16);
      this.lblMac.TabIndex = 2;
      this.lblMac.Text = "label3";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(284, 146);
      this.Controls.Add((Control) this.lblMac);
      this.Controls.Add((Control) this.lblCpu);
      this.Controls.Add((Control) this.lblDisco);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmInfoPc";
      this.Text = "Información el Pc";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public string GetCPUId()
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      try
      {
        foreach (ManagementObject managementObject in new ManagementClass("Win32_Processor").GetInstances())
        {
          if (str1 == string.Empty)
            str1 = managementObject.Properties["ProcessorId"].Value.ToString();
        }
        return str1;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message);
        return "malo";
      }
    }

    public string GetHDSerial()
    {
      return new ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"").Properties["VolumeSerialNumber"].Value.ToString();
    }

    public string GetMACAddress()
    {
      ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
      string str = string.Empty;
      foreach (ManagementObject managementObject in instances)
      {
        if (str == string.Empty)
        {
          if ((bool) managementObject["IPEnabled"])
            str = managementObject["MacAddress"].ToString();
          managementObject.Dispose();
        }
      }
      return str.Replace(":", "-");
    }
  }
}
