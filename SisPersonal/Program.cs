using System.Globalization;
using esEmpleado;

Empleado[] empleados = new Empleado[3];

for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"Ingrese los datos del empleado N°{i+1}");
    Console.WriteLine("Ingrese nombre de empleado");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Ingrese apellido de {nombre}");
    string apellido = Console.ReadLine();
    Console.WriteLine($"Ingrese fecha de nacimiento de {apellido} {nombre}");
    DateTime fechaDeNacimiento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese estado civil de {apellido} {nombre}");
    char estadocivil = char.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese fecha de ingreso de {apellido} {nombre}");
    DateTime fechaingreso = DateTime.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese sueldo basico de {apellido} {nombre}");
    double basico = double.Parse(Console.ReadLine());

    Console.WriteLine("Seleccione cargo:");
    foreach (var cargo in Enum.GetValues(typeof(Cargos)))
    {
        Console.WriteLine($"{(int)cargo + 1} - {cargo}");
    }
    int cargoSeleccionado = int.Parse(Console.ReadLine());
    Cargos cargoEnum = (Cargos)(cargoSeleccionado-1);

    Empleado nuevo = new Empleado(nombre, apellido, fechaDeNacimiento, estadocivil, fechaingreso, basico, cargoEnum);

    nuevo.calcAntiguedad(fechaingreso);
    nuevo.calcEdad(fechaDeNacimiento);
    nuevo.calcJubilacion();
    nuevo.calcSalario(basico, nuevo.Antiguedad, estadocivil, cargoEnum);

    empleados[i] = nuevo;

}

double total = 0;
foreach (var empleado in empleados)
{
    total += empleado.Salario;
}

Console.WriteLine($"Total de monto a pagar empleados: ${total}");

Empleado jubilacionproxima = empleados[0];


foreach (var empleado in empleados)
{
    if (empleado.Jubilacion < jubilacionproxima.Jubilacion)
    {
        jubilacionproxima = empleado;
    }
}
Console.WriteLine($"Empleado mas proximo a Jubilarse\nNombre: {jubilacionproxima.Nombre}\nApellido: {jubilacionproxima.Apellido}\n Edad: {jubilacionproxima.Edad} Anios\nFecha de nacimiento: {jubilacionproxima.FechaDeNacimiento:dd/MM/yyyy}\nAntiguedad: {jubilacionproxima.Antiguedad} Anios\nSalario NETO: ${jubilacionproxima.Salario}");
