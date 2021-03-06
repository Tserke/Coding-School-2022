using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {
        public Guid ID { get; set; }
        public DateTime DateTime { get; set; }
        public string message { get; set; }
        public Message()
        {
               
        }

        public string DebugLog(string ex)
        {
            ID = Guid.NewGuid();
            DateTime = DateTime.Now;
            message = ex;

            return $"{ID} {DateTime} {ex}";
        }
    }
}
