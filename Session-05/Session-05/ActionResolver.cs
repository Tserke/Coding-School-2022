using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public ActionResolver()
        {

        }

        public ActionResponse Execute(ActionRequest request)
        {

            var response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            // DO ALL THE THINGS!
            if (request.Action == ActionEnum.Convert)
            {
                int[] binaryNum = new int[32];
                int input = Convert.ToInt32(request.Input);
                int i = 0;
                while (input > 0)
                {

                    binaryNum[i] = input % 2;
                    input = input / 2;
                    i++;
                }
                for (int j = i - 1; j >= 0; j--)
                {
                   response.Output += Convert.ToString(binaryNum[j]);
                }
            }
            else if (request.Action == ActionEnum.Uppercase)
            {
                response.Output = request.Input.ToUpper();
            }
            else if (request.Action == ActionEnum.Reverce)
            {
                int inputLenght = request.Input.Length;
                char[] input = request.Input.ToCharArray();

                for (int i = inputLenght - 1; i > -1; i--)
                {
                    response.Output += input[i];
                }

            }

            return response;
        }

    }
}
