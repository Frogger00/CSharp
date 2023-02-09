int ba, al;
float area;

Console.WriteLine("Calculando el area de un triangulo: \n");
Console.Write("Dame la base: ");
ba = int.Parse(Console.ReadLine());
Console.Write("Dame la altura: ");
al = int.Parse(Console.ReadLine());

area = (ba * al) / 2;
Console.WriteLine($"El triangulo de base {ba} y altura {al}, tiene un area de {area}");