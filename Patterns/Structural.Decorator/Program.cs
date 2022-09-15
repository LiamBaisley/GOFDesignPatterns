using Structural.Decorator;

//Here is our normal dog and we can make it bark
IDog dog = new Dog();
Console.WriteLine(dog.Bark());

//Use the loud bark decorator to make it bark louder. 
IDog loudDog = new LoudBarkDecorator(dog);
Console.WriteLine(loudDog.Bark());

//Use the quiet bark decorator to bark more quietly.
IDog quietDog = new QuietDogDecorator(dog);
Console.WriteLine(quietDog.Bark());
Console.ReadLine();