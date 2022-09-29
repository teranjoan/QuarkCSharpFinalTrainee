using System;
using System.Collections.Generic;
using System.Text;
using TeranJoanQuarkExamenModuloCSharp.prendas;


namespace TeranJoanQuarkExamenModuloCSharp
{
    public class Tienda
    {
        private string Nombre { get; set; }
        private string Direccion { get; }
        private List<APrenda> Prendas { get; }

        public Tienda(string Nombre, string Direccion)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Prendas = new List<APrenda>();
        }
        public void AgregarPrendas(APrenda prendas)
        {
            Prendas.Add(prendas);
        }
    }
}
