using System;

namespace Framework.D_2015.DigitoVerificador
{
    public class DigitoVerificador
    {
        public int calcularDV(string cadena)
        {
            int multiplo = 2;
            var contador = 0;
            for (int i = cadena.Length - 1; i >= 0; i -= 1)
            {
                char unChar = cadena[i];
                //valor que representa el char
                int vChar = (int)unChar;
                int subTot;
                subTot = vChar * multiplo;
                contador = contador + subTot;
            }

            contador = (11 - contador % 11) * cadena.Length;
            return contador;
        }

        public bool VerificarDV(string cadena, int dv)
        {
            if (calcularDV(cadena) == dv)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}