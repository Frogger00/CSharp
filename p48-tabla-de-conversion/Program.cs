// Imprime tabla de conversión de peso a dolar
int ini, fin, c;
float tc = 18.62f, tce = 19.95f;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de peso a dolar\n");
    do {
        Console.Write("Inicio : "); ini = int.Parse(Console.ReadLine());
        Console.Write("Fin : "); fin = int.Parse(Console.ReadLine());
    } while(fin < ini);
    c = ini;
    Console.WriteLine(new string('-', 25));
    Console.WriteLine("Peso\tDolar\tEuro");
    Console.WriteLine(new string('-', 25));
    while( c <= fin ) {
        Console.WriteLine($"{c}\t{c / tc:f2}\t{c / tce:f2}");
        c++;
    }
    Console.WriteLine(new string('-', 25));
    Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");