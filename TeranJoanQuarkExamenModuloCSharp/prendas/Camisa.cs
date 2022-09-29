using System;
using System.Collections.Generic;
using System.Text;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    public class Camisa : APrenda
    {
        public TipoDeCuelloDeCamisaEnum TipoDeCuello { get; set; }
        public TipoDeMangaDeCamisaEnum TipoDeManga { get; set; }

        public Camisa(CalidadEnum Calidad, float PrecioUnitario, int CantidadEnStock, TipoDeCuelloDeCamisaEnum TipoDeCuello, TipoDeMangaDeCamisaEnum TipoDeManga) :base(Calidad, PrecioUnitario, CantidadEnStock)
        {
            this.TipoDeCuello=TipoDeCuello;
            this.TipoDeManga=TipoDeManga;
        }
        public override string ToString()
        {
            return String.Format("Camisa:APrenda:[Calidad:{0},PrecioUnitario:${1},CantidadEnStock:{2},TipoDeCuello:{3},TipoDeManga:{4}]]", Calidad, PrecioUnitario, CantidadEnStock, TipoDeCuello, TipoDeManga);
        }
    }
}
