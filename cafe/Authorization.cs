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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            OrderService.CreateOrdersTable();
            StaffService.CreateStaffTable();
            ShiftService.CreateShiftsTable();
            ShiftStaffService.CreateShiftsStaffTable();
        }

        private void button_entrance_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            Staff user = StaffService.Authorization(login, password);

            if (user == null)
            {
                MessageBox.Show("Пользователь не найден!");
                return;
            }

            switch (user.position)
            {
                case "Администратор":
                    Admin adminForm = new Admin();
                    Hide();
                    adminForm.ShowDialog();
                    Close();
                    return;
                case "Официант":
                    Waiter waiterForm = new Waiter();
                    Hide();
                    waiterForm.ShowDialog();
                    Close();
                    return;
                case "Повар":
                    Cook cookForm = new Cook();
                    Hide();
                    cookForm.ShowDialog();
                    Close();
                    return;
            }
        }

        
    }
}
