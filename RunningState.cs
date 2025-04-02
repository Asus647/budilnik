using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace budilnik
{
    public class RunningState : IAlarmClockState
    {
        public void Handle(AlarmClock context)
        {
            context.panelBackground.BackColor = Color.LightBlue; // Светло-голубой
            context.lblCurrentTime.Text = DateTime.Now.ToString("Время: HH:mm:ss");
        }
    }
}
