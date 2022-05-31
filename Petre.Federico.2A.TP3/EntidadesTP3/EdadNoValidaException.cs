using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3
{
    public class EdadNoValidaException : Exception
    {
        public EdadNoValidaException(string mensaje) : base(mensaje)
        {
        }

        public EdadNoValidaException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
