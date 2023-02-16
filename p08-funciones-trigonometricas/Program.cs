Console.WriteLine("Calculando las funciones trigonometricas de un angulo en radianes: \n");
Console.Write("Dame un angulo en Radianes: ");

double angulo = double.Parse(Console.ReadLine());
double seno=Math.Sin(angulo);
double coseno=Math.Cos(angulo);
double tangente=Math.Tan(angulo);

Console.WriteLine($"El angulo capturado es {angulo} ");
Console.WriteLine($"El Seno : {seno} ");
Console.WriteLine($"El Coseno : {coseno} ");
Console.WriteLine($"La Tangente : {tangente} ");