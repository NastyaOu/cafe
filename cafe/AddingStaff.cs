using cafe.Models;
using cafe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class AddingStaff : Form
    {
        public AddingStaff()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string last_name = textBox_lastname.Text;
            string name = textBox_name.Text;
            string patronymic = textBox_patronymic.Text;
            string position = comboBox_position.Text;
            string login = textBox_login.Text;
            string password = textBox_password.Text;
            string status = comboBox_status.Text;

            if (string.IsNullOrEmpty(last_name) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(patronymic) ||
                string.IsNullOrEmpty(position) ||
                string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            Staff staff = new Staff(last_name, name, patronymic, position, login, password, status);
            StaffService.CreateStaff(staff);
            Close();
        }
    }
}
