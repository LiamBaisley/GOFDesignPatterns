using Behavioural.Command;

RemoteControl control = new RemoteControl();

PlayDVDCommand play = new PlayDVDCommand();
control.Invoke(play);

PauseDVDCommand pause = new PauseDVDCommand();
control.Invoke(pause);

Console.ReadLine();