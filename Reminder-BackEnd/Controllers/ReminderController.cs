using System.Configuration;
using System.Diagnostics;
using System.Reflection.Metadata;
using BLL.Interfaces;
using BLL.Request;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Reminder_BackEnd.Models;

namespace Reminder_BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class ReminderController : Controller
    {
        private readonly IReminderRepository _reminderRepository;

        public ReminderController(IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }


        [HttpPost]
        [Route("GetReminders")]
        public IActionResult GetRemindersByUserId([FromBody] UserRequest request)
        {
            int user_id = 3;
            try
            {
                var reminders = _reminderRepository.GetRemindersByUserId(request.UserId);
                return Json(reminders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
        }


        [HttpPost]
        [Route("CreateReminder")]
        public IActionResult CreateReminderForUser([FromBody] Reminder reminder)
        {
            try
            {
                _reminderRepository.CreateReminderForUser(reminder);

                return Json(new { message = "Blog created successfully" });
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
            
        }
    }
}
