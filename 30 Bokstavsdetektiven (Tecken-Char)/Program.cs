char bokstav = 'A';
int asciiKod = (int)bokstav; // Explicit typkonvertering från char till int (Casting)
Console.WriteLine($"Bokstaven '{bokstav}' har ASCII-koden: {asciiKod}");

Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();