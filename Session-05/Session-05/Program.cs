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
            string actionInput, requestInput;
            MessageLogger logger = new MessageLogger();
            Message message = new Message();
            ActionRequest actionRequest = new ActionRequest();
            Console.WriteLine(" Please tell me what you whant to do? Convert, Uppercase, Reverse?");
            actionRequest.RequestID = Guid.NewGuid();
            try
            {
                actionInput = Console.ReadLine();
                switch (actionInput)
                {
                    case "Convert":
                        actionRequest.Action = ActionEnum.Convert;
                        break;
                    case "Uppercase":
                        actionRequest.Action = ActionEnum.Uppercase;
                        break;
                    case "Reverce":
                        actionRequest.Action = ActionEnum.Reverce;
                        break;
                }
            }
            catch (Exception ex)
            {
                logger.Write(message.DebugLog(ex.ToString()),message);
                //throw;
            }
            Console.WriteLine("Please the Value you want to compute");
            requestInput= Console.ReadLine();
            Validation validation = new Validation();
            try
            {
                if (validation.IsNumber(requestInput) == true && actionRequest.Action==ActionEnum.Convert)
                {
                    actionRequest.Input = requestInput; 
                }
            }
            catch (Exception ex)
            {
                logger.Write(message.DebugLog(ex.ToString()), message);
            }

            try
            {
                if (validation.IsNumber(requestInput) == false && (actionRequest.Action==ActionEnum.Reverce||actionRequest.Action==ActionEnum.Uppercase))
                {
                    actionRequest.Input = requestInput;
                }
            }
            catch (Exception ex)
            {
                logger.Write(message.DebugLog(ex.ToString()), message);
            }

            ActionResolver resolver = new ActionResolver();
            resolver.Execute(actionRequest);
            ActionResponse response = resolver.Execute(actionRequest);
            Console.WriteLine(response.Output);
            Console.ReadLine();
        }
    }
}
