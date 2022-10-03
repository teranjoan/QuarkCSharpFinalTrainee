using System;
using System.Collections.Generic;
using System.Text;
using TeranJoanQuarkExamenModuloCSharp.vista;

namespace TeranJoanQuarkExamenModuloCSharp.prendas
{
    public sealed class ProgramManager
    {
        private readonly static ProgramManager _instance = new ProgramManager();
        private Tienda Tienda;
        public Vendedor Vendedor { get; }
        private Vista Vista;
        public bool ProgramOn { get; set; } 

        private ProgramManager() {
            Tienda = new Tienda("Tienda de ropa Don Filipo", "Avenida El Libertador 1234");
            Vendedor = new Vendedor(1, "Mariano", "Gutierrez", Tienda);
            
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 100, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Corta));
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 100, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Corta));
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 150, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Corta));
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 150, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Corta));
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 75, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Larga));
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 75, TipoDeCuelloDeCamisaEnum.Mao, TipoDeMangaDeCamisaEnum.Larga));
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Standard, 175, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Larga));
            Tienda.AgregarPrendas(new Camisa(CalidadEnum.Premium, 175, TipoDeCuelloDeCamisaEnum.Comun, TipoDeMangaDeCamisaEnum.Larga));
            Tienda.AgregarPrendas(new Pantalon(CalidadEnum.Standard, 750, TipoDePantalonEnum.Chupin));
            Tienda.AgregarPrendas(new Pantalon(CalidadEnum.Premium, 750, TipoDePantalonEnum.Chupin));
            Tienda.AgregarPrendas(new Pantalon(CalidadEnum.Standard, 250, TipoDePantalonEnum.Comun));
            Tienda.AgregarPrendas(new Pantalon(CalidadEnum.Premium, 250, TipoDePantalonEnum.Comun));

            Vista = new Vista(this);
        }

        public static ProgramManager Instance
        {
            get
            {
                return _instance;
            }
        }
        public void InicializarPrograma()
        {
            this.ProgramOn = true;
            this.Vista.MostarMenuPrincipal();
        }
    }
}
