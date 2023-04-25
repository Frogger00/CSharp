int[] cals = new int[100], mayor = new int[100];
int num, suma = 0, tamj = 0;
float prom = 0.0f;
char resp;
do {
    suma = 0;
    Console.Clear();
    Console.Write("Cuantos elementos deseas capturar? ");
    num = int.Parse(Console.ReadLine());
    for(int i = 0; i < num; i++){
        Console.Write($"Elemento {i+1}: ");
        cals[i] = int.Parse(Console.ReadLine());
        suma += cals[i];
    }
    Console.WriteLine("\nLos elementos del arreglo son:");
    for(int i = 0; i < num; i++){
        Console.Write($"{cals[i]} ");
    }
    prom = (float)suma / (float)num;
    Console.WriteLine($"\n\nEl promedio de las calificaciones es: \n{prom}");
    for(int i = 0, j = 0; i < num; i++){
        if(cals[i] > prom){
            mayor[j] = cals[i];
            j++;
        }
        tamj = j;
    }    
    Console.WriteLine("\nLas calificaciones mayores al promedio son: ");
    for(int i = 0; i < tamj; i++){
        Console.Write($"{mayor[i]} ");
        mayor[i] = 100 - mayor[i];
    }
    Console.WriteLine("\n\nEl complemento a 100 es:");
    for(int i = 0; i < num; i++){
        Console.Write($"{100 - cals[i]} ");
    }

    Console.Write("\n\nDeseas continuar (S/N)? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado...");