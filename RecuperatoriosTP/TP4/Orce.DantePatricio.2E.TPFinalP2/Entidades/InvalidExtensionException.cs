using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InvalidExtensionException : Exception
    {
        public InvalidExtensionException()
        {

        }
        public InvalidExtensionException(string message) : base(message)
        {
        }
    }
}
