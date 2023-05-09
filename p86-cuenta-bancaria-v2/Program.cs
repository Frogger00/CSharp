// Control Bancario V2
// Creamos un banco
Banco mibanco = new Banco("Banco del norte SA de CV","priva las cumbres 123");
// Agregamos clientes al banco
mibanco.AgregarCliente(new Cliente("Carlos","Fuentes"));
mibanco.AgregarCliente(new Cliente("Juan","De La Fuente"));
mibanco.AgregarCliente(new Cliente("Rene","Mayorga"));
mibanco.AgregarCliente(new Cliente("Maria","Vazquez"));
// Agregamos cuentas de diferentes tipos a los clientes del Banco
mibanco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(1500,0.10));
mibanco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(2500,0.20));
mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(6500,500));
mibanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(2500,500));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(16500,1500));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(116500,0.40));
mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(12500,0.30));
// Retiramos y depositamos a las diferentes cuentas de algunos clientes
mibanco.Clientes[1].Cuentas[0].Retira(3000);
mibanco.Clientes[2].Cuentas[0].Retira(17000);
mibanco.Clientes[2].Cuentas[0].Retira(1000);
mibanco.Clientes[3].Cuentas[0].Deposita(200);
// Reporte de clientes del banco y el saldo de sus cuentas
Console.WriteLine($"Reporte del clientes del banco \n{mibanco.ToString()}");
Console.WriteLine($"Clientes: {mibanco.Clientes.Count}\n");
// Pasamos por cada cliente de los que hay en el Banco e imprimimos sus datos
foreach(Cliente cte in mibanco.Clientes) {
    Console.WriteLine($"\nCliente : {cte.ToString()}, Cuentas : {cte.Cuentas.Count}");
    foreach(CuentaBancaria cta in cte.Cuentas) {
        Console.Write((cta is CuentaDeCheques)?"Cuenta de Cheques":"Cuenta de Ahorro"); // Verifica el tipo de cuenta
        if(cta is CuentaDeAhorro) (cta as CuentaDeAhorro).CalcularInteres(); // Si es CuentaDeAhorro se calcula intereses
            Console.WriteLine($", con un saldo de {cta.Saldo:n2}");
    }
} 