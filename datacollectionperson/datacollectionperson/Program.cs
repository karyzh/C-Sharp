using System;

string nombre;
int edad;
double salario;
char genero;
bool trabajar;


//Variables
Console.WriteLine("Introduce tu nombre");
nombre = Console.ReadLine();

Console.WriteLine("Introduce tu edad");
edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce tu salario");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduce genero (F) o (M)");
genero = Convert.ToChar(Console.ReadLine());

Console.WriteLine("¿Estás trabajando (True or False)?");
trabajar = Convert.ToBoolean(Console.ReadLine());

//Imprimir datos

Console.WriteLine($"Tu nombre es: {nombre}");
Console.WriteLine($"Tu edad es: {edad}");
Console.WriteLine($"Tu salario es: {salario}");
Console.WriteLine($"Tu genero es: {genero}");
Console.WriteLine($"¿Estas trabajando? {trabajar}");

