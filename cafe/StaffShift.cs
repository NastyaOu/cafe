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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace cafe
{
    public partial class StaffShift : Form
    {
        private int id_shift { get; set; }
        private List<Staff> staff;

        public StaffShift(int id_shift)
        {
            InitializeComponent();
            this.id_shift = id_shift;
            this.staff = StaffService.GetStaff();
        }

        private void StaffShift_Load(object sender, EventArgs e)
        {
            FillStaffTable();
        }

        private void FillStaffTable()
        {
            List<Staff> staffOnShift = ShiftService.GetShiftStaff(id_shift);
          
            int rowIndex = 0;

            foreach (Staff staffElement in staff)
            {
                dataGridView_staff.Rows.Add();
                dataGridView_staff.Rows[rowIndex].Cells[0].Value = staffElement.last_name;
                dataGridView_staff.Rows[rowIndex].Cells[1].Value = staffElement.name;
                dataGridView_staff.Rows[rowIndex].Cells[2].Value = staffElement.patronymic;
                dataGridView_staff.Rows[rowIndex].Cells[3].Value = staffElement.position;

                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridView_staff.Rows[rowIndex].Cells[4];

                if (staffOnShift.FindIndex((staffOnShiftElement) => staffOnShiftElement.id_staff == staffElement.id_staff) != -1)
                {
                    
                    check.Value = check.TrueValue;
                } else
                {
                    check.Value = check.FalseValue;
                }

                rowIndex++;
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            ShiftStaffService.DeleteShiftStaff(id_shift);

            List<Staff> staffToAssign = new List<Staff>();

            for (int i = 0; i < dataGridView_staff.Rows.Count - 1; i++)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridView_staff.Rows[i].Cells[4];

                if (check.Value == check.TrueValue)
                {
                    staffToAssign.Add(staff[i]);
                }
            }

            foreach (Staff staff in staffToAssign)
            {
                ShiftStaffService.CreateStaffShift(staff.id_staff, id_shift);
            }

            Close();
        }
    }
}
