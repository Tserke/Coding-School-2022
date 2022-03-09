using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class NumberFinder
    {
        public NumberFinder()
        {

        }

        string number;
        public string NumFinder(string character)
        { 
                number += character;
           
            return number;
        }
    }

}
