using System;
using System.Collections.Generic;
using System.Text;

namespace ExCotaçãoDolar
{
    class ConversorDeMoedas
    {
        public static double QuantidadeDeDolaresComprados;
        public static double CotaçãoDoDolar;

        public static double iof()
        {
            return (6.0 * QuantidadeDeDolaresComprados / 100.00) * CotaçãoDoDolar;
        }

        public static double ConversaoDoDolar()
        {
            return (CotaçãoDoDolar * QuantidadeDeDolaresComprados) + iof();
        }
    }
}
