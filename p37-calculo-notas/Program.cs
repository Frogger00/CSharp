double cal1, cal2, cal3, cal4, cal5;
double promedio;

Console.Clear();
Console.WriteLine("Ingrese las cinco calificaciones:");

cal1 = double.Parse(Console.ReadLine());
cal2 = double.Parse(Console.ReadLine());
cal3 = double.Parse(Console.ReadLine());
cal4 = double.Parse(Console.ReadLine());
cal5 = double.Parse(Console.ReadLine());

promedio = (cal1 + cal2 + cal3 + cal4 + cal5) / 5;

if (promedio > 0 && promedio <= 6)
{
    Console.WriteLine("Quedas reprobado");
}
else if (promedio > 6 && promedio <= 7)
{
    Console.WriteLine("Pasas de panzazo");
}
else if (promedio > 7 && promedio <= 8)
{
    Console.WriteLine("Muy bien, pues mejorar");
}
else if (promedio > 8 && promedio <= 9)
{
    Console.WriteLine("Excelente sigue así");
}
else if (promedio > 9 && promedio <= 10)
{
    Console.WriteLine("Perfecto tu esfuerzo valió la pena");
}
else
{
    Console.WriteLine("Las calificaciones ingresadas no son validas");
}