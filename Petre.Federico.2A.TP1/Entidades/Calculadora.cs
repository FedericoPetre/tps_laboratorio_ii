using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Retorna el resultado de la operación que indica el operador (char, validado) entre los operandos num1 y num2.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            char operandoValidado = Calculadora.ValidarOperador(operador);

            switch (operandoValidado)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }


        /// <summary>
        /// Valida que el operador (char) ingresado sea +, -, * o / y lo retorna. Caso contrario retorna +.  
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            char operadorDeRetorno = '+';

            switch (operador)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    operadorDeRetorno = operador;
                    break;
            }

            return operadorDeRetorno;
        }

    }
}
