using System;
using System.Collections.Generic;
using TeranJoanQuarkExamenModuloCSharp.prendas;
using TeranJoanQuarkExamenModuloCSharp.utils;

namespace TeranJoanQuarkExamenModuloCSharp
{
    public class Vendedor
    {
        private int CodigoVendedor { get; }
        private string Nombre { get; }
        private string Apellido { get; }
        public List<Cotizacion> HistorialCotizaciones { get; set; }
        private Tienda Tienda { get; set; }

        public Vendedor(int CodigoVendedor, string Nombre, string Apellido, Tienda Tienda)
        {
            this.CodigoVendedor = CodigoVendedor;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Tienda = Tienda;
            this.HistorialCotizaciones = new List<Cotizacion>();

        }
        public Cotizacion Cotizar(APrenda prenda, int cantidadACotizar)
        {
            Cotizacion cotizacion = new Cotizacion();
            if (prenda is Pantalon)
            {
                prenda.PrecioUnitario = Utils.CalcularPrecioPantalon((Pantalon)prenda);
            }
            else if (prenda is Camisa)
            {
                prenda.PrecioUnitario = Utils.CalcularPrecioCamisa((Camisa)prenda);
            }
            if (prenda.Calidad == CalidadEnum.Premium)
            {
                prenda.PrecioUnitario += Utils.AplicarPorcentaje(prenda.PrecioUnitario, 30, true);
            }
            prenda.CantidadEnStock = ObtenerCantidadEnStock(prenda);

            if(cantidadACotizar > prenda.CantidadEnStock)
            {
                
                throw new PrendasInsuficientesException();
            }

            cotizacion.NumeroDeIdentificacion = HistorialCotizaciones.Count + 1000;
            cotizacion.FechaYHoraDeCotizacion = DateTime.Now;
            cotizacion.CodigoDeVendedor = CodigoVendedor;
            cotizacion.Prenda = prenda;
            cotizacion.CantidadDeUnidades = cantidadACotizar;
            cotizacion.Resultado = prenda.PrecioUnitario * cotizacion.CantidadDeUnidades;
            HistorialCotizaciones.Add(cotizacion);
            return cotizacion;
        }

        private int ObtenerCantidadEnStock(APrenda prenda)
        {
            List<APrenda> prendasEnDesposito = Tienda.Prendas;
            foreach (APrenda eachPrendaEnDeposito in prendasEnDesposito)
            {
                if (prenda.Equals(eachPrendaEnDeposito))
                {
                    return eachPrendaEnDeposito.CantidadEnStock;
                }
            }
            return 0;
        }
    }
}
