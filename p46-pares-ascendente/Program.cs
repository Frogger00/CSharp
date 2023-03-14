// Imprime los numeros pares de 2 a n, calcula su suma, el proceso se repite
int c, n, s;
char resp;

do {
    Console.Clear();
    Console.WriteLine("Imprime números pares de 2 a n, calcula su suma, el proceso se repite\n");
    Console.WriteLine("Hasta donde deseas los pares? ");
    n = int.Parse(Console.ReadLine());
    s = 0;
    c = 2;
    while( c <= n ) {
        Console.Write($"{c} ");
        s += c;
        c += 2;
    }
    Console.WriteLine($"La suma es {s}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp != 'N' );
Console.WriteLine("\nGracias por utilizar este programa !");