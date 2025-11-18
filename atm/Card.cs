using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class Card
    {
        public string CardNumber { get; private set; }
        public string PinCode { get; set; }
        public Account LinkedAccount { get; private set; }

        public Card(string cardNumber, string pinCode, Account linkedAccount)
        {
            CardNumber = cardNumber;
            PinCode = pinCode;
            LinkedAccount = linkedAccount;
        }

        public bool ValidatePin(string inputPin)
        {
            return PinCode == inputPin;
        }
    }
}
