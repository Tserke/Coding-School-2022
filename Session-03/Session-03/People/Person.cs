﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        internal Guid PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private string _name;

        public string GetName()
        {
            return _name;
        }
        
        public void SetName(string name)
        {
            _name = name;
        }
    }
}
