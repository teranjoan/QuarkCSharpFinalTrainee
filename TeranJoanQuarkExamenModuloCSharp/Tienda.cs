using System.Collections.Generic;
using TeranJoanQuarkExamenModuloCSharp.prendas;


namespace TeranJoanQuarkExamenModuloCSharp
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<APrenda> Prendas { get; }

        public Tienda(string Nombre, string Direccion)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Prendas = new List<APrenda>();
        }
        public void AgregarPrendas(APrenda prendaNueva)
        {
            Prendas.Add(prendaNueva);
        }
    }
}
