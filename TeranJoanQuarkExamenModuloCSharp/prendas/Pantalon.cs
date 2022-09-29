using System;
using System.Collections.Generic;
using System.Text;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    public class Pantalon : APrenda
    {
        public TipoDePantalonEnum TipoDePantalon { get; set; }
        public Pantalon(CalidadEnum Calidad, float PrecioUnitario, int CantidadEnStock, TipoDePantalonEnum TipoDePantalon) : base(Calidad, PrecioUnitario, CantidadEnStock)
        {
            this.TipoDePantalon = TipoDePantalon;
        }
        public override string ToString()
        {
            return String.Format("Pantalon:APrenda:[Calidad:{0},PrecioUnitario:{1},CantidadEnStock:{2}]][TipoDePantalon:{3}]", Calidad, PrecioUnitario, CantidadEnStock, TipoDePantalon);

        }
    }
}
