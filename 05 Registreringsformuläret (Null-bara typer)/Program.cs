string förnamn = "Johan";
string? mellannamn = null;
int? partnernsÅlder = null;

Console.WriteLine($"Namn: {förnamn} {mellannamn}");
//if (partnernsÅlder.HasValue)
if (!(partnernsÅlder == null))
{
    Console.WriteLine($"Partnerns ålder: {partnernsÅlder.Value}");
}
else
{
    Console.WriteLine("Partnerns ålder: Ej angivet");
}





Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();