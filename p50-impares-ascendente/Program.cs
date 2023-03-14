// Imprime números impares ascendente
int n, c, s, count = 0;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime números impares ascendente\n");
    Console.Write("Hasta donde? ");
    n = int.Parse(Console.ReadLine());
    s = 0;
    c = 1;
    while( c <= n ) {
        Console.Write($"{c} ");
        s = s + c;
        c = c + 2;
        count++;
    }
    Console.WriteLine($"\nLa suma es {s}");
    Console.WriteLine($"El promedio es {s / count}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp != 'N' );
Console.WriteLine("\nGracias por utilizar este programa !");