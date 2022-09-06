using StrategyPattern;

//Set the strategy to dog
AnimalContext context = new AnimalContext(new Dog());
Console.WriteLine(context.DoSound());

//Update the strategy to cat
context.SetStrategy(new Cat());
Console.WriteLine(context.DoSound());