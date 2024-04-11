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
    public partial class AddingOrder : Form
    {
        public AddingOrder()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int table = Convert.ToInt32(textBox_table.Text);
            int number_of_clients = Convert.ToInt32(textBox_clients.Text);
            string structure = textBox_character.Text;
            string status = "Принят";

            DateTime dateTime = DateTime.Now;
            string date = dateTime.Date.ToShortDateString();
            string hours = "";

            if (dateTime.TimeOfDay.Hours < 10)
            {
                hours = "0";
            }

            hours += dateTime.TimeOfDay.Hours.ToString();

            string minutes = "";

            if (dateTime.TimeOfDay.Minutes < 10)
            {
                minutes = "0";
            }

            minutes += dateTime.TimeOfDay.Minutes.ToString();

            string time = $"{hours}:{minutes}";

            if (string.IsNullOrEmpty(structure))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            Order order = new Order(table, number_of_clients, structure, status, date, time);
            OrderService.CreateOrder(order);
            Close();
        }
    }
}
