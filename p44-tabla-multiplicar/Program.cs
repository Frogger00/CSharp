// Imprime la tabla de multiplicar que el usuario pida, desde 1 hasta n
int c, t, n;

Console.Clear();
Console.WriteLine("Imprimir la tabla deseada de 1 a 10\n");

Console.Write("Que tabla quieres ? ");
t = int.Parse(Console.ReadLine());

Console.Write("Hasta donde ? ");
n = int.Parse(Console.ReadLine());

c = 1;
while( c <= n ) {
    Console.WriteLine($"{t} x {c} = {t * c}");
    c++;
}
Console.WriteLine("\nProceso terminado ...");