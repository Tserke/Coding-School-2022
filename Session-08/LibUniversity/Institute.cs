﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUniversity
{
    [Serializable]
    public class Institute
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public Institute() { }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
    }
}
