using System.Globalization;
using esCalculadora;
// See https://aka.ms/new-console-template for more information
Calculadora calc = new Calculadora();
do
{
    Console.WriteLine("Calculadora\nOperaciones\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Limpiar\nElegir opcion: ");
    int opc = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese un numero(terminar con 0):");
    double num = double.Parse(Console.ReadLine());
        switch (opc)
        {
            case 0:
                break;
            case 1:
                calc.Sumar(num);
            break;
            case 2:
                calc.Restar(num);
            break;
            case 3:
                calc.Multiplicar(num);
            break;
            case 4:
                calc.Dividir(num);
            break;
            case 5:
                calc.Limpiar(num);
            break;
            default:
                Console.WriteLine("Dato ingresado no valido...");
            break;
        }
        Console.WriteLine($"Resultado = {calc.Resultado}");
} while (true);

