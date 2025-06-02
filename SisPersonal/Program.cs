using System.Globalization;
using esEmpleado;

Console.WriteLine("Ingrese nombre de empleado");
string? nombre = Console.ReadLine();
Console.WriteLine($"Ingrese apellido de {nombre}");
string? apellido = Console.ReadLine();
Console.WriteLine($"Ingrese fecha de nacimiento de {apellido} {nombre}");
DateTime fechaDeNacimiento = DateTime.Parse(Console.ReadLine());
Console.WriteLine($"Ingrese estado civil de {apellido} {nombre}");
char estadocivil = char.Parse(Console.ReadLine());
Console.WriteLine($"Ingrese fecha de ingreso de {apellido} {nombre}");
DateTime fechaingreso = DateTime.Parse(Console.ReadLine());
Console.WriteLine($"Ingrese sueldo basico de {apellido} {nombre}");
double basico = double.Parse(Console.ReadLine());
Console.WriteLine($"Ingrese cargo de {apellido} {nombre}");
string cargo = Console.ReadLine();

Empleado nuevo = new Empleado(nombre, apellido, fechaDeNacimiento, estadocivil, fechaingreso, basico, cargo);

nuevo.calcAntiguedad(fechaingreso);
nuevo.calcEdad(fechaDeNacimiento);
nuevo.calcJubilacion();
nuevo.calcSalario(basico, nuevo.Antiguedad, estadocivil, cargo);

Console.WriteLine($"EMPLEADO CARGADO\nNombre: {nuevo.Nombre}\nApellido: {nuevo.Apellido}\n Edad: {nuevo.Edad}\nFecha de nacimiento: {nuevo.FechaDeNacimiento}\nSalario NETO: {nuevo.Salario}");
