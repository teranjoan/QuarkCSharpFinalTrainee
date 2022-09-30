using System;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    public abstract class APrenda
    {
        public CalidadEnum Calidad { get; set; }
        public float PrecioUnitario { get; set; }
        public int CantidadEnStock { get; set; }

        public APrenda(CalidadEnum Calidad, int CantidadEnStock)
        {
            this.Calidad = Calidad;
            this.CantidadEnStock = CantidadEnStock;
            this.PrecioUnitario = 0;
        }
        public override string ToString()
        {
            return String.Format("APrenda:[Calidad:{0},PrecioUnitario:{1},CantidadEnStock:{2}]", Calidad, PrecioUnitario, CantidadEnStock);
        }

        public virtual bool Equals(APrenda obj)
        {
            return (obj).Calidad == Calidad;
        }
    }
}
