string? visningsnamn = null;
string användarnamn = "KalleKoda";
string namnAttVisa = visningsnamn ?? användarnamn ?? "Gäst";
Console.WriteLine($"Välkommen, {namnAttVisa}!");


Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();