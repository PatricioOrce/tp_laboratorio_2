using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region Atributtes
        private double numero;
        #endregion
        #region Builders
        public Operando() : this('0'){}
        public Operando(string numero)
        {
            Numero = numero;
        }
        public Operando(double numero) {Numero = numero.ToString();}
        #endregion
        #region Methods
        /// <summary>
        /// Comprueba que el valor recibido sea numérico.
        /// </summary>
        /// <param name="operando">Elemento cuyo valor se evalua.</param>
        /// <returns>Devuelve el valor recibido en formato double. Caso contrario devuelve 0.</returns>
        public double ValidarOperando(string operando)
        {
            bool isNumber = true;
            if(operando.Length > 0)
            for(int i = 0; i < operando.Length; i++)
            {
                if(!((operando[i] >= '0' && operando[i] <= '9') || (operando[i] == ',' || operando[i] == '-')))
                {
                        isNumber = false;
                        break;
                }
            }
            bool proceed = double.TryParse(operando, out double result); 
            if (proceed && isNumber)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Valida que la cadena ingresada este compuesta unicamente de 0s y 1s.
        /// </summary>
        /// <param name="binario">Elemento cuyo valor se evalua.</param>
        /// <returns>Devuelve True en caso de ser binario, de lo contrario devuelve False.</returns>
        private bool EsBinario(string binario)
        {
            foreach (char caracter in binario.ToCharArray())
            {
                if (!(caracter == '1' || caracter == '0'))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Valida y convierte una cadena que representa un valor binario a decimal.
        /// </summary>
        /// <param name="binario">Cadena con valor binario a validar.</param>
        /// <returns>Devuelve True en caso de ser binaria, de lo contrario devuelve False.</returns>
        public string BinarioDecimal(string binario)
        {
            long binarioToDecimal = Convert.ToInt64(binario);
            if (EsBinario(binario))
            {
                int numero = 0;
                int digito = 0;
                const int constDivisoria = 10;

                for (long i = binarioToDecimal, j = 0; i > 0; i /= constDivisoria, j++)
                {
                    digito = (int)i % constDivisoria;
                    numero += digito * (int)Math.Pow(2, j);
                }

                return numero.ToString();
            }
            else
            {
                return "Valor Invalido";
            }
        }
        /// <summary>
        /// Convierte un número decimal a binario, en caso de ser posible.
        /// </summary>
        /// <param name="numeroStr">Cadena que representa el numero decimal a convertir.</param>
        /// <returns>Devuelve el numero convertido, caso contrario devuelve "Valor Invalido".</returns>
        public string DecimalBinario(string numeroStr)
        {
            double numeroDouble = Convert.ToDouble(numeroStr);
            return DecimalBinario(numeroDouble);
        }
        /// <summary>
        /// Convierte un número decimal a binario, en caso de ser posible.
        /// </summary>
        /// <param name="numero">Double que representa el numero a convertir.</param>
        /// <returns>Devuelve el numero convertido, caso contrario devuelve "Valor Invalido".</returns>
        public string DecimalBinario(double numero)
        {
            long binario = 0;
            const int constDivisoria = 2;
            long digito = 0;
            if (numero > 0)
            {
                for (long i = (long)numero % constDivisoria, j = 0; numero > 0; numero /= constDivisoria, i = (long)numero % constDivisoria, j++)
                {
                    digito = (long)i % constDivisoria;
                    binario += digito * (long)Math.Pow(10, j);
                }
                return binario.ToString();
            }
            else
            {
                return "Valor Invalido";
            }
        }
        #endregion
        #region Properties
        /// <summary>
        /// Valida y setea el valor recibido.
        /// </summary>
        public string Numero
        {
            set
            {
                {
                    this.numero = ValidarOperando(value.ToString());
                }

            }
        }
        #endregion
        #region OpOverloads
        /// <summary>
        /// Realiza la suma entre 2 valores numericos pertenecientes a la clase Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Devuelve el resultado de la suma.</returns>
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        /// <summary>
        /// Realiza la resta entre 2 valores numericos pertenecientes a la clase Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Devuelve el resultado de la resta.</returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        /// <summary>
        /// Realiza la multiplicacion entre 2 valores numericos pertenecientes a la clase Operando.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Devuelve el resultado de la multiplicacion.</returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        /// <summary>
        /// Realiza la division entre 2 valores numericos pertenecientes a la clase Operando, valida que no se realice una division por 0.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Devuelve el resultado de la division, en caso de ser division por 0 devuelve "Math Error".</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            if (num2.numero != 0)
            {
                return num1.numero / num2.numero;
            }
            else
            {
                return double.MinValue;
            }

        }
        #endregion
    }
}
