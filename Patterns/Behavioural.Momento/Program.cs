using Behavioural.Momento;

SalesProspect s = new SalesProspect();
s.Name = "Noel van Halen";
s.Phone = "(412) 256-0990";
s.Budget = 25000.0;
Console.WriteLine("Current state -------");
Console.WriteLine(s.Name);
Console.WriteLine(s.Phone);
Console.WriteLine(s.Budget);
Console.WriteLine();
// Store internal state
ProspectMemory m = new ProspectMemory();
m.momento = s.SaveMomento();
// Continue changing originator
s.Name = "Leo Welch";
s.Phone = "(310) 209-7111";
s.Budget = 1000000.0;
Console.WriteLine("Current state -------");
Console.WriteLine(s.Name);
Console.WriteLine(s.Phone);
Console.WriteLine(s.Budget);
Console.WriteLine();
// Restore saved state
s.RestoreMoment(m.momento);
Console.WriteLine("Current state -------");
Console.WriteLine(s.Name);
Console.WriteLine(s.Phone);
Console.WriteLine(s.Budget);
Console.WriteLine();
// Wait for user
Console.ReadKey();