using Creational.AbstractFactory;

AnimalFactory animalFactory = null;
Console.WriteLine("Would you like to instantiate a sea or a land animal?");
string input = Console.ReadLine();
animalFactory = AnimalFactory.CreateAnimalfactory(input);
Console.WriteLine($"Instantiated a new {nameof(animalFactory)}");
Console.WriteLine("What animal would you like to create?");
string animal = Console.ReadLine();
IAnimal newAnimal = animalFactory.GetAnimal(animal);
Console.WriteLine($"Animal says: {newAnimal.MakeSound()}");
