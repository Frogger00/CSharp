// Imprime números pares ascendente
int n, c, s;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime números pares ascendente\n");
    Console.WriteLine("Hasta donde ? ");
    n = int.Parse(Console.ReadLine());
    s = 0;
    c = 2;
    while( c <= n ) {
        Console.Write($"{c} ");
        s = s + c;
        c = c + 2;
    }
    Console.WriteLine($"La suma es {s}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp != 'N' );
Console.WriteLine("\nGracias por utilizar este programa !");