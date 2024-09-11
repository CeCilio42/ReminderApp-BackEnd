using System.Configuration;
using System.Diagnostics;
using System.Reflection.Metadata;
using BLL.Interfaces;
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


        [HttpGet]
        [Route("GetReminders")]
        public IActionResult GetReminders()
        {
            int user_id = 3;
            try
            {
                var reminders = _reminderRepository.GetRemindersByUserId(user_id);
                return Ok(reminders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
