using BLL.DTO_s;
using BLL.Entitys;
using BLL.Enums;
using BLL.Interfaces;
using MySql.Data.MySqlClient;
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

        DatabaseConnection connection = new DatabaseConnection();

        public List<ReminderDTO> GetRemindersByUserId(int user_id)
        {
            List<ReminderDTO> reminders = new List<ReminderDTO>();
            string query = "SELECT id, title, DESCRIPTION, url, DATE, category_id, url FROM reminder WHERE user_id = "+user_id+"";
            try
            {
                if (connection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ReminderDTO reminderDto = new ReminderDTO();
                        reminderDto.id = Convert.ToInt32(dataReader["id"]);
                        reminderDto.title = dataReader["title"].ToString();
                        reminderDto.description = dataReader["DESCRIPTION"].ToString();
                        reminderDto.date = dataReader["DATE"].ToString();

                        reminders.Add(reminderDto);
                    }

                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("An error occurred in the repository: " + ex);
            }

            return reminders;
        }

        public void CreateReminderForUser(Reminder reminder)
        {
            string query = "INSERT INTO reminder (title, description, url, date, category_id, user_id) VALUES (@title, @description, @url, @date, @category_id, 1)";
            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.connection))
                    {
                        cmd.Parameters.AddWithValue("@title", reminder.title);
                        cmd.Parameters.AddWithValue("@description", reminder.description);
                        cmd.Parameters.AddWithValue("@url", reminder.url);
                        cmd.Parameters.AddWithValue("@date", reminder.date);
                        cmd.Parameters.AddWithValue("@category_id", reminder.type);
                            cmd.Parameters.AddWithValue("@user_id", reminder.user.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("An error occurred in the repository: " + ex.Message);
            }
        }

    }
}
