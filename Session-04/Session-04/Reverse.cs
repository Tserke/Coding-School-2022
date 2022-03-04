
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Reverse
    {
        public Reverse()
        {

        }


        public string reversedName;
        public string ReverseStringFor(string s)
        {

            int nameLenght = s.Length;
            char[] name = s.ToCharArray();

            for (int i = nameLenght-1; i>-1; i--)
			{
                reversedName += name[i];
			}
            return reversedName;
        }
    }


}
