//Dados tres números enteros verificar si son consecutivos
int n1, n2, n3;
string salida;

Console.Clear();
Console.WriteLine("Dame tres numeros: \n");
Console.Write("Dame el primer numero: "); n1 = int.Parse(Console.ReadLine());
Console.Write("Dame el segundo numero: "); n2 = int.Parse(Console.ReadLine());
Console.Write("Dame el tercer numero: "); n3 = int.Parse(Console.ReadLine());

if (n2 - n1 == 1 && n3 - n2 == 1){
    salida = string.Format($"Los numeros ({n1}" + $",{n2}," + $"{n3}) son consecutivos");
}else{
    salida = string.Format($"Los numeros ({n1}" + $",{n2}," + $"{n3}) no son consecutivos");
}
Console.WriteLine(salida);