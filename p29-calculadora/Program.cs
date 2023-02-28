// Efectua operaciones matematicas basicas con 2 numeros

double n1,n2;
char opcion;

Console.WriteLine("Efectua operaciones matematicas basicas con 2 numeros");
Console.Write("Dame numero 1 "); n1= double.Parse(Console.ReadLine());
Console.Write("Dame numero 2 "); n2= double.Parse(Console.ReadLine());
Console.Write("operacion(+ - * / ^)?");
opcion = Console.ReadLine()[0];
switch(opcion){
    case '+': Console.WriteLine($"{n1} + {n2} = {n1 + n2}"); break;
    case '-': Console.WriteLine($"{n1} - {n2} = {n1 - n2}"); break;
    case '*': Console.WriteLine($"{n1} * {n2} = {n1 * n2}"); break;
    case '/': Console.WriteLine($"{n1} / {n2} = {n1 / n2}"); break;
    case '^':Console.WriteLine($"{n1} ^ {n2} = {Math.Pow(n1,n2)}"); break;
    default : Console.WriteLine("Operacion invalida..."); break;
}
Console.WriteLine("\n Proceso terminado...");