float cal1, cal2, cal3, suma, prom, mayor, menor;

cal1 = cal2 = cal3 = 0;

Console.WriteLine("Calculando el promedio de tres calificaciones, calculando tambien la mayor y la menor:\n");
Console.Write("Dame calificacion 1: "); cal1 = float.Parse(Console.ReadLine());
Console.Write("Dame calificacion 2: "); cal2 = float.Parse(Console.ReadLine());
Console.Write("Dame calificacion 3: "); cal3 = float.Parse(Console.ReadLine());

suma = cal1 + cal2 + cal3;
prom = suma / 3;
mayor = Math.Max(Math.Max(cal1,cal2), cal3);
menor = Math.Min(Math.Min(cal1,cal2), cal3);

Console.WriteLine($"Las calificaciones introducidas son: {cal1}, {cal2}, {cal3} \n");
Console.WriteLine($"La suma : {suma}");
Console.WriteLine($"El promedio : {prom}");
Console.WriteLine($"La mayor : {mayor}");
Console.WriteLine($"La menor : {menor}");