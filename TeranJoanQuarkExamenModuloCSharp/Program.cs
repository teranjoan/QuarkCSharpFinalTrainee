using System;
using TeranJoanQuarkExamenModuloCSharp.prendas;

namespace TeranJoanQuarkExamenModuloCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgramManager program = ProgramManager.Instance;
            program.InicializarPrograma();
        }
    }
}