using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using AlarmClock.Properties;
using System.Globalization;

namespace AlarmClock
{
    [Serializable]
    public class Alarm
    {
        public String Date { set; get; }
        public String Time { set; get; }
        public int Snooze { set; get; }
        public int Limit { set; get; }
        public String Ringtone { set; get; }
        public int Game { set; get; }  
        public SoundPlayer  player { set; get; }
        public bool AlarmOn { set; get; }
        public bool Done { set; get; }
        public Alarm(String date, String time, int snooze, int limit,String ringtone, int game)
        {
            this.Time = time;
            this.Date = date;
            this.Snooze = snooze;
            this.Ringtone = ringtone;
            this.Limit = limit;
            this.Ringtone = ringtone;
            setSong();
            Game = game;  
            AlarmOn = false;
            Done = false;
        }

        public bool check()
        {
            String currDate = DateTime.Now.ToString("dd/MM/yyyy");
            String currTime = DateTime.Now.ToString("h:m tt");
            
            if (Date == currDate && Time == currTime && Limit == 0)
            {
               
                return true;
            } 
            else
            {
                if (Date == currDate && Time == currTime && AlarmOn == false)
                {
                    AlarmOn = true;
                    SnoozeIt snoozeBox = new SnoozeIt();
                    player.Play();
                    if (snoozeBox.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    {
                        player.Stop();
                        AlarmOn = false;

                        if (Game == 0) Done = true;

                        return true;
                    }
                    else
                    {
                        player.Stop(); 
                        AlarmOn =false;
                        DateTime dateTime = DateTime.Now;
                        dateTime = dateTime.AddMinutes(Snooze);
                        Date = dateTime.ToString("dd/MM/yyyy");
                        Time = dateTime.ToString("h:m tt");
                        Limit--;
                        
                    }
                }
                return false;
            }
        }

        public void start()
        {

            if (Game == 1)
            {
                AlarmOn = true;
                player.Play();

                Maze mazeGame = new Maze();
                if (mazeGame.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AlarmOn = false;
                    player.Stop();
                    Done = true;
                }
            }

            
            else if(Game == 2)
            {
                AlarmOn = true;
                player.Play();

                Shuffle shuffleGame = new Shuffle();
                if (shuffleGame.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AlarmOn = false;
                    player.Stop();
                    Done = true;
                }
            }

            else if(Game == 3)
            {
                AlarmOn = true;
                player.Play();

                Quiz quiz = new Quiz();

                if (quiz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AlarmOn = false;
                    player.Stop();
                    Done = true;
                }

            }
        }

        public override string ToString()
        {
            //throws exception here !

            //no exception -- has problem with provider still -- change is temporary untill better solution is found
            DateTime dateTime = DateTime.ParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            // this one works perfect for me :D

            //DateTime dateTime = DateTime.Parse(Date);
            // System.FormatException: 'String was not recognized as a valid DateTime.'


            String dayOfWeek = dateTime.ToString("dddd");
            // String off_on = Done == true ? " - OFF" : " - ON";
            return String.Format(Time + ", " + dayOfWeek + " " + Date);
            //+ off_on);
        }
        
        public void setSong()
        {
            if (Ringtone == "Lalala")
                player = new SoundPlayer(Resources.lalala);
            else if (Ringtone == "Highway to Hell")
                player = new SoundPlayer(Resources.highwayToHell);
            else if (Ringtone == "The Trooper")
                player = new SoundPlayer(Resources.theTrooper);
            else if (Ringtone == "Chop Suey")
                player = new SoundPlayer(Resources.chopSuey);
            else if (Ringtone == "Girl you'll be woman soon")
                player = new SoundPlayer(Resources.girlWoman);
            else if (Ringtone == "Bad to the bone")
                player = new SoundPlayer(Resources.BadToTheBone);
            else if (Ringtone == "Neat-neat-neat")
                player = new SoundPlayer(Resources.neat);

        }
    }
}
