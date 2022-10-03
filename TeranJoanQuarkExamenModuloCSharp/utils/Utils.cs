using System;
using System.Collections.Generic;
using System.Text;
using TeranJoanQuarkExamenModuloCSharp.prendas;

namespace TeranJoanQuarkExamenModuloCSharp.utils
{
    abstract class Utils
    {
        public static int UtilSelectOption(string message, string[] options)
        {
            while (true)
            {
                Console.WriteLine(message);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(i + "-" + options[i]);
                }
                string selectedAsString = Console.ReadLine();
                try
                {
                    int selectedAsInt = int.Parse(selectedAsString);
                    if (selectedAsInt > -1 && selectedAsInt < options.Length)
                    {
                        return selectedAsInt;
                    }
                }
                catch (Exception) { }
            }
        }

        public static float UtilInputPrice(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string selectedAsString = Console.ReadLine();
                try
                {
                    float selectedAsFloat = float.Parse(selectedAsString);
                    if (selectedAsFloat >= 0)
                    {
                        return selectedAsFloat;
                    }
                    else
                    {
                        Console.WriteLine("Debes ingresar un precio valido.");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Debes ingresar un precio valido.");
                }
            }
        }
        public static int UtilInputQuantity(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string selectedAsString = Console.ReadLine();
                try
                {
                    int selectedAsInt = int.Parse(selectedAsString);
                    if (selectedAsInt > 0)
                    {
                        return selectedAsInt;
                    }
                    else
                    {
                        Console.WriteLine("Debes ingresar una cantidad valida.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Debes ingresar un cantidad valida.");
                }
            }
        }
        public static float AplicarPorcentaje(float precio, float porcentaje, bool incremental)
        {
            if (incremental)
            {
                return precio * (porcentaje / 100);
            }
            else
            {
                return precio - (precio / 100 * porcentaje);
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
