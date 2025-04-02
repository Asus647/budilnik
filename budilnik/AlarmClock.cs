using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace budilnik
{
    /// <summary>
    /// Класс <see cref="AlarmClock"/> представляет будильник с возможностями установки времени, 
    /// обработки состояний и управления визуальными элементами интерфейса.
    /// </summary>
    public class AlarmClock
    {
        // Текущее состояние будильника
        private IAlarmClockState state;
        // Время, когда должен сработать будильник
        public DateTime AlarmTime { get; set; }
        private SoundPlayer player;

        public Label lblCurrentTime;
        public Panel panelBackground;
        public Button btnStopAlarm;
        public Button btnSnooze;
        public Button btnSetAlarm;

        /// <summary>
        /// Инициализирует новый экземпляр класса с заданными элементами интерфейса.
        /// </summary>
        /// <param name="timeLabel">Метод для отображения текущего времени.</param>
        /// <param name="backgroundPanel">Панель для изменения фона состояния будильника.</param>
        /// <param name="stopButton">Кнопка для остановки сигнализации.</param>
        /// <param name="snoozeButton">Кнопка для отложенного сигнала.</param>
        /// <param name="setButton">Кнопка для установки будильника.</param>
        public AlarmClock(Label timeLabel, Panel backgroundPanel, Button stopButton, Button snoozeButton, Button setButton)
        {
            lblCurrentTime = timeLabel;
            panelBackground = backgroundPanel;
            btnStopAlarm = stopButton;
            btnSnooze = snoozeButton;
            btnSetAlarm = setButton;
            state = new RunningState();
        }

        /// <summary>
        /// Устанавливает новое состояние будильника 
        /// и обновляет визуальные элементы.
        /// </summary>
        /// <param name="newState">Новое состояние, которое будет установлено.</param>
        public void SetState(IAlarmClockState newState)
        {
            state = newState;
            state.Handle(this);
        }

        /// <summary>
        /// Устанавливает время срабатывания будильника и проверяет, 
        /// нужно ли сразу перейти в состояние сигнализации.
        /// </summary>
        /// <param name="alarmTime">Время, по которому должен сработать будильник.</param>
        public void SetAlarmTime(DateTime alarmTime)
        {
            AlarmTime = alarmTime;
            if (DateTime.Now >= AlarmTime)
                SetState(new AlarmingState());
        }

        /// <summary>
        /// Переводит будильник в состояние отложенного сигнала.
        /// </summary>
        public void Snooze()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
            }
            SetState(new SnoozingState());
        }

        /// <summary>
        /// Останавливает сигнализацию 
        /// и возвращает будильник в состояние работы.
        /// </summary>
        public void StopAlarm()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
            }
            // Остановить звук будильника
            SetState(new RunningState());
            btnStopAlarm.Visible = false; // Скрыть кнопку "Выключить"
            btnSnooze.Visible = false; // Скрыть кнопку "Отложить"
            btnSetAlarm.Visible = true;
        }

        /// <summary>
        /// Обновляет состояние будильника и проверяет, нужно ли срабатывать будильнику.
        /// </summary>
        public void Update()
        {
            state.Handle(this);
            if (DateTime.Now.Hour == AlarmTime.Hour &&
                DateTime.Now.Minute == AlarmTime.Minute && DateTime.Now.Second == AlarmTime.Second)
            {
                player = new SoundPlayer("C:\\Users\\diank\\Downloads\\free-sound-effects-AA2G06A6.wav");
                player.PlayLooping();
                SetState(new AlarmingState());
            }
        }
    }
}
