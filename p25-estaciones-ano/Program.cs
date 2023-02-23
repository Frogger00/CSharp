// Muestra la estación del año que corresponde al número introducido
Console.Clear();
Console.WriteLine("Muestra la estacion del año en base al número (1...4):\n");
Console.Write("Dame un numero (1...4) ? ");

int n = int.Parse(Console.ReadLine());

if(n>0 && n<5){
if(n==1) Console.WriteLine("Primavera\n");
if(n==2) Console.WriteLine("Verano\n");
if(n==3) Console.WriteLine("Otoño\n");
if(n==4) Console.WriteLine("Invierno\n");
}
else Console.WriteLine("\nEn que planeta vives?");