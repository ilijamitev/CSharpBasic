using AcademyManagment.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyManagment.Service.ValidationServices
{
    public class InputService
    {
        public static string GetValidInput(string[] checkingArr)
        {
            while (true)
            {
                try
                {
                    string inputChoice = Console.ReadLine();
                    if (checkingArr.Contains(inputChoice))
                    {
                        return inputChoice;
                    }
                    else
                    {
                        HelperService.ThrowException("SELECT VALID OPTION !");
                    }
                }
                catch (Exception ex)
                {
                    HelperService.ShowErrorMessage(ex.Message);
                }
            }
        }






    }
}
