//Dado un número entero entre 1 y 6 que corresponde a un continente del mundo escribir su nombre
int continente;

Console.Clear();
Console.WriteLine("Dado un número entero entre 1 y 6 que corresponde a un continente del mundo\n");
Console.Write("Dame el continente con numero ? "); continente = int.Parse(Console.ReadLine());

switch(continente) {
    case 1 : Console.WriteLine("Asia");break;
    case 2 : Console.WriteLine("Africa");break;
    case 3 : Console.WriteLine("America del Norte");break;
    case 4 : Console.WriteLine("America del Sur");break;
    case 5 : Console.WriteLine("Antartida");break;
    case 6 : Console.WriteLine("Europa");break;
    default : Console.WriteLine("ERROR: No esta en el rango especificado!!!");break;
}
Console.WriteLine("\nProceso terminado ... ");