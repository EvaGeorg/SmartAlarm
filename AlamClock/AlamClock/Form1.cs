using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmClock.Properties;

namespace AlarmClock
{
    public partial class Form1 : Form
    {

        private String FileName;
        private AlarmDoc alarmDoc;
        public Form1()
        {   
            InitializeComponent();
            FileName = null;
            alarmDoc = new AlarmDoc();
            timer1 = new Timer();
            DatePicker.Value = DateTime.Now;
            timer1.Start();
            btnRemove.Enabled = false;
            btnChange.Enabled = false;
            lbSongs.Items.Add("Lalala");
            lbSongs.Items.Add("Highway to Hell");
            lbSongs.Items.Add("The Trooper");
            lbSongs.Items.Add("Chop Suey");
            lbSongs.Items.Add("Girl you'll be woman soon");
            lbSongs.Items.Add("Neat-neat-neat");
            lbSongs.Items.Add("Bad to the bone");
        }
        private void setAlarm() {
            String date = DatePicker.Value.ToString("dd/MM/yyyy");
            String time = upDownHours.Value + ":" + upDownMinutes.Value + " " + upDownPMAM.Text;
            String song = "Lalala"; // default value
            if (lbSongs.SelectedItem != null)
                song = lbSongs.SelectedItem as String;

            int game = 0;   // if game is 0 means no game is played

            if (maze.Checked) game = 1;
            else if (shuffle.Checked) game = 2;
            else if (quiz.Checked) game = 3;
            else if (eat.Checked) game = 4;

            Alarm a = new Alarm(date, time, (int)upDownSnooze.Value, (int)upDownTimes.Value, song, game);
            lbAlarms.Items.Add(a);
            alarmDoc.AddAlarm(a);
        }
        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            setAlarm();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbAlarms.Items.Count != 0)
            {
                foreach (Alarm a in lbAlarms.Items)
                {
                    if (a.Done == true)
                    {
                        continue;
                    }
                    else if (a.check() && a.AlarmOn == false)
                    {
                        a.start();

                    }
                }
            }


        }

        private void upDownMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (upDownMinutes.Value == -1)
                upDownMinutes.Value = 59;
            if (upDownMinutes.Value == 60)
                upDownMinutes.Value = 0;
        }

        private void upDownHours_ValueChanged(object sender, EventArgs e)
        {
            if (upDownHours.Value == 0)
                upDownHours.Value = 12;
            if (upDownHours.Value == 13)
                upDownHours.Value = 1;
        }

        private void upDownSnooze_ValueChanged(object sender, EventArgs e)
        {
            if (upDownSnooze.Value != 0 && upDownTimes.Value == 0)
                upDownTimes.Value = 1;
            if (upDownSnooze.Value == 0)
                upDownTimes.Value = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lbAlarms.Items.Count; i++)
            {
                lbAlarms.Items.Remove(lbAlarms.SelectedItem);
            }
        }

        private void lbAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lbAlarms.SelectedItem != null;
            btnChange.Enabled = lbAlarms.SelectedItem != null;
        }

        private void upDownTimes_ValueChanged(object sender, EventArgs e)
        {
            if (upDownTimes.Value != 0 && upDownSnooze.Value == 0)
                upDownSnooze.Value = 1;
            if (upDownTimes.Value == 0)
                upDownSnooze.Value = 0;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Alarm selected = (lbAlarms.SelectedItem as Alarm);
            // Display all data for the chosen alarm and make changes
            if (selected != null) {
                setAlarm();
                lbAlarms.Items.Remove(selected);
                alarmDoc.RemoveAlarm(selected);
            }

        } 
      
    }
}
