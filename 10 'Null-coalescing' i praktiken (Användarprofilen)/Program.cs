byte maxVärde = byte.MaxValue;  // 255
int maxVärde2 = int.MaxValue;  // 2147483647

Console.WriteLine($"Före overflow: {maxVärde}, {maxVärde2}");
maxVärde++;  // Överskrider maxvärdet för byte
maxVärde2++;  // Överskrider maxvärdet för int

Console.WriteLine($"Efter overflow: {maxVärde}, {maxVärde2}");


Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

