using BLL.Enums;
using Reminder_BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO_s
{
    public class ReminderDTO
    {
        public ReminderDTO() 
        {
            user = new UserDTO();
        }
        public ReminderDTO(Reminder reminder) : this()
        {
            id = reminder.id;
            title = reminder.title;
            description = reminder.description;
            url = reminder.url;
            date = reminder.date;
            user.username = reminder.user.username;
            user.company = reminder.user.company;
            type = reminder.type;
        }

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string date { get; set; }
        public UserDTO user { get; set; }
        public ReminderType type { get; set; }

    }
}
