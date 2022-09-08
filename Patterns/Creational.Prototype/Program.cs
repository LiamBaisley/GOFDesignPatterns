using Creational.Prototype;

Cat Lion = new Cat();
Lion.Kind = "Lion";
Lion.Size = "Large";

Console.WriteLine($"A cat was created of type {Lion.Kind} and its size is {Lion.Size}");
Console.WriteLine("Now we can clone the lion to create a leopard!");

//New instance of the cat class with all the Lion attributes
Cat Leopard = Lion.GetClone();
Leopard.Kind = "Leopard";

Console.WriteLine($"a cat was created of type {Leopard.Kind} and its size is {Leopard.Size}");
Console.WriteLine("Now we can create a House cat from the lion or the leopard object!");

Cat HouseCat = Lion.GetClone();
HouseCat.Kind = "House cat";
HouseCat.Size = "Small";

Console.WriteLine($"a cat was created of type {HouseCat.Kind} and its size is {HouseCat.Size}");