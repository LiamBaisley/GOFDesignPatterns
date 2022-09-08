using Behavioural.Mediator;

Human human = new Human();
Console.WriteLine("Hello human, do you want to give a command to the cat, the dog or both?");
string animal = Console.ReadLine();
Console.WriteLine($"Great you want {animal} to do something. What do you want {animal} to do?");
string command = Console.ReadLine();

human.IssueCommand(command, animal);
