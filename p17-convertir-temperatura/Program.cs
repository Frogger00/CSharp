double celsius, fahr;
celsius = fahr = 0;

Console.WriteLine("Convirtiendo grados fahrenheit a celsius:\n");
Console.Write("Dame los grados en fahreheit: "); fahr = double.Parse(Console.ReadLine());

celsius = (fahr - 32) * 5 / 9;

Console.WriteLine($"Grados celsius: {celsius}");