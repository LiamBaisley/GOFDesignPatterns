using Structural.Proxy;

IInternet ProxyInternet = new InternetProxy();

Console.WriteLine("Trying to connect to cba.com");
ProxyInternet.ConnectTo("cba.com");
Console.WriteLine("Trying to connect to abc.com");
ProxyInternet.ConnectTo("abc.com");
Console.WriteLine("Trying to connect to StackOverflow.com");
ProxyInternet.ConnectTo("StackOverflow.com");
Console.WriteLine("Trying to connect to Youtube.com");
ProxyInternet.ConnectTo("Youtube.com");
Console.WriteLine("Trying to connect to Github.com");
ProxyInternet.ConnectTo("Github.com");
