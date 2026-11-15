string förnamn = "John";
var efternamn = "Andersson";
//string testnamn = null;
int ålder = 30;
var hemort = "Göteborg";
hemort = "Malmö";

Console.WriteLine("Hej! Jag heter {0} {1}, är {2} år gammal och bor i {3}",
    förnamn, efternamn, ålder, hemort);

Console.WriteLine($"Hej igen! Jag heter {förnamn} {efternamn}, är {ålder} år gammal och bor i {hemort}");


Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();