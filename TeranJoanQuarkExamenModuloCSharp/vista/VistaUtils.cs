using System;
using System.Collections.Generic;
using System.Text;

namespace TeranJoanQuarkExamenModuloCSharp.vista
{
    abstract class VistaUtils
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
    }
}
