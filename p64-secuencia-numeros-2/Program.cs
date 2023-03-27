//Se desea imprimir la secuencia de números mostrados el número de renglones que el usuario desee:
int i, j, n;
char resp;

do {
    Console.Clear();
    Console.Write("Cuantos renglones? "); n = int.Parse(Console.ReadLine());
    for(i = 1; i <= n; i++) {
        for(j = 1; j <= i; j++) {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
    Console.Write("\nDeseas continuar (S/N)?");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso terminado...");