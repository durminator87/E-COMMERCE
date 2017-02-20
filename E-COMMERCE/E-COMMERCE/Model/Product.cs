using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_COMMERCE.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Details { get; set; }
        public Category Category { get; set; }
        public City City { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
