using FirstAssesmentCSharp.Clases;
using static System.Console;

namespace FirstAssesmentCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clear();
            Write("Ingrese el nombre de equipamiento (Futbol, Basketball o Rugby): ");
            string? nombre = ReadLine();

            EquipamientoDeportivo? equipamiento = null;

            Write("Ingrese el precio del equipamiento: ");
            double.TryParse(ReadLine()!.Replace(".", ","), out double precio);

            switch (nombre!.ToLower())
            {
                case "futbol":
                    Write("Ingrese la talla del equipamiento: ");
                    string? tallaFutbol = ReadLine();

                    equipamiento = new EquipamientoFutbol("Futbol", precio, tallaFutbol!);
                    break;

                case "basketball":
                    Write("Ingrese la talla del equipamiento: ");
                    string? tallaBasketball = ReadLine();

                    Write("Ingrese el material del equipamiento: ");
                    string? materialBasketball = ReadLine();

                    equipamiento = new EquipamientoBasketball("Basketball", precio, tallaBasketball!, materialBasketball!);
                    break;

                case "rugby":
                    Write("Ingrese el peso del equipamiento: ");
                    double.TryParse(ReadLine()!.Replace(".", ","), out double pesoRugby);

                    equipamiento = new EquipamientoRugby("Rugby", precio, pesoRugby);
                    break;

                default:
                    WriteLine("Tipo de equipamiento no válido.");
                    break;
            }
            if (equipamiento != null)
            {
                WriteLine(equipamiento.Descripcion());
            }
            Write("Entre cualquier tecla");
            ReadKey();
        }
    }
}