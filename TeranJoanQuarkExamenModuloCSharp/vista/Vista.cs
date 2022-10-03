using System;
using System.Collections.Generic;
using System.Text;
using TeranJoanQuarkExamenModuloCSharp.prendas;
using TeranJoanQuarkExamenModuloCSharp.utils;

namespace TeranJoanQuarkExamenModuloCSharp.vista
{
    class Vista
    {
        private ProgramManager programManager;
        public Vista(ProgramManager programManager)
        {
            this.programManager = programManager;
        }

        public void MostarMenuPrincipal()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("Inicializacion programa de cotizacion");
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            while (programManager.ProgramOn)
            {
                Console.WriteLine("Seleccione una opcion:\n1-Nueva Cotizacion\n2-Ver Historial de Cotizaciones\n3-Salir");
                string opcionSeleccionada = Console.ReadLine();
                switch (opcionSeleccionada)
                {
                    case ("1"):
                        this.MostrarMenuDeRealizarCotizacion();
                        break;
                    case ("2"):
                        this.MostrarHistorialDeCotizaciones();
                        break;
                    case ("3"):
                        programManager.ProgramOn = false;
                        this.MensajeDeSalirDelPrograma();
                        break;
                    default:
                        this.MensajeDeOpcionIncorrecta();
                        break;
                }

            }
        }

        private void MostrarMenuDeRealizarCotizacion()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("Crear nueva cotizacion.");
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            RealizarCotizacion();
        }

        public void MensajeDeOpcionIncorrecta()
        {
            Console.Clear();
            Console.WriteLine("Opcion incorrecta. Vuelve a intentarlo.");
        }
        public void MensajeDeSalirDelPrograma()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("Saliendo del programa.");
            Console.WriteLine("=============================================================");
        }
        public void MostrarHistorialDeCotizaciones()
        {
            Console.Clear();
            List<Cotizacion> HistorialCotizaciones = programManager.Vendedor.HistorialCotizaciones;

            if (HistorialCotizaciones.Count < 1)
            {
                Console.WriteLine("=============================================================");
                Console.WriteLine("Aun no se han hecho cotizaciones.");
                Console.WriteLine("=============================================================");
                Console.WriteLine();
                return;
            }
            else
            {

                for (int i = 0; i < HistorialCotizaciones.Count; i++)
                {
                    Console.WriteLine("{0}- {1}",i, HistorialCotizaciones[i]);
                }
            }
        }

        public void RealizarCotizacion()
        {
            APrenda prenda;

            int pantalonOCamisa = Utils.UtilSelectOption("Seleccione el tipo de prenda.", new string[] { "Pantalon", "Camisa" });
            CalidadEnum calidadEnum = (CalidadEnum)Utils.UtilSelectOption("Seleccione el la calidad de tela.", new string[] { "Standard", "Premium" });
            if (pantalonOCamisa == 1)
            {
                TipoDeMangaDeCamisaEnum tipoDeMangaDeCamisaEnum = (TipoDeMangaDeCamisaEnum)Utils.UtilSelectOption("Seleccione el tipo de mangas.", new string[] { "Manga Corta", "Manga Larga" });
                TipoDeCuelloDeCamisaEnum tipoDeCuelloDeCamisaEnum = (TipoDeCuelloDeCamisaEnum)Utils.UtilSelectOption("Seleccione el tipo de cuello.", new string[] { "Cuello Mao", "Cuello Comun" });
                prenda = new Camisa(calidadEnum, 0, tipoDeCuelloDeCamisaEnum, tipoDeMangaDeCamisaEnum);
            }
            else
            {
                TipoDePantalonEnum tipoDePantalonEnum = (TipoDePantalonEnum)Utils.UtilSelectOption("Seleccione el tipo de pantalon.", new string[] { "Comun", "Chupin" });
                prenda = new Pantalon(calidadEnum, 0, tipoDePantalonEnum);
            }


            prenda.PrecioUnitario = Utils.UtilInputPrice("Ingrese el valor de la prenda.");
            int cantidadDePrendas = Utils.UtilInputQuantity("Ingrese la cantidad de prendas a cotizar.");

            try
            {
                Cotizacion cotizacion = programManager.Vendedor.Cotizar(prenda, cantidadDePrendas);
                Console.Clear();
                Console.WriteLine("=============================================================");
                Console.WriteLine("Cotizacion realizada con exito:");
                Console.WriteLine(cotizacion);
                Console.WriteLine("=============================================================");
                Console.WriteLine();
            }
            catch (PrendasInsuficientesException)
            {
                Console.Clear();
                Console.WriteLine("=============================================================");
                Console.WriteLine("Disculpe las molestias, no podemos cotizar la cantidad solicitada por falta de Stock. Por favor, realice una nueva cotizacion.");
                Console.WriteLine("=============================================================");
                Console.WriteLine();
            }

        }
    }
}
