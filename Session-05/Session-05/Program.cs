using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            ActionRequest actionRequest = new ActionRequest();
            Console.WriteLine(" Please tell me what you whant to do? Convert, Uppercase, Reverse?");
            actionRequest.RequestID = Guid.NewGuid();
            input=Console.ReadLine();
            try
            {
                if (input == "Convert")
                {
                    actionRequest.Action = ActionEnum.Convert;
                }else if (input == "Uppercase")
                {
                    actionRequest.Action = ActionEnum.Uppercase;
                }else if (input == "Reverce")
                {
                    actionRequest.Action = ActionEnum.Reverce;
                }
            }
            catch (Exception ex)
            {
                Message message=new Message();
                message.ID=Guid.NewGuid();
                message.DateTime=DateTime.Now;
                message.message= ex.ToString();
                //throw;
            }
            Console.WriteLine("Please the Value you want to compute");

            ActionResolver resolver = new ActionResolver();
            resolver.Execute(actionRequest);
            ActionResponse response = resolver.Execute(actionRequest);
            Console.WriteLine(response.Output);
            Console.ReadLine();
        }
    }
}
