using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalTimes
{
    public partial class Form1 : Form
    {
        //Initialize times.
        DateTime timeLocal, timeIST, timePST, timeCST, timeEST, timeUTC;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Check text box datatype.
            CheckType();
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        public void Start()
        {
            int intFreq;

            //Set the timer to expected frequency.
            intFreq = Convert.ToInt32(boxFreq.Text.Trim()) * 1000;
            timer1.Interval = intFreq;
            //Start the timer.
            timer1.Enabled= true;
            lbStatus.Text = "Running...";
            timer1.Start();
        }

        public void Stop()
        {
            //Stop the timer.
            timer1.Stop();
            lbStatus.Text = "Stopped.";
        }

        public void CheckType()
        {
            string boxValue = boxFreq.Text;

            try
            {
                Convert.ToInt32(boxValue.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers for frequency! Setting to default 1 second.");
                timer1.Interval = 1000;
                boxFreq.Text = "1";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool summer;
            summer = WinterTime();
            timeLocal = DateTime.Now;
            timeUTC = DateTime.UtcNow;
            timeIST = timeUTC.AddHours(5.5);
            if (summer == true)
            {
                timePST = timeUTC.AddHours(-7);
                timeCST = timeUTC.AddHours(-5);
                timeEST = timeUTC.AddHours(-4);
            }
            else
            {
                timePST = timeUTC.AddHours(-8);
                timeCST = timeUTC.AddHours(-6);
                timeEST = timeUTC.AddHours(-5);
            }
            UpdateTimes();
        }

        private void UpdateTimes()
        {
            //Update lables with corresponding time.
            lbLocalTime.Text = Convert.ToString(timeLocal);
            lbUTCtime.Text = Convert.ToString(timeUTC);
            lbISTtime.Text = Convert.ToString(timeIST);
            lbPSTtime.Text = Convert.ToString(timePST);
            lbCSTtime.Text = Convert.ToString(timeCST);
            lbESTtime.Text = Convert.ToString(timeEST);
        }

        private bool WinterTime()
        {
            bool summer;
            DateTime dateNow = DateTime.Now;
            //Set the time zone to pacific time.
            TimeZoneInfo timezoneNow = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            //Check if pacific time zone is currently under daylight saving time.
            summer = timezoneNow.IsDaylightSavingTime(dateNow);
            //If true means Daylight Saving Time 夏令时.
            return summer;
        }

    }
}
