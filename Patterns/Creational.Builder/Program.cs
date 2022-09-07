using Creational.Builder;

Animal animal;
AnimalDirector director = new AnimalDirector();

Console.WriteLine("I am creating a cat for you, here are its details!");
Cat cat = new Cat();
animal = director.MakeAnimal(cat);
animal.DescribePet();

Console.WriteLine("I am creating a dog for you, here are its details!");
Dog dog = new Dog();
animal = director.MakeAnimal(dog);
animal.DescribePet();