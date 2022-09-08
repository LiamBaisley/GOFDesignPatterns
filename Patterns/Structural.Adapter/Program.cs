using Structural.Adapter;

//We can use the third party age calculator to calculate the age of the Human
Console.WriteLine("Hello human, how old are you?");
Human human = new Human();
human.Age = Convert.ToInt16(Console.ReadLine());
double ageInDays = AgeCalculator.CalculateAge(Convert.ToDouble(human.Age));
Console.WriteLine($"Wow, you are {ageInDays} old!");

//We cant use the third party app to calculate the age of the dog because its age is in dog years, 
//So we use the adapter that first converts the age to normal years and then returns the dogs age in days. 
Dog dog = new Dog();
Console.WriteLine("How old is your dog in dog years?");
dog.AgeInDogYears = Convert.ToInt16(Console.ReadLine());
double dogAgeInDays = AgeCalculatorAdapter.GetAge(Convert.ToDouble(dog.AgeInDogYears));
Console.WriteLine($"Wow, your dog is {dogAgeInDays} days old!");
