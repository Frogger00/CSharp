double dolar, pesos, conv;
dolar = pesos = conv = 0;

Console.WriteLine("Convirtiendo pesos a dolares:\n");
Console.Write("Dame la cantidad de pesos: "); pesos = double.Parse(Console.ReadLine());
Console.Write("Dame el precio del dolar: "); dolar = double.Parse(Console.ReadLine());

conv = pesos / dolar;

Console.WriteLine($"El equivalente en dolares es: {conv}");