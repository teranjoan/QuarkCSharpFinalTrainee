using System;
using System.Collections.Generic;
using System.Text;
using TeranJoanQuarkExamenModuloCSharp.prendas;

namespace TeranJoanQuarkExamenModuloCSharp.utils
{
    abstract class Utils
    {
       
        public static float AplicarPorcentaje(float precio, float porcentaje, bool incremental)
        {
            float percentValue = precio * porcentaje / 100;
            if (incremental)
            {
                return precio + percentValue;
            }
            else
            {
                return precio - percentValue;
            }

        }
        public static float CalcularPrecioPantalon(Pantalon pantalon)
        {
            if (pantalon.TipoDePantalon == TipoDePantalonEnum.Chupin)
            {
                pantalon.PrecioUnitario = AplicarPorcentaje(pantalon.PrecioUnitario, 12, false);
            }
            return pantalon.PrecioUnitario;
        }
        public static float CalcularPrecioCamisa(Camisa camisa)
        {
            if (camisa.TipoDeManga == TipoDeMangaDeCamisaEnum.Corta)
            {
                camisa.PrecioUnitario = AplicarPorcentaje(camisa.PrecioUnitario, 10, false);
            }
            if (camisa.TipoDeCuello == TipoDeCuelloDeCamisaEnum.Mao)
            {
                camisa.PrecioUnitario = AplicarPorcentaje(camisa.PrecioUnitario, 3, true);
            }
            return camisa.PrecioUnitario;
        }
    }
}
