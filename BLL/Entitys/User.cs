using BLL.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entitys
{
    public class User
    {
        public User() { }

        public User(UserDTO userDto)
        {
            Id = userDto.Id;
            username = userDto.username;
            company = userDto.company;
        }

        public int Id { get; set; }
        public string username { get; set; }

        public string company {  get; set; }
    }
}
