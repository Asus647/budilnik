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
    /// логики, связанной с действием будильника, когда он находится в состоянии "Сигнализация".
    /// </summary>
    public class AlarmingState : IAlarmClockState
    {
        public void Handle(AlarmClock context)
        {
            context.panelBackground.BackColor = Color.Red; // Красный
            context.lblCurrentTime.Text = "Будильник сработал!\n";
            context.lblCurrentTime.Text += DateTime.Now.ToString("Время: HH:mm:ss");


            //// Воспроизведение звука
            //SoundPlayer player = new SoundPlayer("C:\\Users\\diank\\Downloads\\free-sound-effects-AA2G06A6.wav"); 
            //player.PlayLooping();

            context.btnSnooze.Visible = true;
            context.btnStopAlarm.Visible = true;
            context.btnSetAlarm.Visible = false;
        }
    }
}
