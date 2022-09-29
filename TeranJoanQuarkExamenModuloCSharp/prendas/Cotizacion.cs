using System;
using System.Collections.Generic;
using System.Text;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    class Cotizacion
    {
        public int NumeroDeIdentificacion { get; set; }
        public DateTime FechaYHoraDeCotizacion { get; set; }
        public int CodigoDeVendedor { get; set; }
        public APrenda Prenda { get; set; }
        public int CantidadDeUnidades { get; set; }
        public float Resultado { get; set; }
        public override string ToString()
        {
            string prenda = this.Prenda.ToString();
            return String.Format("Prenda:{0}, Cantidad:{1}, Valor total:{2}", prenda, CantidadDeUnidades, Resultado);
        }

    }
    
}
