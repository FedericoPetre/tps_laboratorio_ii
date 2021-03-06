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
        
        /// <summary>
        /// Para retornar las ganancias por los clientes atendidos
        /// </summary>
        /// <exception cref="PrecioNoEncontradoException">En caso de no encontrarse el precio por el servicio de alguno de los clientes atendidos</exception>
        /// <exception cref="Exception">En caso de producirse un error no tomado en cuenta</exception>
        public decimal GananciaTotal { get { return this.ObtenerGananciasPorClientesAtendidos(); } }
           
        public Negocio()
        {
            this.clientesNoAtendidos = new List<T>();
            this.clientesAtendidos = new List<U>();
        }

        /// <summary>
        /// Para registrar el cliente en el sistema del negocio. (Agrega el cliente en la lista de no antendidos, si es que no se encuentra en ella).
        /// </summary>
        /// <param name="cliente"></param>
        public void RegistrarCliente(T cliente)
        {
            if (this != cliente)
            {
                this.clientesNoAtendidos.Add(cliente);
            }
        }

        /// <summary>
        /// Da de baja al cliente ingresado como parámetro (Si es que se encuentra en la lista de no atendidos).
        /// </summary>
        /// <param name="cliente"></param>
        public void DarDeBajaCliente(T cliente)
        {
            if (this == cliente)
            {
                this.clientesNoAtendidos.Remove(cliente);
            }
        }

        /// <summary>
        /// Muestra la lista de clientes no atendidos del negocio
        /// </summary>
        /// <returns></returns>
        public string MostrarClientesNoAtendidos()
        {
            StringBuilder sb = new StringBuilder();

            if (this.ClientesNoAtendidos.Count == 0)
            {
                sb.AppendLine("No hay clientes esperando a ser atendidos");
            }
            else
            {
                sb.AppendLine("Listado de clientes esperando a ser atendidos");
                sb.AppendLine("*********************************");

                foreach (T clienteItem in this.ClientesNoAtendidos)
                {
                    sb.AppendLine($"{clienteItem.ToString()}");
                    sb.AppendLine("*********************************");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retorna la ganancia de atender al cliente correspondiente al indice ingresado (si existiese) y lo coloca en la lista de atendidos
        /// </summary>
        /// <param name="indexClienteAAtender"></param>
        /// <param name="tipoServicio">tipo de servicio a realizar 0-Corte, 1-Planchado, 2-Tintura, 3-CorteYPlanchado, 4-CorteYTintura, 5-PlanchadoYTintura, 6-Todos</param>
        /// <returns></returns>
        /// <exception cref="PrecioNoEncontradoException">En caso de no haber sido cargados los precios</exception>
        public decimal AtenderCliente(int indexSeleccionado, int tipoServicio)
        {
            decimal precio = 0;

            U nuevoServicio = new U();
            nuevoServicio.ClienteAtendido = this.ClientesNoAtendidos[indexSeleccionado];
            precio = nuevoServicio.AtenderCliente(nuevoServicio.ClienteAtendido, tipoServicio);

            this.ClientesAtendidos.Add(nuevoServicio);

            if (precio == 0)
            {
                this.ClientesAtendidos.Remove(nuevoServicio);
            }

            return precio;
        }

        /// <summary>
        /// Para obtener las ganancias por los clientes atendidos
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
        /// Muestra la lista de todos los servicios realizados en el negocio
        /// </summary>
        /// <returns></returns>
        public string MostrarServiciosRealizados()
        {
            int countAtendidos = this.ClientesAtendidos.Count;
            StringBuilder stringRetorno = new StringBuilder();

            if (countAtendidos == 0)
            {
                stringRetorno.AppendLine("Aún no se han atendido clientes");
            }
            else
            {
                foreach (U item in this.ClientesAtendidos)
                {
                    stringRetorno.AppendLine($"{item.MostrarServicioCompleto()}");
                }            
            }

            return stringRetorno.ToString();
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

        public static bool operator ==(Negocio<T, U> negocio, U servicio)
        {
            bool flagEstaEnElNegocio = false;

            foreach (U item in negocio.ClientesAtendidos)
            {
                if (item == servicio)
                {
                    flagEstaEnElNegocio = true;
                    break;
                }
            }

            return flagEstaEnElNegocio;
        }

        public static bool operator !=(Negocio<T, U> negocio, U servicio)
        {
            return !(negocio == servicio);
        }

    }
}
