int[] cals = new int[100], mayor = new int[100];
int num, suma = 0, tamj = 0, calif, veces = 0, val = 1;
float prom = 0.0f;
char resp;
do {
    suma = 0; veces = 0;
    Console.Clear();
    Console.Write("Cuantos elementos deseas capturar? ");
    num = int.Parse(Console.ReadLine());
    for(int i = 0; i < num; i = i){
        Console.Write($"Elemento {i+1}: ");
        cals[i] = int.Parse(Console.ReadLine());
        if((cals[i] < 10)||(cals[i] > 100))val = 0;
        else val = 1;
        if(val == 1){
            suma += cals[i];
            i++;
        }
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
    Console.WriteLine("\n\nContar calificacion:");
    Console.Write("Cual calificacion? ");
    calif = int.Parse(Console.ReadLine());
    for(int i = 0; i < num; i++){
        if(cals[i] == calif)veces++;
    }
    Console.WriteLine($"El {calif} aparece {veces} veces");

    Console.Write("\nDeseas continuar (S/N)? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado...");