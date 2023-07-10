using ByteBank;

CuentaBancaria cuentaKaryme = new CuentaBancaria();

cuentaKaryme.nombreCliente = "Karyme";
cuentaKaryme.numeroCuenta = "0129 0133 3930 1382";
cuentaKaryme.numeroAgencia = "0132";
cuentaKaryme.saldo = 1254.65;
cuentaKaryme.tasaInteres = 7.5;
cuentaKaryme.limiteSobregiro = 500.00;
Console.WriteLine("Aplicación de cuentas bancarias!");


Console.WriteLine($"Saldo antes del retiro {cuentaKaryme.saldo}");

bool retiroHecho = cuentaKaryme.RetirarDinero(120);
if (retiroHecho)

    Console.WriteLine($"Saldo luego del retiro {cuentaKaryme.saldo}");
 else
    Console.WriteLine("No fue posible hacer el retiro");


if(cuentaKaryme.RetirarDinero(-40))//aquí no se podrá porque debe ser mayor a 0
    Console.WriteLine($"Saldo luego del retiro {cuentaKaryme.saldo}");
else
    Console.WriteLine("No fue posible hacer el retiro de -40");

if(cuentaKaryme.RetirarDinero(1999))
    Console.WriteLine($"Saldo luego del retiro: {cuentaKaryme.saldo}");
else
    Console.WriteLine("No fue posible hacer el retiro de 2000");






////variables por valor
//string nombre1 = "Ailyn";
//string nombre2 = "Ailyn";

//Console.WriteLine("Variable: ");
//Console.WriteLine(nombre1 == nombre2);


Console.ReadLine();