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
        public override string PrettyToString()
        {
            return String.Format("Camisa de Calidad {0} de Cuello {1} y Manga {2}, P/U ${3}. Stock {4} unidades", Calidad, TipoDeCuello, TipoDeManga,PrecioUnitario, CantidadEnStock);
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
