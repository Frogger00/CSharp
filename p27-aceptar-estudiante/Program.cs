// Acepta a un estudiante en base a su edad y sus calificaciones
Console.Clear();
Console.WriteLine("Acepta a un estudiante en base a su edad y sus calificaciones\n");
Console.Write("Dame tu nombre ? ");

string nombre = Console.ReadLine();
Console.Write("Dame la edad ? ");

int edad = int.Parse(Console.ReadLine());

if( edad < 18 ) Console.WriteLine("No aceptamos menores de edad \n");
else{
    Console.WriteLine("Calificacion 1?");float c1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Calificacion 2?");float c2 = float.Parse(Console.ReadLine());
    if(c1 < 8 || c2 < 8) Console.WriteLine("\nNo aceptamos calificaciones menores a 8\n");
    else
    Console.WriteLine($"\nBIENVENIDO {nombre} tienes {edad} y calificaciones {c1},{c2} ... ACEPTADO\n");
}