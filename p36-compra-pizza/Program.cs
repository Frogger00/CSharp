//Diseñe un programa que permita procesar la solicitud de una pizzeria
Console.Clear();
Console.WriteLine("Elija el tamano de su pizza:");
Console.WriteLine("[C]hica - $5 [M]ediana - $10 [G]rande - $15");
Console.Write("Elije una opcion ? "); 

float cant = 0, desc = 0, subtot = 0;
string tamano = "";
char tam = char.Parse(Console.ReadLine().ToUpper());

Console.Write("Cuantas pizzas quieres ? "); 
cant = int.Parse(Console.ReadLine());

switch(tam) {
    case 'C': 
    subtot = 5 * cant;
    tamano = "Chica";
    break;

    case 'M': 
    subtot = 10 * cant;
    tamano = "Mediana";
    break;

    default: 
    subtot = 15 * cant;
    tamano = "Grande";
    break;
}

if(subtot < 2000)desc = 0.0f;
else desc = subtot * 0.15f;

Console.WriteLine("\nSu pedido: ");
Console.WriteLine($"Tamano de la compra: {tamano}");
Console.WriteLine($"Cantidad comprada: {cant} ");
Console.WriteLine($"Total sin descuento: {subtot:c} ");
Console.WriteLine($"Descuento: {desc * 100:c} ");
Console.WriteLine($"Total con descuento: {subtot - desc:c} ");