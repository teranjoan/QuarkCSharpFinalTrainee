using System;
using System.Collections.Generic;
using System.Text;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    public abstract class APrenda
    {
        public CalidadEnum Calidad { get; set; }
        public float PrecioUnitario { get; set; }
        public int CantidadEnStock { get; set; }

        public APrenda(CalidadEnum Calidad, float PrecioUnitario, int CantidadEnStock)
        {
            this.Calidad = Calidad;
            this.PrecioUnitario = PrecioUnitario;
            this.CantidadEnStock = CantidadEnStock;
        }
        public virtual string ToString()
        {
            return  String.Format("APrenda:[Calidad:{0},PrecioUnitario:{1},CantidadEnStock:{2}]", Calidad, PrecioUnitario, CantidadEnStock);
        }
    }
}
