﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_COMMERCE.Model
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}