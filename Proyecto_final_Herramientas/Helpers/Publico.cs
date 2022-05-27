using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_Herramientas.Helpers
{
    public static class Publico
    {
        public static bool EsVacio(string cadena)
        {
            if (cadena == null || cadena.Trim() == "")
            {
                return true;
            }
            return false;
        }

        public static bool EsNumero(string cadena)
        {
            try
            {
                if (!EsVacio(cadena))
                {
                    if (decimal.TryParse(cadena, out _))
                    {
                        return true;
                    }
                }

                return false;

            } catch (Exception)
            {
                return false;
            }

        }
    }
}
