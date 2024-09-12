using BLL.DTO_s;
using BLL.Entitys;
using BLL.Enums;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Reminder_BackEnd
{
    public class Reminder
    {
        public Reminder() 
        {

        }
        public Reminder(ReminderDTO reminderDto)
        {
            id = reminderDto.id;
            title = reminderDto.title;
            description = reminderDto.description;
            url = reminderDto.url;
            date = reminderDto.date;
            type = reminderDto.type;
            user.Id = reminderDto.user.Id;
            user.username = reminderDto.user.username;
        }

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }

        public string date { get; set; }
        public User user { get; set; }
        public ReminderType type { get; set; }

    }
}
