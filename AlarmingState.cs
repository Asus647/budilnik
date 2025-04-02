using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace budilnik
{
    public class AlarmingState : IAlarmClockState
    {
        public void Handle(AlarmClock context)
        {
            context.panelBackground.BackColor = Color.Red; // Красный
            context.lblCurrentTime.Text = "Будильник сработал!\n";
            context.lblCurrentTime.Text += DateTime.Now.ToString("Время: HH:mm:ss");


            // Воспроизведение звука
            SoundPlayer player = new SoundPlayer("path_to_alarm_sound.wav"); // Укажите путь к вашему звуку
            player.PlayLooping();

            context.btnSnooze.Visible = true;
            context.btnStopAlarm.Visible = true;
            context.btnSetAlarm.Visible = false;
        }
    }
}
