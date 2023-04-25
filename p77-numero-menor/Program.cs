//p77-numero-menor
int menor(int[] a) {
    int aux = a[0];
    for(int i=0; i < 4; i++)
        if(a[i] < aux)
            aux = a[i];
    return aux;
}

int[] nums = {0, 0, 0, 0};
int resul;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Ingrese 4 numeros enteros\n");
    for(int i=0; i < 4; i++ ) {
        nums[i] = int.Parse(Console.ReadLine());
    }
    resul = menor(nums);
    Console.WriteLine($"\nEl numero menor es: {resul}");
    Console.Write("\nDeseas continuar (S/N)? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado...");
