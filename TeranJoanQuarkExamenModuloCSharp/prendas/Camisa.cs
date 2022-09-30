using System;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    public class Camisa : APrenda
    {
        public TipoDeCuelloDeCamisaEnum TipoDeCuello { get; set; }
        public TipoDeMangaDeCamisaEnum TipoDeManga { get; set; }

        public Camisa(CalidadEnum Calidad, int CantidadEnStock, TipoDeCuelloDeCamisaEnum TipoDeCuello, TipoDeMangaDeCamisaEnum TipoDeManga) : base(Calidad, CantidadEnStock)
        {
            this.TipoDeCuello = TipoDeCuello;
            this.TipoDeManga = TipoDeManga;
        }
        public override string ToString()
        {
            return String.Format("Camisa:APrenda:[Calidad:{0},PrecioUnitario:${1},CantidadEnStock:{2},TipoDeCuello:{3},TipoDeManga:{4}]]", Calidad, PrecioUnitario, CantidadEnStock, TipoDeCuello, TipoDeManga);
        }
        public override bool Equals(APrenda obj)
        {
            return (obj is Camisa) &&
                ((Camisa)obj).Calidad == Calidad &&
                   this.TipoDeCuello == ((Camisa)obj).TipoDeCuello &&
                  this.TipoDeManga == ((Camisa)obj).TipoDeManga;
        }

    }
}
