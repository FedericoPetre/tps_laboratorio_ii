using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3
{
    public class Negocio<T, U> where T : Cliente
        where U : ServicioPeluqueria, new()
    {
        private List<T> clientesNoAtendidos;
        private List<U> clientesAtendidos;

        public List<T> ClientesNoAtendidos { get { return this.clientesNoAtendidos; } }
        public List<U> ClientesAtendidos { get { return this.clientesAtendidos; } }
        public decimal GananciaTotal { get { return this.ObtenerGananciasPorClientesAtendidos(); } }
           
        public Negocio()
        {
            this.clientesNoAtendidos = new List<T>();
            this.clientesAtendidos = new List<U>();
        }

        public void RegistrarCliente(T cliente)
        {
            if (this != cliente)
            {
                this.clientesNoAtendidos.Add(cliente);
            }
        }

        public void DarDeBajaCliente(T cliente)
        {
            if (this == cliente)
            {
                this.clientesNoAtendidos.Remove(cliente);
            }
        }

        public string MostrarClientesNoAtendidos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listado de clientes no atendidos");
            sb.AppendLine("********************************");

            foreach (T clienteItem in this.ClientesNoAtendidos)
            {
                sb.AppendLine($"{clienteItem.ToString()}");
                sb.AppendLine("********************************");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retorna la ganancia de atender al primer cliente de la lista de no atendidos y  coloca en la lista de atendidos
        /// </summary>
        /// <param name="clienteASerAtendido"></param>
        /// <param name="tipoServicio">tipo de servicio a realizar 0-Corte, 1-Planchado, 2-Tintura, 3-CorteYPlanchado, 4-CorteYTintura, 5-PlanchadoYTintura, 6-Todos</param>
        /// <returns></returns>
        /// <exception cref="PrecioNoEncontradoException">En caso de no haber sido cargados los precios</exception>
        private decimal AtenderCliente(T clienteASerAtendido, int tipoServicio)
        {
            decimal precio = 0;
            U clienteAtendido = new U();
            precio = clienteAtendido.AtenderCliente(clienteASerAtendido, tipoServicio);
            this.ClientesAtendidos.Add(clienteAtendido);
            return precio;
        }

        /// <summary>
        /// Para obtener las ganancias por los clientes atentidos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="PrecioNoEncontradoException"></exception>
        /// <exception cref="Exception"></exception>
        private decimal ObtenerGananciasPorClientesAtendidos()
        {
            decimal precio = 0;

            foreach (U cliente in this.ClientesAtendidos)
            {
                precio = precio + cliente.PrecioServicio;
            }
            return precio;
        }

        /// <summary>
        /// Para cargar los precios de la peluqueria con parámetros string
        /// </summary>
        /// <param name="precioCorteStr"></param>
        /// <param name="precioPlanchadoStr"></param>
        /// <param name="precioTinturaStr"></param>
        /// <exception cref="PrecioNoValidoException">En caso de que alguno de los precios ingresados sea menor a cero</exception>
        ///<exception cref="Exception">En caso de no poder convertir alguno de los precios ingresados por parámetro</exception>
        public void CargarPreciosPeluqueria(string precioCorteStr, string precioPlanchadoStr, string precioTinturaStr)
        {
            U peluqueria = new U();
            bool convirtioCorte = false;
            bool convirtioPlanchado = false;
            bool convirtioTintura = false;

            convirtioCorte = decimal.TryParse(precioCorteStr, out decimal precioCorte);
            convirtioPlanchado = decimal.TryParse(precioPlanchadoStr, out decimal precioPlanchado);
            convirtioTintura = decimal.TryParse(precioTinturaStr, out decimal precioTintura);

            if (convirtioCorte && convirtioPlanchado && convirtioTintura)
            {
                try
                {
                    peluqueria.CargarPrecios(precioCorte, precioPlanchado, precioTintura);
                }
                catch (PrecioNoValidoException)
                {
                    throw;
                }
            }
            else
            {
                throw new Exception("Error, los valores ingresados deben ser numéricos");
            }            
        }

        public static bool operator ==(Negocio<T,U> negocio, T cliente)
        {
            bool flagEstaEnElNegocio = false;

            foreach (T item in negocio.ClientesNoAtendidos)
            {
                if (item == cliente)
                {
                    flagEstaEnElNegocio = true;
                    break;
                }
            }

            return flagEstaEnElNegocio;
        }

        public static bool operator !=(Negocio<T, U> negocio, T cliente)
        {
            return !(negocio == cliente);
        }

    }
}
