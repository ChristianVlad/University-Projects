using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el tipo de conversión:");
        Console.WriteLine("a. Temperatura (de Celsius a Fahrenheit)");
        Console.WriteLine("b. Longitud (de metros a pies)");
        Console.WriteLine("c. Peso (de kilogramos a libras)");

        char opcion = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (opcion)
        {
            case 'a':
                ConvertirTemperatura();
                break;
            case 'b':
                ConvertirLongitud();
                break;
            case 'c':
                ConvertirPeso();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void ConvertirTemperatura()
    {
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}");
    }

    static void ConvertirLongitud()
    {
        Console.Write("Ingrese la longitud en metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        double pies = metros * 3.28084;

        Console.WriteLine($"La longitud en pies es: {pies}");
    }

    static void ConvertirPeso()
    {
        Console.Write("Ingrese el peso en kilogramos: ");
        double kilogramos = Convert.ToDouble(Console.ReadLine());

        double libras = kilogramos * 2.20462;

        Console.WriteLine($"El peso en libras es: {libras}");
    }
}
