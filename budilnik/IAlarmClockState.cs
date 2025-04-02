using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budilnik
{
    /// <summary>
    /// Интерфейс IAlarmClockState определяет состояния будильника.
    /// </summary>
    public interface IAlarmClockState
    {
        // <summary>
        /// Обрабатывает действия будильника в зависимости от его состояния.
        /// </summary>
        /// <param name="context">Контекст будильника, который необходимо обработать.</param>
        void Handle(AlarmClock context);
    }
}
