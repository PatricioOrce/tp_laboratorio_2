using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Methods
        /// <summary>
        /// Valida que el operador recibido sea +, -, / o *.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Devuelve el operador de ser valido, caso contrario devuelve '+'</returns>
        private static char ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador =='/')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
        /// <summary>
        /// Realiza una operacion aritmetica en base a los valores recibidos.
        /// </summary>
        /// <param name="primerOperando"></param>
        /// <param name="segundoOperando"></param>
        /// <param name="operador"></param>
        /// <returns>Devuelve el resultado de la operacion.</returns>
        public static double Operar(Operando primerOperando, Operando segundoOperando, char operador)
        {
            char operadorValidado = ValidarOperador(operador);
            switch (operadorValidado)
            {
                case '+':
                    return primerOperando + segundoOperando;
                case '-':
                    return primerOperando - segundoOperando; 
                case '*':
                    return primerOperando * segundoOperando;
                case '/':
                    return primerOperando / segundoOperando;
                default:
                    return primerOperando + segundoOperando;
            }
        }
        #endregion
    }
}
