string nombre;
int horas;
float paga,tasa, impuesto, pagabruta, paganeta;

Console.WriteLine("Calculando la paga de un trabajador: \n");

Console.Write("Nombre? \n");
nombre = Console.ReadLine();
Console.Write("Horas? \n");
horas = int.Parse(Console.ReadLine());
Console.Write("Paga? \n");
paga = float.Parse(Console.ReadLine());

tasa = 0.10f;
pagabruta = horas * paga;
impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;

Console.WriteLine("Resumen de pagos:\n");
Console.WriteLine($"El trabajador {nombre} trabajo {horas} horas con una paga de {paga}");
Console.WriteLine($"Paga bruta: {pagabruta}");
Console.WriteLine($"Impuesto: {impuesto}");
Console.WriteLine($"Paga neta: {paganeta}");