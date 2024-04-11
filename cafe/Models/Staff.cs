using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Models
{
    public class Staff
    {
        public int id_staff { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string position { get; set; }
       
        public string login { get; set; }
        public string password { get; set; }
        public string status { get; set; }

        public Staff(int id_staff, string last_name, string name, string patronymic, string position, string login, string password, string status)
        {
            this.id_staff = id_staff;
            this.last_name = last_name;
            this.name = name;
            this.patronymic = patronymic;
            this.position = position;
            this.login = login;
            this.password = password;
            this.status = status;

        }

        public Staff(string last_name, string name, string patronymic, string position, string login, string password, string status)
        {
            this.last_name = last_name;
            this.name = name;
            this.patronymic = patronymic;
            this.position = position;
            this.login = login;
            this.password = password;
            this.status = status;

        }
    }
}
