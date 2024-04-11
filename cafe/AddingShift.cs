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
    public partial class AddingShift : Form
    {
        public AddingShift()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string date = textBox_date.Text;
            string begin = textBox_begin.Text;
            string end = textBox_end.Text;

            if (string.IsNullOrEmpty(date) ||
                string.IsNullOrEmpty(begin) ||
                string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            Shift shift = new Shift(date, begin, end);
            ShiftService.CreateShift(shift);
            Close();
        }
    }
}
