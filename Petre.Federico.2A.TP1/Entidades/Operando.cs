using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        ///  Convierte a decimal, si es posible, el string binario ingresado por parámetro. Caso contrario retorna "Valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string stringRetorno = "Valor inválido";
            double numeroDecimal = 0;
            int longitudBinario;
            double numeroBinario;
            bool convertirADouble = double.TryParse(binario, out numeroBinario);
            string stringBinario ="";

            if (convertirADouble)
            {
                numeroBinario = Math.Abs(numeroBinario);
                numeroBinario = Math.Truncate(numeroBinario);
                stringBinario = numeroBinario.ToString();
            }

            if (EsBinario(stringBinario))
            {
                longitudBinario = stringBinario.Length;
                foreach (char caracter in stringBinario)
                {
                    longitudBinario--;
                    if (caracter == '1')
                    {
                        numeroDecimal = numeroDecimal + Math.Pow(2, longitudBinario);
                    }
                }

                stringRetorno = numeroDecimal.ToString();
            }

            return stringRetorno;
        }

        /// <summary>
        /// Convierte a binario, si es posible, el valor absoluto del numero ingresado por parametro. 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            int potenciaMaximaDeDos = 0;
            string stringBinario = "";
            double coeficiente;
            char digitoAConcatenar;
            double numeroAConvertir = Math.Abs(numero);

            if (numeroAConvertir == 0)
            {
                stringBinario = "0";
            }

            while (numeroAConvertir >= Math.Pow(2, potenciaMaximaDeDos))
            {
                potenciaMaximaDeDos++;
            }

            for (int i = 0; i < potenciaMaximaDeDos; i++)
            {
                if (numeroAConvertir % 2 == 0)
                {
                    coeficiente = numeroAConvertir / 2;
                    digitoAConcatenar = '0';
                }
                else
                {
                    coeficiente = (numeroAConvertir - 1) / 2;
                    digitoAConcatenar = '1';
                }

                stringBinario = digitoAConcatenar + stringBinario;
                numeroAConvertir = coeficiente;
            }

            return stringBinario;

        }

        /// <summary>
        /// Convierte a binario, si es posible, el valor absoluto del numero string ingresado por parametro. Caso contrario retorna "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string stringRetorno = "Valor invalido";
            double valorAbsolutoYEntero;
            double doubleNumero;
            bool boolConversor = double.TryParse(numero, out doubleNumero);

            if (boolConversor)
            {
                valorAbsolutoYEntero = Math.Abs(doubleNumero);
                valorAbsolutoYEntero = Math.Truncate(valorAbsolutoYEntero);
                stringRetorno = this.DecimalBinario(valorAbsolutoYEntero);
            }

            return stringRetorno;

        }

        /// <summary>
        /// Determina si un string número está compuesto sólo por 0 y 1. (Es binario)
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            bool flagEsBinario = true;

            foreach (char caracter in binario)
            {
                if (caracter != '1' && caracter != '0')
                {
                    flagEsBinario = false;
                    break;
                }
            }

            return flagEsBinario;
        }

        /// <summary>
        ///  Constructor Operando, inicializa el valor de operando en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        ///  Constructor Operando, asigna el valor del double recibido como parámetro al nuevo Operando
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor Operando, asigna, si es posible, el valor transformado del string ingresado por parámetro al nuevo Operando
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero) : this(double.Parse(strNumero))
        {

        }

        /// <summary>
        /// Sobrecarga del operador - con Operandos
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador * con Operandos
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecaraga del operador / con Operandos
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;

            if (n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }

        /// <summary>
        /// Sobrecarga del operador + con Operandos
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Valida que el string ingresado por parámetro sea un número y en ese caso lo retorna convertido en double. Caso contrario retona 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private static double ValidarOperando(string strNumero)
        {
            double numeroConvertido;
            bool flagConvertido = double.TryParse(strNumero, out numeroConvertido);

            if (!flagConvertido)
            {
                numeroConvertido = 0;
            }

            return numeroConvertido;
        }



    }

}
