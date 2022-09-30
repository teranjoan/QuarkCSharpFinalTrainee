using System;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    public class Pantalon : APrenda
    {
        public TipoDePantalonEnum TipoDePantalon { get; set; }
        public Pantalon(CalidadEnum Calidad, int CantidadEnStock, TipoDePantalonEnum TipoDePantalon) : base(Calidad, CantidadEnStock)
        {
            this.TipoDePantalon = TipoDePantalon;
        }
        public override string ToString()
        {
            return String.Format("Pantalon:APrenda:[Calidad:{0},PrecioUnitario:{1},CantidadEnStock:{2}]][TipoDePantalon:{3}]", Calidad, PrecioUnitario, CantidadEnStock, TipoDePantalon);

        }
        public override bool Equals(APrenda obj)
        {
            return (obj is Pantalon) &&
                ((Pantalon)obj).Calidad == Calidad &&
                   this.TipoDePantalon == ((Pantalon)obj).TipoDePantalon;
        }
    }
}
