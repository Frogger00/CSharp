// Imprime la conjetura de collatz para un número entero positivo
int n, count = 0, fibo = 0, fiboant = 0 , temp = 0;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime los primeros n numero de la serie de fibonacci\n");
    do {
        Console.Write("Dame un numero? ");
        n = int.Parse(Console.ReadLine());
    } while( n <= 0);
    do {
        temp = fiboant;
        fiboant = fibo;
        fibo = fiboant + temp;
        Console.Write($"{fiboant} ");
        if(fibo == 0)fibo++;
        count++;
    } while(count < n);
    count = fibo = fiboant = temp = 0;
    Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");