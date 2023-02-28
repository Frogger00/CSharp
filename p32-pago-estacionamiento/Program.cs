// Administra el pago por estacionamiento de acuerdo a la zona

int op;
float tasa, pago, impuesto, total;

Console.Write("Administra el pago por estacionamiento de acuerdo a la zona: \n");
Console.Write("1- Estacionamiento Tacuba            3%: \n");
Console.Write("2- Estacionamiento Portales          5%: \n");
Console.Write("3- Estacionamiento Conquistadores    10%: \n");
Console.Write("3- Estacionamiento Pajaros Caidos    15%: \n");
Console.Write("Elige Opcion ? \n"); op = int.Parse(Console.ReadLine());
Console.Write("Pago efectuado ? \n"); pago = float.Parse(Console.ReadLine());

switch(op){
    case 1 : tasa = 0.03f; break;
    case 2 : tasa = 0.05f; break;
    case 3 : tasa = 0.10f; break;
    case 4 : tasa = 0.15f; break;
    default : tasa = 0; break;
}
impuesto = pago * tasa;
total = pago + impuesto;
string salida = string.Format($"\nElegiste el estacionamiento {op}" + 
                            $"\nPagaste {pago} por el tiempo de uso" + 
                            $"\nCorresponde un impuesto de {impuesto:n2}" + 
                            $"\nEl pago total es de {total:n2}");

Console.WriteLine(salida);