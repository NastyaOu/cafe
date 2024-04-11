using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Models
{
    internal class Shift
    {
        public int id_shift { get; set; }
        public string date { get; set; }
        public string begin { get; set; }
        public string end { get; set; }
        public List<Staff> staff { get; set; }

        public Shift(int id_shift, string date, string begin, string end, List<Staff> staff)
        {
            this.id_shift = id_shift;
            this.date = date;
            this.begin = begin;
            this.end = end;
            this.staff = staff;
        }

        public Shift(string date, string begin, string end)
        {
            this.date = date;
            this.begin = begin;
            this.end = end;
        }
    }
}
