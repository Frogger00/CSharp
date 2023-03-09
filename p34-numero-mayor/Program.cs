//Dados tres números enteros verificar cual es el mayor
int n1, n2, n3;
string salida;

Console.Clear();
Console.WriteLine("Dame tres numeros: \n");
Console.Write("Dame el primer numero: "); n1 = int.Parse(Console.ReadLine());
Console.Write("Dame el segundo numero: "); n2 = int.Parse(Console.ReadLine());
Console.Write("Dame el tercer numero: "); n3 = int.Parse(Console.ReadLine());

if (n1 >= n2 && n1 >= n3){
     Console.WriteLine(string.Format($"El numero mayor es {n1}"));
}
else if (n2 >= n1 && n2 >= n3){
     Console.WriteLine(string.Format($"El numero mayor es {n2}"));
}
else if (n3 >= n1 && n3 >= n2){
 Console.WriteLine(string.Format($"El numero mayor es {n3}"));
}