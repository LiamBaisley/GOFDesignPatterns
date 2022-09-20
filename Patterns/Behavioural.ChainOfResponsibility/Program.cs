using Behavioural.ChainOfResponsibility;

Handler fizzBuzzHandler = new FizzBuzzHandler();
Handler fizzHandler = new FizzHandler();
Handler buzzHandler = new BuzzHandler();
Handler defaultHandler = new DefaultHandler();
fizzBuzzHandler.SetSuccessor(fizzHandler);
fizzHandler.SetSuccessor(buzzHandler);
buzzHandler.SetSuccessor(defaultHandler);

for (int i = 0; i < 100; i++)
{
    fizzBuzzHandler.HandleNumbers(i);
}

Console.ReadLine();