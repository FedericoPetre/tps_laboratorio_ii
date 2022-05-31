using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3
{
    public class numeroDeTelefonoNoValidoException : Exception
    {
        public numeroDeTelefonoNoValidoException(string mensaje) : base(mensaje)
        {

        }

        public numeroDeTelefonoNoValidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
