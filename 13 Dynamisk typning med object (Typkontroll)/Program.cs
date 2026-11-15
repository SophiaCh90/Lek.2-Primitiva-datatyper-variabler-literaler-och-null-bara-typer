float fSum = 0;
decimal dSum = 0;

for (int i = 0; i < 10; i++)
{
    fSum += 0.1f;
    dSum += 0.1m;
}

Console.WriteLine($"Float: {fSum}"); // Precisionstapp
Console.WriteLine($"Decimal: {dSum}"); // Exakt 1.0



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
