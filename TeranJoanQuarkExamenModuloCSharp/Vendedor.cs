using System;
using System.Collections.Generic;
using System.Text;
using TeranJoanQuarkExamenModuloCSharp.prendas;

namespace TeranJoanQuarkExamenModuloCSharp
{
    class Vendedor
    {
        private int CodigoVendedor { get; }
        private string Nombre { get; }
        private string Apellido { get; }
        public List<Cotizacion> HistorialCotizaciones { get; }
        private Tienda Tienda { get; set; }

        public Vendedor(int CodigoVendedor, string Nombre, string Apellido, Tienda Tienda)
        {
            this.CodigoVendedor = CodigoVendedor;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Tienda = Tienda;
            this.HistorialCotizaciones = new List<Cotizacion>();

        }
        public Cotizacion Cotizar(APrenda prenda)
        {
            Cotizacion cotizacion = new Cotizacion();
            if(prenda is Pantalon)
            {
                prenda.PrecioUnitario = CalcularPrecioPantalon((Pantalon)prenda);
            }
            else if (prenda is Camisa)
            {
                prenda.PrecioUnitario = CalcularPrecioCamisa((Camisa)prenda);
            }

            if(prenda.Calidad == CalidadEnum.Premium)
            {
                prenda.PrecioUnitario = AplicarPorcentaje(prenda.PrecioUnitario, 30, true);
            }
            int CantidadDeUnidades = 10;

            cotizacion.NumeroDeIdentificacion = HistorialCotizaciones.Count+1000;
            cotizacion.FechaYHoraDeCotizacion = DateTime.Now;
            cotizacion.CodigoDeVendedor = CodigoVendedor;
            cotizacion.Prenda = prenda;
            cotizacion.CantidadDeUnidades = CantidadDeUnidades;
            cotizacion.Resultado = prenda.PrecioUnitario* CantidadDeUnidades;
            HistorialCotizaciones.Add(cotizacion);
            Console.WriteLine(cotizacion.ToString());
            return cotizacion;
        }
        private float CalcularPrecioPantalon(Pantalon pantalon)
        {
            if(pantalon.TipoDePantalon == TipoDePantalonEnum.Chupin) {
                pantalon.PrecioUnitario = AplicarPorcentaje(pantalon.PrecioUnitario, 12, false);
            }
            return pantalon.PrecioUnitario;
        }
        private float CalcularPrecioCamisa(Camisa camisa)
        {
            if (camisa.TipoDeManga==TipoDeMangaDeCamisaEnum.Corta)
            {
                camisa.PrecioUnitario = AplicarPorcentaje(camisa.PrecioUnitario, 10, false);
            }
            if (camisa.TipoDeCuello == TipoDeCuelloDeCamisaEnum.Mao)
            {
                camisa.PrecioUnitario = AplicarPorcentaje(camisa.PrecioUnitario, 3, true);
            }
            return camisa.PrecioUnitario;
        }
        private float AplicarPorcentaje(float precio, int porcentaje, bool incremental)
        {
            if (incremental)
            {
                return precio * (porcentaje / 100);
            }
            else
            {
                return precio - (precio / 100 * porcentaje);
            }

        }
        public void MostrarHistorialDeCotizaciones()
        {
            
            if (HistorialCotizaciones.Count < 1)
            {
                Console.WriteLine("Aun no se han hecho cotizaciones.");
                return;
            }

            foreach (Cotizacion cotizacion in HistorialCotizaciones)
            {
                Console.WriteLine(cotizacion);

            }
        }
        public void RealizarCotizacion()
        {
            APrenda prenda;
            
            int pantalonOCamisa = UtilSelectOption("Seleccione el tipo de prenda.", new string[] { "Pantalon", "Camisa" });
            CalidadEnum calidadEnum = (CalidadEnum)UtilSelectOption("Seleccione el la calidad de tela.", new string[] { "Standard", "Premium" });
            if (pantalonOCamisa == 1)
            {
                TipoDeMangaDeCamisaEnum tipoDeMangaDeCamisaEnum = (TipoDeMangaDeCamisaEnum)UtilSelectOption("Seleccione el tipo de mangas.", new string[] { "Manga Corta", "Manga Larga" });
                TipoDeCuelloDeCamisaEnum tipoDeCuelloDeCamisaEnum = (TipoDeCuelloDeCamisaEnum)UtilSelectOption("Seleccione el tipo de cuello.", new string[] { "Cuello Mao", "Cuello Comun" });
                prenda = new Camisa(calidadEnum, 0, 0, tipoDeCuelloDeCamisaEnum, tipoDeMangaDeCamisaEnum);
            }
            else
            {
                TipoDePantalonEnum tipoDePantalonEnum = (TipoDePantalonEnum)UtilSelectOption("Seleccione el tipo de pantalon.", new string[] { "Comun", "Chupin" });
                prenda = new Pantalon(calidadEnum, 0, 0, tipoDePantalonEnum);
            }

            Cotizar(prenda);
        }

        int UtilSelectOption(string message, string[] options)
        {
            while (true)
            {
                Console.WriteLine(message);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(i + "-" + options[i]);
                }
                string selectedAsString = Console.ReadLine();
                try
                {
                    int selectedAsInt = int.Parse(selectedAsString);
                    if (selectedAsInt > -1 && selectedAsInt < options.Length)
                    {
                        return selectedAsInt;
                    }
                }
                catch (Exception)
                {
                }

            }
            return 0;


        }

    }
}
