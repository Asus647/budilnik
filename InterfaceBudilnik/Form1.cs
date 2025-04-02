using budilnik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceBudilnik
{
    public partial class Form1 : Form
    {
        private AlarmClock alarmClock;

        public Form1()
        {
            InitializeComponent();
            alarmClock = new AlarmClock(lblCurrentTime, panelBackground, btnStopAlarm, btnSnooze, btnSetAlarm);

            Timer timer = new Timer();
            timer.Interval = 1000; // Обновление каждую секунду
            timer.Tick += (s, e) => UpdateTime();
            timer.Start();

            btnSetAlarm.Click += (s, e) =>
            {
                alarmClock.SetAlarmTime(dtpAlarmTime.Value);
            };

            btnSnooze.Click += (s, e) =>
            {
                alarmClock.Snooze();
            };

            btnStopAlarm.Click += (s, e) =>
            {
                alarmClock.StopAlarm();
            };
        }

        private void UpdateTime()
        {
            alarmClock.Update();
        }
    } 
}
