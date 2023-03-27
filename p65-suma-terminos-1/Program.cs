//Se desea imprimir la secuencia de términos armónicos el número de renglones que el usuario desee y su suma:
int i, n;
float sum = 0f, temp = 0f;
char resp;

do {
    Console.Clear();
    Console.Write("Cuantos terminos? "); 
    n = int.Parse(Console.ReadLine());
    for(i = 1; i <= n; i++) {
        if (i == 1){
            Console.Write("1 ");
            sum = sum + 1;
        }
        else {
            temp = i;
            Console.Write($"+ 1/{i} ");
            sum += 1 / temp;
        }
    }
    Console.Write($"\nSuma: {sum}");
    Console.Write("\nDeseas continuar (S/N)?");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso terminado...");