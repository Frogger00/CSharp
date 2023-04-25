//p81-angulo

String tipo_ang(int a){
    if((a > 0)&&(a < 90))return("agudo");
    else if(a == 90)return("recto");
    else if((a > 90)&&(a < 180))return("obtuso");
    else if(a == 180)return("llano");
    else if((a > 180)&&(a < 360));
    else return("no valido"); 
    return "";
}

char resp;
do{

    Console.Clear();
    Console.WriteLine("Ingresa el angulo en grados: ");
    int angulo = int.Parse(Console.ReadLine());
    Console.WriteLine($"El angulo es: {tipo_ang(angulo)}");
    Console.Write("\nDeseas continuar (S/N)? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado...");