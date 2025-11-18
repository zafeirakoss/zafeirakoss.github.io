using atm;

CheckingAccount account1 = new CheckingAccount("GR001", "Αγαμέμνων Ζαφειράκος", 1000m);
SavingsAccount account2 = new SavingsAccount("GR002", "Αντώνης Ρομποτής", 5000m);
CheckingAccount account3 = new CheckingAccount("GR003", "Θεοφανία Μαναβούδη", 750m);
CheckingAccount account4 = new CheckingAccount("GR004", "Ευγενία Χριστοφόρου", 3000000m);
SavingsAccount account5 = new SavingsAccount("GR005", "Πέτρος Κασιδιάρης", 450000m);

Card card1 = new Card("1234-5678-9012-3456", "1234", account1);
Card card2 = new Card("9536-9536-9536-9536", "9536", account2);
Card card3 = new Card("1111-2222-3333-4444", "9999", account3);
Card card4 = new Card("1212-2121-1212-2121", "1221", account4);
Card card5 = new Card("6969-6969-6969-6969", "6969", account5);

Atm atm = new Atm();
atm.AddCard(card1);
atm.AddCard(card2);
atm.AddCard(card3);
atm.AddCard(card4);
atm.AddCard(card5);

Console.WriteLine();

atm.Start();

Console.WriteLine("Πατήστε οποιοδήποτε πλήκτρο για έξοδο...");
Console.ReadLine();