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
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            FillOrdersTable();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            List<Order> orders = new List<Order>();

            for (int i = 0; i < dataGridView_orders.Rows.Count - 1; i++)
            {
                int id_order = Convert.ToInt32(dataGridView_orders.Rows[i].Cells[0].Value.ToString());
                int table = Convert.ToInt32(dataGridView_orders.Rows[i].Cells[1].Value.ToString());
                int number_of_clients = Convert.ToInt32(dataGridView_orders.Rows[i].Cells[2].Value.ToString());
                string structure = dataGridView_orders.Rows[i].Cells[3].Value.ToString();
                string status = dataGridView_orders.Rows[i].Cells[4].Value.ToString();
                string date = dataGridView_orders.Rows[i].Cells[5].Value.ToString();
                string time = dataGridView_orders.Rows[i].Cells[6].Value.ToString();

                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Не все поля заполнены!");
                    return;
                }

                orders.Add(new Order(id_order, table, number_of_clients, structure, status, date, time));
            }

            ConfirmOrderStatus confirmOrderStatus = new ConfirmOrderStatus(orders);
            confirmOrderStatus.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddingOrder addingOrderForm = new AddingOrder();
            addingOrderForm.ShowDialog();
            dataGridView_orders.Rows.Clear();
            FillOrdersTable();
        }

        private void FillOrdersTable()
        {
            List<Order> orders = OrderService.GetActiveOrders();

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
    }
}
