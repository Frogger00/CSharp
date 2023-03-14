// Imprime tabla de conversión de peso a dolar
int ini, fin;
float c;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de grados celsius a fahrenheit\n");
    do {
        Console.Write("Temperatura Inicial: "); ini = int.Parse(Console.ReadLine());
        Console.Write("Temperatura Final: "); fin = int.Parse(Console.ReadLine());
    } while(fin < ini);
    c = ini;
    Console.WriteLine(new string('-', 20));
    Console.WriteLine("Celsius\tFahreheit");
    Console.WriteLine(new string('-', 20));
    while( c <= fin ) {
        Console.WriteLine($"{c}\t{(c * 9 / 5) + 32:f4}");
        c++;
    }
    Console.WriteLine(new string('-', 20));
    Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");