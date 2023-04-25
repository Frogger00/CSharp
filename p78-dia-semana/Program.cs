//p78-dia-semana

String dia_semana(int a){
    switch(a) {
        case 1 : return("Lunes");break;
        case 2 : return("Martes");break;
        case 3 : return("Miercoles");break;
        case 4 : return("Jueves");break;
        case 5 : return("Viernes");break;
        case 6 : return("Sabado");break;
        case 7 : return("Domingo");break;
        default : return("En que dia vives!!!");break;
    }
}

int dia;
char resp;

do{
    Console.Clear();
    Console.WriteLine("Dado un numero entre 1 y 7 imprime el dia de la semana (1 Lunes) \n");
    Console.Write("Dame el dia con numero ? "); dia = int.Parse(Console.ReadLine());
    Console.WriteLine(dia_semana(dia));
    Console.Write("\nDeseas continuar (S/N)? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado...");
