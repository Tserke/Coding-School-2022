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
            ActionRequest actionRequest = new ActionRequest();
            Console.WriteLine(" Please tell me what you whant to do? Convert, Uppercase, Reverse?");
            actionRequest.RequestID = Guid.NewGuid();
            actionRequest.Input=Console.ReadLine();
            try
            {
                if (actionRequest.Input == "Convert")
                {
                    actionRequest.Action = ActionEnum.Convert;
                }else if (actionRequest.Input == "Uppercase")
                {
                    actionRequest.Action = ActionEnum.Uppercase;
                }else if (actionRequest.Input == "Reverce")
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
            actionRequest.Action = ActionEnum.Uppercase;
            ActionResolver resolver = new ActionResolver();
            resolver.Execute(actionRequest);
            ActionResponse response = resolver.Execute(actionRequest);
            Console.WriteLine(response.Output);
            Console.ReadLine();
        }
    }
}
