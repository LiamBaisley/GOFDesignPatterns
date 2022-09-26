using Behavioural.State;

ATMMachine atmMachine = new ATMMachine();
Console.WriteLine("ATM Machine Current state : "
                  + atmMachine.ATMState.GetType().Name);
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.EjectCard();
atmMachine.InsertCard();
Console.WriteLine();
// Debit Card has been inserted so internal state of ATM Machine
// has been changed to DebitCardInsertedState
Console.WriteLine("ATM Machine Current state : "
                  + atmMachine.ATMState.GetType().Name);
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.InsertCard();
atmMachine.EjectCard();
Console.WriteLine("");
// Debit Card has been ejected so internal state of ATM Machine
// has been changed to DebitCardNotInsertedState
Console.WriteLine("ATM Machine Current state : "
                  + atmMachine.ATMState.GetType().Name);
Console.Read();