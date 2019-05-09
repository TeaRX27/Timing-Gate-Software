using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
       
        Stopwatch watch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            string elapsedtime = String.Format("{0:00}:{1:00}.{2:00}"
                , Math.Floor(ts.TotalMinutes), ts.Seconds,ts.Milliseconds/10);
            Time.Text = elapsedtime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortBox.DataSource = ports;
            if (SerialSettings.Visible)
            {
                SerialSettings.Visible = false;
                ShowSettings.Text = "Show Serial Settings";
            }
            else
            {
                SerialSettings.Visible = true;
                ShowSettings.Text = "Hide Serial Settings";
            }
            
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            ArduPort.PortName = PortBox.SelectedItem.ToString();
            PortDisplay.Text = ArduPort.PortName;
        }

        private void PortDisplay_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            watch.Start();
            timer1.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            watch.Stop();
            timer1.Stop();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            watch.Reset();
            Time.Text = "00:00.00";
        }

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            string serialin = ArduPort.ReadExisting();
            string[] splitString = serialin.Split('\n');
            string control = splitString[0].Trim();
            if (control.Equals("n"))
            {
                StartButton_Click(sender, e);
                label2.Text= "Start";
            }
            else if(control.Equals("f"))
            {
                StopButton_Click(sender, e);
                label2.Text = "Stop";
            }
        }

        private void OpenSerial_Click(object sender, EventArgs e)
        {
            ArduPort.Open();
            DataTimer.Start();
            OpenSerial.Enabled = false;
            button2.Enabled = true;
            StartButton.Visible = false;
            StopButton.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            SelectButton.Enabled = false;
            ArduPort.Write("On");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduPort.Write("Off");
            ArduPort.Close();
            DataTimer.Stop();
            OpenSerial.Enabled = true;
            button2.Enabled = false;
            StartButton.Visible = true;
            StopButton.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            SelectButton.Enabled = true;
        }
    }
}
