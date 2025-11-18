using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal abstract class Account
    {
        public string AccountNumber { get; private set; }
        public string OwnerName { get; private set; }
        protected decimal Balance;

        public Account(string accountNumber, string ownerName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Το ποσό κατάθεσης πρέπει να είναι μεγαλύτερο του 0.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Κατάθεση επιτυχής: +{amount} $. Νέο υπόλοιπο: {Balance} $");
        }

        public abstract void Withdraw(decimal amount);

        public virtual void ShowBalance()
        {
            Console.WriteLine($"Υπόλοιπο λογαριασμού: {Balance} $");
        }
    }
}
