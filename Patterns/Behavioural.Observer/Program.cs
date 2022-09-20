using Behavioural.Observer;

ISubject subject = new MessageSubject();
IObserver observer = new MessageObserver();
IObserver observer1 = new MessageObserver();
IObserver observer2 = new MessageObserver();
IObserver observer3 = new MessageObserver();

subject.Register(observer);
subject.Register(observer1);
subject.Register(observer2);
subject.Register(observer3);

//Notify all observers of a new message
subject.Notify("This is the observer pattern!");