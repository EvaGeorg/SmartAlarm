using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    [Serializable]
    class AlarmDoc
    {
        public List<Alarm> alarms;

        public AlarmDoc()
        {
            alarms =new List<Alarm>();
        }

        public void AddAlarm(Alarm a)
        {
            alarms.Add(a);
        }

        public void RemoveAlarm(Alarm a)
        {
            alarms.Remove(a);
        }

        public List<Alarm> GetAlarms()
        {
            return alarms;
        }
    }
}
