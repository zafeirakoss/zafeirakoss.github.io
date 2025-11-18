using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class Atm
    {
        private List<Card> cards;

        public Atm()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void Start()
        {
            Console.WriteLine("===== Καλώς ήρθατε στην Τράπεζα Πειραιώς =====");
            Console.WriteLine("Η συναλλαγή σας είναι ασφαλής και προστατευμένη.");
            Console.Write("\nΕισάγετε τον αριθμό της κάρτας σας: ");
            string cardNumber = Console.ReadLine();

            bool cardFound = false;
            Card foundCard = new Card("", "", new CheckingAccount("", "", 0));

            foreach (Card card in cards)
            {
                if (card.CardNumber == cardNumber)
                {
                    foundCard = card;
                    cardFound = true;
                    break;
                }
            }

            if (!cardFound)
            {
                Console.WriteLine("Η κάρτα δεν βρέθηκε στο σύστημα.");
                return;
            }

            int attempts = 0;
            bool authenticated = false;

            while (attempts < 3)
            {
                Console.Write("Εισάγετε το PIN σας: ");
                string inputPin = Console.ReadLine();

                if (foundCard.ValidatePin(inputPin))
                {
                    authenticated = true;
                    Console.WriteLine($"\nΚαλώς ήρθατε, {foundCard.LinkedAccount.OwnerName}!\n");
                    break;
                }
                else
                {
                    attempts++;
                    if (attempts < 3)
                    {
                        Console.WriteLine($"Λάθος PIN. Υπολοίπουν {3 - attempts} προσπάθειες.\n");
                    }
                    else
                    {
                        Console.WriteLine("Εξαντλήθηκαν οι προσπάθειες. Η κάρτα σας έχει μπλοκαριστεί.");
                        return;
                    }
                }
            }

            if (authenticated)
            {
                ShowMenu(foundCard);
            }
        }

        private void ShowMenu(Card card)
        {
            Console.WriteLine("-----------");
            Console.WriteLine(" ΜΕΝΟΥ ATM ");
            Console.WriteLine("-----------");
            Console.WriteLine("1. Κατάθεση χρημάτων");
            Console.WriteLine("2. Ανάληψη χρημάτων");
            Console.WriteLine("3. Έλεγχος υπολοίπου");
            Console.WriteLine("4. Έξοδος");
            Console.Write("Επιλέξτε μια ενέργεια (1-4): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("\nΕισάγετε το ποσό κατάθεσης: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    card.LinkedAccount.Deposit(depositAmount);
                    break;
                case "2":
                    Console.Write("\nΕισάγετε το ποσό ανάληψης: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    card.LinkedAccount.Withdraw(withdrawAmount);
                    break;
                case "3":
                    card.LinkedAccount.ShowBalance();
                    break;
                case "4":
                    Console.WriteLine("Ευχαριστούμε που χρησιμοποιήσατε το ATM. Αντίο!");
                    break;
            }

        }
    }
}
