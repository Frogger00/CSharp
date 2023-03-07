//p40 Primer Examen Parcial
Console.Clear();
void Menu() {
    Console.Clear();
    Console.WriteLine("Universidad Patito -----------------------------------------------------------------------------------");
    Console.WriteLine("Tipo de usuario: [1] Alumno $100, [2] Trabajador $200, [3] Docente $500");
    Console.WriteLine("Tipo de paquete: [1] Solo conferencias $600, [2] Con eventos sociales $800, [3] Con kit de acceso $900");
    Console.WriteLine("------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Debes especificar el tipo de usuario, tipo de paquete, y cantidad para poder procesar tu pedido.");
}

int us, pa, ca;
string usuario = "", paquete = "";
float subtot = 0, desc = 0, total = 0;

if(args.Length < 3) {
    Menu();
    return 1;
}

us = int.Parse(args[0]);
if(us == 1){usuario = "Alumno"; subtot += 100;}
else if(us == 2){usuario = "Trabajador"; subtot += 200;}
else {usuario = "Docente"; subtot += 500;}

pa = int.Parse(args[1]);
if(pa == 1){paquete = "Conferencias"; subtot += 600;}
else if(pa == 2){paquete = "Eventos"; subtot += 800;}
else {paquete = "Todo"; subtot += 900;}

ca = int.Parse(args[2]);
subtot = subtot * ca;

if(subtot >= 5000) {
    if(us == 1)desc = 0.20f;
    else if(us == 2)desc = 0.10f;
    else desc = 0.05f;
}

total = subtot - (subtot * desc);

Console.WriteLine($"Universidad Patito ------------------------------------------------------------");
Console.WriteLine($"Tu pedido fue: {ca} / Tipo de Usuario : {usuario} / Tipo de Paquete: {paquete}");
Console.WriteLine($"Precio normal: {subtot:c} con descuento: {(desc * subtot):c} ({desc*100}%) y un total de: {total:c}");
Console.WriteLine($"--------------------------------------------------------------------------------");

return 0;