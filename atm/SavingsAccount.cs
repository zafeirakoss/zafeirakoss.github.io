using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class SavingsAccount : Account
    {

        private const decimal WithdrawalFee = 1.00m;
        public SavingsAccount(string accountNumber, string ownerName, decimal initialBalance)
            : base(accountNumber, ownerName, initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Το ποσό ανάληψης πρέπει να είναι μεγαλύτερο του 0.");
                return;
            }
            decimal totalAmount = amount + WithdrawalFee;
            if (totalAmount > Balance)
            {
                Console.WriteLine("Ανεπαρκές υπόλοιπο για την ανάληψη συμπεριλαμβανομένου της προμήθειας.");
                return;
            }
            Balance -= totalAmount;
            Console.WriteLine($"Ανάληψη επιτυχής: -{amount} $. Τέλος ανάληψης: -{WithdrawalFee} $. Νέο υπόλοιπο: {Balance} $");
        }
    }
}
