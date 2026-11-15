bool harKörkort = true;
bool harBil = false;
bool ärNykter = true;

bool fårKöraBil = harKörkort && harBil && ärNykter;

harKörkort = false; // Ändrar värdet på harKörkort till false

Console.WriteLine($"Får köra bil: {fårKöraBil}");



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();