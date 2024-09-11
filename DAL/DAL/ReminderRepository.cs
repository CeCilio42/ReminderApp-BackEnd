using BLL.DTO_s;
using BLL.Entitys;
using BLL.Enums;
using BLL.Interfaces;
using Reminder_BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.DAL
{
    public class ReminderRepository : IReminderRepository
    {

        List<ReminderDTO> reminders = new List<ReminderDTO>  // Corrected type
        {
    new ReminderDTO(new Reminder
    {
        id = 1,
        title = "Doctor Appointment",
        description = "Annual check-up with Dr. Smith",
        url = "http://example.com/appointment",
        date = "2024-09-15",
        type = ReminderType.Private,
        user = new User
        {

            Id = 2,
            username = "johndoe",
            company = "HealthCorp",
        }
    }),
    new ReminderDTO(new Reminder
    {
        id = 2,
        title = "Team Meeting",
        description = "Monthly team meeting in conference room B",
        url = "http://example.com/meeting",
        date = "2024-09-20",
        type = ReminderType.Work,
        user = new User
        {
            Id = 3,
            username = "janedoe",
            company = "TechSoft",
        }
    }),
    new ReminderDTO(new Reminder
    {
        id = 3,
        title = "Project Deadline",
        description = "Submit final project report",
        url = "http://example.com/project",
        date = "2024-09-30",
        type = ReminderType.Private,
        user = new User
        {
            Id = 4,
            username = "alicesmith",
            company = "Consulting Inc.",
        }
    })
    {
        
    }
        };

        public List<ReminderDTO> GetRemindersByUserId(int user_id)
        {
            return reminders;
        }
    }
}
