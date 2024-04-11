using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cafe.Models;
using cafe.Services;

namespace cafe
{
    public partial class ConfirmOrderStatus : Form
    {
        private List<Order> orders;

        public ConfirmOrderStatus(List<Order> orders)
        {
            this.orders = orders;
            InitializeComponent();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            foreach (Order order in orders) 
            {
                OrderService.UpdateOrder(order);
            }
            
            Close();
        }
    }
}
