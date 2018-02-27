using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace TemperatureMonitor
{
    public partial class Window : Form
    {
        Computer thisComputer;
        public Window()
        {
            InitializeComponent();
            thisComputer = new Computer() { CPUEnabled = true };
            thisComputer.Open();

            Thread refresh = new Thread(refreshTemp);
            refresh.Start();
        }
        private void refreshTemp()
        {
            for (; ; )
            {
                String temp = "";
                foreach (var hardwareItem in thisComputer.Hardware)
                {
                    if (hardwareItem.HardwareType == HardwareType.CPU)
                    {
                        hardwareItem.Update();
                        foreach (IHardware subHardware in hardwareItem.SubHardware)
                            subHardware.Update();
                        foreach (var sensor in hardwareItem.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                temp += String.Format(sensor.Name+" = "+ (sensor.Value.HasValue ? sensor.Value.Value.ToString() : "No value") + "\r\n");
                            }
                        }
                    }
                }
                this.InvokeEx(f => output.Text = temp);
                Thread.Sleep(1000);
            }
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
    public static class ISynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            try
            {
                if (@this.InvokeRequired)
                {
                    @this.Invoke(action, new object[] { @this });
                }
                else
                {
                    action(@this);
                }
            }
            catch (Exception) { }
        }
    }
}