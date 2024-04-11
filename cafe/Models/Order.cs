using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Models
{
    public class Order
    {
        public int id_order { get; set; }
        public int table { get; set; }
        public int number_of_clients { get; set; }
        
        public string structure { get; set; }
        public string status { get; set; }
        public string date { get; set; }
        public string time { get; set; }

        public Order(int id_order, int table, int number_of_clients, string structure, string status)
        {
            this.id_order = id_order;
            this.table = table;
            this.number_of_clients = number_of_clients;
            this.structure = structure;
            this.status = status;
        }


        public Order(int table, int number_of_clients, string structure, string status)
        {
            this.table = table;
            this.number_of_clients = number_of_clients;
            this.structure = structure;
            this.status = status;
        }

        public Order(int id_order, int table, int number_of_clients, string structure, string status, string date, string time)
        {
            this.id_order = id_order;
            this.table = table;
            this.number_of_clients = number_of_clients;
            this.structure = structure;
            this.status = status;
            this.date = date;
            this.time = time;
        }

        public Order(int table, int number_of_clients, string structure, string status, string date, string time)
        {
            this.table = table;
            this.number_of_clients = number_of_clients;
            this.structure = structure;
            this.status = status;
            this.date = date;
            this.time = time;
        }
    }
}
