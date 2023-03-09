// Cuenta números: postivos, negativos, ceros, hasta introducir 999
int n, c, s, cp, cn, cc;
c = s = cp = cn = cc = 0;

Console.Clear();
Console.WriteLine("Cuenta numeros: postivos, negativos, ceros, hasta introducir 999");

do {
    Console.Write($"Dame un numero ? ");
    n = int.Parse(Console.ReadLine());
    if( n != 999) {
        c++;
        s = s + n;
        if(n > 0) cp++;
        else if(n < 0) cn++;
        else cc++;
    }
} while(n != 999);

Console.WriteLine("\nCaptura terminada\n");
Console.WriteLine("\nResumen:");
Console.WriteLine($"Introdujiste {c} numeros");
Console.WriteLine($"La suma de los numeros es {s}");
Console.WriteLine($"Los positivos fueron {cp}");
Console.WriteLine($"Los negativos fueron {cn}");
Console.WriteLine($"Los ceros fueron {cc}");
Console.WriteLine("\nProceso terminado ...");