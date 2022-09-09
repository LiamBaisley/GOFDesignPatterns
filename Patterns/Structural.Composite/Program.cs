using Structural.Composite;


//TODO: Come back to this one, I don't think I understand it yet.
Dog dog = new Dog();
Console.WriteLine("Please enter a name for your doggo:");
dog.Name = Console.ReadLine();

Console.WriteLine("How many puppies do you want?");
int puppyCount = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < puppyCount; i++)
{
    Console.WriteLine("Please enter a name for your puppy");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter a color for your puppy");
    string color = Console.ReadLine();

    dog.AddPuppy(name, color);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Thanks, here is your dog family:");
dog.IntroduceSelfAndPuppies();
