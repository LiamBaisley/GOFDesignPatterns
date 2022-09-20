using Behavioural.ChainOfResponsibility;

//This example uses fizzbuzz, the idea is that if a number is divisible by 3 it prints Fizz, if its divisible by 5 it prints buzz,
//if it is divisible by both then it prints FizzBuzz and if it is divisible by none then it prints the number. 

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