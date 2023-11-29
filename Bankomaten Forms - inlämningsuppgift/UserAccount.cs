using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomaten_Forms___inlämningsuppgift
{
    public class UserAccount
    {
        public int AccountNumber { get; set; }
        public int Pin { get; set; }
        public decimal Balance { get; set; }

        public UserAccount(int accountnumber, int pin, decimal balance) 
        {
            AccountNumber = accountnumber;
            Pin = pin;
            Balance = balance;
        }


        



    }
}
