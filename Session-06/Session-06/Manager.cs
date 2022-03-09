using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Manager
    {

        public Manager()
        {

        }

        string[] numbers;
        string oparation;
        bool isNum;
        int counter=0;
        public void Manage(string input)
        {
            CharacterSeparator characterSeparator = new CharacterSeparator();
            isNum=characterSeparator.IsNum(input);
            while (isNum == true)
            {
                NumberFinder numberFinder = new NumberFinder();
                numbers[counter]=numberFinder.NumFinder(input);
            }
            counter++;
            if (isNum == false)
            {
                oparation = input;
            }
   
        }

    }
}
