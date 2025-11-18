using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class CheckingAccount : Account
    {
        public CheckingAccount(string accountNumber, string ownerName, decimal initialBalance)
            : base(accountNumber, ownerName, initialBalance) { }

        public override void Withdraw(decimal amount)
        {   
            if (amount <= 0)
            {
                Console.WriteLine("Το ποσό ανάληψης πρέπει να είναι μεγαλύτερο του 0.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Ανεπαρκές υπόλοιπο για την ανάληψη.");
                return;
            }
            
            Balance -= amount;
            Console.WriteLine($"Ανάληψη επιτυχής: -{amount} €. Νέο υπόλοιπο: {Balance} €");
        }
    }
}
