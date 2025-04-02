using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace budilnik
{
    /// <summary>
    /// Клас представляет состояние "Отложенный будильник" для будильника.
    /// В этом состоянии будильник сигнализирует, что сигнал отложен, изменяет цвет фона панели
    /// и начинает таймер для возвращения в состояние "Сигнализация".
    /// </summary>
    public class SnoozingState : IAlarmClockState
    {
        private Timer snoozeTimer;

        public void Handle(AlarmClock context)
        {
            context.panelBackground.BackColor = Color.Yellow; // Желтый
            context.lblCurrentTime.Text = "Сигнал отложен!\n";
            context.lblCurrentTime.Text += DateTime.Now.ToString("Время: HH:mm:ss");
            // Установим время ожидания в 30 секунд
            DateTime snoozeEndTime = DateTime.Now.AddSeconds(30);

            // Установим время ожидания в 30 секунд
            snoozeTimer = new Timer((e) =>
            {
                context.SetState(new AlarmingState());
            }, null, 30000, Timeout.Infinite);
        }
    }
}
