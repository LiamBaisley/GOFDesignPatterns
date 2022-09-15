using Structural.Builder;

SonyRemote sonyRemoteControl = new SonyRemote(new SonyTV());
sonyRemoteControl.SwitchOn();
sonyRemoteControl.SetChannel(101);
sonyRemoteControl.SwitchOff();

Console.WriteLine();
SamsungRemote samsungRemoteControl = new SamsungRemote(new SamsungTV());
samsungRemoteControl.SwitchOn();
samsungRemoteControl.SetChannel(202);
samsungRemoteControl.SwitchOff();

Console.ReadKey();