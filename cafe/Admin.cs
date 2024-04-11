using cafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cafe.Services;

namespace cafe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            FillOrdersTable();
            FillStaffTable();
            FillShiftsTable();
        }

        private void FillOrdersTable()
        {
            List<Order> orders = OrderService.GetOrders();
            int rowIndex = 0;

            foreach (Order order in orders)
            {
                dataGridView_orders.Rows.Add();
                dataGridView_orders.Rows[rowIndex].Cells[0].Value = order.id_order;
                dataGridView_orders.Rows[rowIndex].Cells[5].Value = order.date;
                dataGridView_orders.Rows[rowIndex].Cells[6].Value = order.time;
                dataGridView_orders.Rows[rowIndex].Cells[1].Value = order.table;
                dataGridView_orders.Rows[rowIndex].Cells[2].Value = order.number_of_clients;
                dataGridView_orders.Rows[rowIndex].Cells[3].Value = order.structure;
                dataGridView_orders.Rows[rowIndex].Cells[4].Value = order.status;

                rowIndex++;
            }
        }

        private void FillStaffTable()
        {
            List<Staff> staff = StaffService.GetStaff();
            int rowIndex = 0;

            foreach (Staff staffElement in staff)
            {
                dataGridView_staff.Rows.Add();
                dataGridView_staff.Rows[rowIndex].Cells[0].Value = staffElement.id_staff;
                dataGridView_staff.Rows[rowIndex].Cells[1].Value = staffElement.last_name;
                dataGridView_staff.Rows[rowIndex].Cells[2].Value = staffElement.name;
                dataGridView_staff.Rows[rowIndex].Cells[3].Value = staffElement.patronymic;
                dataGridView_staff.Rows[rowIndex].Cells[4].Value = staffElement.position;
                dataGridView_staff.Rows[rowIndex].Cells[5].Value = staffElement.login;
                dataGridView_staff.Rows[rowIndex].Cells[6].Value = staffElement.password;
                dataGridView_staff.Rows[rowIndex].Cells[7].Value = staffElement.status;
                rowIndex++;
            }
        }

        private void FillShiftsTable()
        {
            List<Shift> shifts = ShiftService.GetShifts();
            int rowIndex = 0;

            foreach (Shift shift in shifts)
            {
                dataGridView_shifts.Rows.Add();
                dataGridView_shifts.Rows[rowIndex].Cells[0].Value = shift.id_shift;
                dataGridView_shifts.Rows[rowIndex].Cells[1].Value = shift.date;
                dataGridView_shifts.Rows[rowIndex].Cells[2].Value = shift.begin;
                dataGridView_shifts.Rows[rowIndex].Cells[3].Value = shift.end;

                string staffString = "";

                foreach (Staff staff in shift.staff)
                {
                    staffString += $"{staff.last_name} {staff.name} {staff.patronymic} \n";
                }

                dataGridView_shifts.Rows[rowIndex].Cells[4].Value = staffString;
                rowIndex++;
            }
        }

        private void button_staff_Click(object sender, EventArgs e)
        {
            AddingStaff addingStaffForm = new AddingStaff();
            addingStaffForm.ShowDialog();
            dataGridView_staff.Rows.Clear();
            FillStaffTable();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            List<Staff> staff = new List<Staff>();

            for (int i = 0; i < dataGridView_staff.Rows.Count - 1; i++)
            {
                int id_staff = Convert.ToInt32(dataGridView_staff.Rows[i].Cells[0].Value.ToString());
                string last_name = dataGridView_staff.Rows[i].Cells[1].Value.ToString();
                string name = dataGridView_staff.Rows[i].Cells[2].Value.ToString();
                string patronymic = dataGridView_staff.Rows[i].Cells[3].Value.ToString();
                string position = dataGridView_staff.Rows[i].Cells[4].Value.ToString();
                string login = dataGridView_staff.Rows[i].Cells[5].Value.ToString();
                string password = dataGridView_staff.Rows[i].Cells[6].Value.ToString();
                string status = dataGridView_staff.Rows[i].Cells[7].Value.ToString();

                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Не все поля заполнены!");
                    return;
                }

                staff.Add(new Staff(id_staff, last_name, name, patronymic, position, login, password, status));
            }

            ConfirmStaffStatus confirmStaffStatus = new ConfirmStaffStatus(staff);
            confirmStaffStatus.ShowDialog();
        }

        private void button_shifts_Click(object sender, EventArgs e)
        {
            AddingShift addingShiftForm = new AddingShift();
            addingShiftForm.ShowDialog();
            dataGridView_shifts.Rows.Clear();
            FillShiftsTable();
        }

        private void button_assign_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_shifts.SelectedCells[0].RowIndex;
            int id_shift = Convert.ToInt32(dataGridView_shifts.Rows[rowIndex].Cells[0].Value.ToString());

            StaffShift staffShiftForm = new StaffShift(id_shift);
            staffShiftForm.ShowDialog();
            dataGridView_shifts.Rows.Clear();
            FillShiftsTable();
        }
    }
}
