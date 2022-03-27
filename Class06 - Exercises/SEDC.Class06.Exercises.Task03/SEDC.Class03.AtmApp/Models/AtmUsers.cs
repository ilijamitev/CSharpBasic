using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.AtmApp.Models
{
    public class AtmUsers
    {
        public string FullName { get; set; }
        public long CardNumber { get; set; }
        public int CardPin { get; set; }

        //private int CashBalance = 0; 
        public int CashBalance = 0;

        public AtmUsers() { }

        public AtmUsers(string fullName, long cardNumber, int cardPin)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            CardPin = cardPin;
        }



    }
}
