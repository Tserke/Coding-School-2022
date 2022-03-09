using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class CharacterSeparator
    {
        public CharacterSeparator()
        {

        }
        public bool isNum=false;
        int res;
        public bool IsNum(string character)
        {
            isNum = int.TryParse(character, out res);
            return isNum;
        }
    }
}
