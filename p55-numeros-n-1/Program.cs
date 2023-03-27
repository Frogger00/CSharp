// Numeros de n a 1 con paso de p
Console.WriteLine("Numeros de n a 1 con paso de p: \n");
Console.Write("Desde donde? "); int n = int.Parse(Console.ReadLine());
Console.Write("Paso? "); int p = int.Parse(Console.ReadLine());

for(int i = n; i >= 1; i -= p) {
    Console.Write($"{i} ");
}