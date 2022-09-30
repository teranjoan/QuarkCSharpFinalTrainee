using System;
using TeranJoanQuarkExamenModuloCSharp.prendas;
namespace TeranJoanQuarkExamenModuloCSharp
{
    public class Program
    {
        static Tienda tienda;
        static Vendedor vendedor;

        static void Main(string[] args)
        {
            CargaInicial();
            InicializarPrograma();
        }

        private static void InicializarPrograma()
        {
            bool programOn = true;
            Console.WriteLine("Inicializacion programa de cotizacion");
            while (programOn)
            {

                Console.WriteLine("Seleccione una opcion:\n1-Nueva Cotizacion\n2-Ver Historial de Cotizaciones\n3-Salir");
                string opcionSeleccionada = Console.ReadLine();
                switch (opcionSeleccionada)
                {
                    case ("1"):
                        Console.Clear();
                        vendedor.RealizarCotizacion();
                        break;
                    case ("2"):
                        Console.Clear();
                        vendedor.MostrarHistorialDeCotizaciones();
                        break;
                    case ("3"):
                        programOn = false;
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta. Vuelve a intentarlo.");
                        break;
                }

            }
        }

        static void CargaInicial()
        {
            tienda = new Tienda("Tienda de ropa Don Filipo", "Avenida El Libertador 1234");
            vendedor = new Vendedor(1, "Mariano", "Gutierrez", tienda);

            tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 100, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Corta));
            tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 100, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Corta));
            tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 150, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Corta));
            tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 150, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Corta));
            tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 75, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Larga));
            tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 75, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Larga));
            tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 175, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Larga));
            tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 175, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Larga));

            tienda.AgregarPrendas(new Pantalon(CalidadEnum.Standard, 750, TipoDePantalonEnum.Chupin));
            tienda.AgregarPrendas(new Pantalon(CalidadEnum.Premium, 750, TipoDePantalonEnum.Chupin));
            tienda.AgregarPrendas(new Pantalon(CalidadEnum.Standard, 250, TipoDePantalonEnum.Comun));
            tienda.AgregarPrendas(new Pantalon(CalidadEnum.Premium, 250, TipoDePantalonEnum.Comun));
        }

    }
}