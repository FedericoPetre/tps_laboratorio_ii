using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3
{
    public class PrecioNoValidoException : Exception
    {
        public PrecioNoValidoException(string mensaje) : base(mensaje)
        {
        }

        public PrecioNoValidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Exception inner = this.InnerException;

            sb.AppendLine($"{this.Message}");
            while (inner is not null)
            {
                sb.AppendLine($"{inner.Message}");
                inner = inner.InnerException;
            }

            return sb.ToString();
        }
    }
}
