object variabel = 42;
//variabel = "42";

if (variabel is string text)
{
    Console.WriteLine($"Sträng med längd {text.Length}");
}
else if (variabel is int heltal)
{
    Console.WriteLine($"Heltal med värdet {heltal}");
}

Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();