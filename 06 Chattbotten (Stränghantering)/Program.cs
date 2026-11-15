Console.Write("Vad heter du? ");
var namn = Console.ReadLine();
Console.Write("Favorithobby? ");
var hobby = Console.ReadLine();

string stortNamn = namn?.ToUpper() ?? "Okänt namn";

Console.WriteLine($"\n[Bot]: Hej {stortNamn}! Vad kul att du gillar {hobby}!");






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

