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
    public partial class ConfirmStaffStatus : Form
    {
        private List<Staff> staff;

        public ConfirmStaffStatus(List<Staff> staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            foreach (Staff staffElement in staff)
            {
                StaffService.UpdateStaff(staffElement);
            }

            Close();
        }
    }
}
