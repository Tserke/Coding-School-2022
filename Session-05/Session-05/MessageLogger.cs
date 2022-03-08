using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {
        Message[] Messages { get; set; }
        string[] messages= new string[50];
        int counter = 0;
        public MessageLogger()
        {

        }
       
        public void Write (Guid requestId,Guid resolveId , ActionEnum action, string input)
        {
            messages[counter] = $"RequestID:{requestId} ResolveID{resolveId} Action{action} Input{input}";
            counter++;
        }
        public void Write (string log, Message message)
        {
            messages[counter]=log;
            Messages[counter] = message;
            Console.WriteLine(messages[counter].ToString());
            counter++;
        }
        public Message[] ReadAll()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(messages[counter]);
            }
            return Messages;
        }
        public void Clear()
        {
            Array.Clear(Messages, 0, counter);
            counter = 0;
        }
    }
}
