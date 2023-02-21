// Verifica si un número es postivo, negativo o cero
int n;

Console.WriteLine("Verfica si un número es postivo, negativo o cero\n");
Console.Write("Dame un numero ? ");

n=int.Parse(Console.ReadLine());

if(n>0)
Console.WriteLine("El número es POSITIVO \n");
if(n<0)
Console.WriteLine("El número es NEGATIVO \n");
if(n==0)
Console.WriteLine("El número es CERO \n");