using BLL.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IReminderRepository
    {
        List<ReminderDTO> GetRemindersByUserId(int user_id);
    }
}
