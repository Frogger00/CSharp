double dias, horas, min, seg;
dias = horas = min = seg = 0;

Console.WriteLine("Calculando el tiempo:\n");
Console.Write("Dame las horas: "); horas = double.Parse(Console.ReadLine());

dias = horas / 24;
min = horas * 60;
seg = horas * 60 * 60;

Console.WriteLine($"El tiempo es:\n{dias} dias\n{horas} horas\n{min} minutos\n{seg} segundos\n");