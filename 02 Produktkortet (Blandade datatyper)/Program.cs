string produktNamn = "Kaffebryggare";
decimal pris = 150.25m;
int antalILager = 10;
bool finnsILager = antalILager > 0;

Console.WriteLine($"Produkt: {produktNamn}\nPris: {pris} kr\nLager: {antalILager}\nTillgänglig: {finnsILager}");



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

