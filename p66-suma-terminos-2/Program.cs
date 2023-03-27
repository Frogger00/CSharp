//Se desea imprimir la secuencia de términos, el número de renglones que el usuario desee y su suma:
int i, j, n, sum = 0, temp = 0;
char resp;

do {
    Console.Clear();
    Console.Write("Cuantos terminos? "); 
    n = int.Parse(Console.ReadLine());
    for(i = 1; i <= n; i++) {
        if (i == 1){
            Console.Write("1");
            sum += 1;
            temp = 1;
        }
        else {
            temp = temp * 10 + 1;
            Console.Write($" + {temp}");
            sum += temp;
        }
    }
    Console.Write($"\nSuma: {sum}");
    Console.Write("\nDeseas continuar (S/N)?");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso terminado...");