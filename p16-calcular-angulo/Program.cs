double ang1, ang2, ang3;
ang1 = ang2 = ang3 = 0;

Console.WriteLine("Calculando el terer angulo de un triangulo:\n");
Console.Write("Dame el angulo 1: "); ang1 = double.Parse(Console.ReadLine());
Console.Write("Dame el angulo 2: "); ang2 = double.Parse(Console.ReadLine());

ang3 = 180 - (ang1 + ang2);

Console.WriteLine($"El tercer angulo es: {ang3}");