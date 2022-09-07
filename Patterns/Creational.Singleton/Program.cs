using Creational.Singleton;

//Get the instance of the singleton class
Singleton instance = Singleton.GetInstance;
instance.PrintDetails("Hello there!");

//Get the instance of the same singleton as above
Singleton instance2 = Singleton.GetInstance;
instance2.PrintDetails("Hello there from the same instance");

//Trying to instantiate Singleton as below will result in an error due to its access level
//Singleton instance3 = new Singleton();