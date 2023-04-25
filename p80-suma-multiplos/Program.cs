//p80-suma-multiplos

int op;

int sumamultiplos(int ini, int fin, int mul){
    int suma = 0;
    for(int i = ini; i <= fin; i++)
        if((i % mul) == 0) suma += i;
    return suma;
}

int menu(){
    Console.WriteLine("Suma de multiplos de 3... [1]");
    Console.WriteLine("Suma de multiplos de 4... [2]");
    Console.WriteLine("Salir...                  [3]");
    Console.Write("Elige una opcion...");
    op = int.Parse(Console.ReadLine());
    return op;
}

do{
    Console.Clear();
    op = menu();
    int resul = 0;
    Console.WriteLine("Ingresa el limite inferior: ");
    int lim_inf = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa el limite superior: ");
    int lim_sup = int.Parse(Console.ReadLine());
    switch(op){
        case 1 : resul = sumamultiplos(lim_inf,lim_sup,3);break;
        case 2 : resul = sumamultiplos(lim_inf,lim_sup,4);break;
        default : break;
    }
    Console.WriteLine($"Suma: {resul}");
    Console.WriteLine("\nPresione cualquier tecla para continuar...0");
    Console.ReadLine();
}while(op != 3);