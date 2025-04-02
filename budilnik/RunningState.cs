using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace budilnik
{
    /// <summary>
    /// Этот класс реализует интерфейс IAlarmClockState и отвечает за обработку
    /// логики, связанной с действием будильника, когда он находится в активном состоянии.
    /// </summary>
    public class RunningState : IAlarmClockState
    {
        public void Handle(AlarmClock context)
        {
            context.panelBackground.BackColor = Color.LightBlue; // Светло-голубой
            context.lblCurrentTime.Text = DateTime.Now.ToString("Время: HH:mm:ss");
        }
    }
}
