using BLL.DTO_s;
using BLL.Interfaces;
using Reminder_BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReminderService
    {
        List<Reminder> reminders = new List<Reminder>();

        private readonly IReminderRepository repository;

        public ReminderService(IReminderRepository repo)
        {
            repository = repo;
        }

        public List<Reminder> GetReminders(int user_id)
        {
            List<ReminderDTO> reminderDtos = repository.GetRemindersByUserId(user_id);
            List<Reminder> reminders = reminderDtos.Select(dto => new Reminder(dto)).ToList();

            return reminders;
        }
    }
}
