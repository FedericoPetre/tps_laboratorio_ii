using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3
{
    public interface IServicio
    {
        decimal PrecioServicio { get; set; }
        string TipoServicio { get; set; }
        decimal AtenderCliente(Cliente cliente, int tipoServicio);
        string MostrarServicioCompleto();
    }
}
