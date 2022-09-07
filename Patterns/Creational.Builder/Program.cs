using Creational.Builder;

Animal animal;
AnimalDirector director = new AnimalDirector();

Cat cat = new Cat();
animal = director.MakeAnimal(cat);
animal.DescribePet();

Dog dog = new Dog();
animal = director.MakeAnimal(dog);
animal.DescribePet();