using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorDeparametrosRefEOut
{
    class Calculator
    {
        // Modificador de parâmetros out
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }



        /* Modificador de parâmetros ref
        public static void Triple(ref int x)
        {
            x = x * 3;
        }*/



    }
}
