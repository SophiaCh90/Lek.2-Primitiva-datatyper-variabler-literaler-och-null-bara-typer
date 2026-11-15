const int KAFFEPRIS = 15;
Console.Write("Hur många koppar kaffe vill du ha? ");
//int antalKoppar = int.Parse(Console.ReadLine());
int antalKoppar;
int.TryParse(Console.ReadLine(), out antalKoppar);
int totalPris = antalKoppar * KAFFEPRIS;
Console.WriteLine($"Det blir totalt {totalPris} kr. Välkommen åter!");

Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
