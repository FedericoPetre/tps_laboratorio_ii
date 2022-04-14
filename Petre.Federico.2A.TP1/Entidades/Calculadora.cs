using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        public double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            char operandoValidado = ValidarOperador(operador);

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
