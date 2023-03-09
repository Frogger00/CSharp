Console.Clear();
Console.Write("Nombre del estudiante: ");
string nombre = Console.ReadLine();

Console.Write("Sexo (h/m): ");
char sexo = Console.ReadLine()[0];

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Calificacion 1: ");
double cal1 = double.Parse(Console.ReadLine());

Console.Write("Calificacion 2: ");
double cal2 = double.Parse(Console.ReadLine());

Console.Write("Calificacion 3: ");
double cal3 = double.Parse(Console.ReadLine());

bool aceptado = sexo == 'm' && edad >= 21 && (cal1 + cal2 + cal3) / 3 >= 8 && (cal1 + cal2 + cal3) / 3 <= 9.5; 

if (aceptado)Console.WriteLine($"El estudiante {nombre} ha sido aceptado en la Universidad Kitty Kat SA");
else Console.WriteLine($"El estudiante {nombre} no cumple los requisitos para entrar en la Universidad Kitty Kat SA");