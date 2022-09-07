using Creational.Factory;

string consoleInput = null;
Console.WriteLine("enter Cat or Dog");
consoleInput = Console.ReadLine();
IAnimal animal = AnimalFactory.GetAnimal(consoleInput);
if(animal != null)
{
    Console.WriteLine(animal.MakeSound());
}
else
{
    Console.WriteLine($"{consoleInput} is not an animal we know. Please select Cat or Dog");
}
