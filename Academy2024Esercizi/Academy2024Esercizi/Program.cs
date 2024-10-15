//Console.WriteLine("Ipotenusa di un triangolo rettangol\n");
//Console.Write("Inserisci la base: ");
//string baseSideInput = Console.ReadLine();
//double baseSide = double.Parse(baseSideInput);

//Console.Write("Inserisci l'altezza: ");
//string heightSideInput = Console.ReadLine();    
//double heightSide = double.Parse(heightSideInput);

//double i = Math.Sqrt(Math.Pow(baseSide, 2) + Math.Pow(heightSide, 2));

//Console.WriteLine("L'ipotenusa viene: " + i);


Console.WriteLine("Controlla il numero\n");
Console.Write("Enter the first number: ");
bool isnum1Valid = double.TryParse(Console.ReadLine(), out double num1);

Console.Write("Enter the second number: ");
bool isnum2Valid = double.TryParse(Console.ReadLine(), out double num2);

if (num1 > num2)
{
    Console.WriteLine($"\nThe fisrt number is bigger than the second\nValor: {num1} > {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"\nThe second number is bigger than the first\nValor: {num1} < {num2}");
}
else
{
    Console.WriteLine($"\nThe fisrt and the second number are the same\nValor: {num1} = {num2}");
}