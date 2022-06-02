﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3
{
    public interface IServicio
    {
        public decimal PrecioServicio { get; }
        public string TipoServicio { get; }
        public decimal AtenderCliente(Cliente cliente, int tipoServicio);
        public string MostrarServicioCompleto();
    }
}
