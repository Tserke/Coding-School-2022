﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public class Customer : BaseEntity
    {
        public List<Transaction> Transactions { get; set; }
    }
}
