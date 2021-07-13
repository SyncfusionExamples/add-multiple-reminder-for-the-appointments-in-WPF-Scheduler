using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SchedulerWPF
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection Events { get; set; }
        public SchedulerViewModel()
        {
            Events = new ScheduleAppointmentCollection();
            var scheduleAppointment = new ScheduleAppointment()
            {
                StartTime = DateTime.Now.AddHours(1),
                EndTime = DateTime.Now.AddHours(2),
                AppointmentBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF339933")),
                Subject = "Conference",
                Reminders = new ObservableCollection<SchedulerReminder>
                {
                    new SchedulerReminder { ReminderTimeInterval = new TimeSpan(0,0,05)},
                    new SchedulerReminder { ReminderTimeInterval = new TimeSpan(0,10,0)},
                    new SchedulerReminder { ReminderTimeInterval = new TimeSpan(0,45,0)},
                    new SchedulerReminder { ReminderTimeInterval = new TimeSpan(2,0,0)},
                    new SchedulerReminder { ReminderTimeInterval = new TimeSpan(3,0,0)},
                }
            };
            Events.Add(scheduleAppointment);
        }
    }
}
