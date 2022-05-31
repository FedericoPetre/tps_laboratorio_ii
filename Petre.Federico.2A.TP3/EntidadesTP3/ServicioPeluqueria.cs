using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3
{
    public class ServicioPeluqueria : IServicio
    {
       private Cliente clienteAtendido;
       private EServicioPeluqueria tipoDeServicio;
       public static Dictionary<EServicioPeluqueria, decimal> listadoDePrecios;

       public string TipoServicio { get { return this.tipoDeServicio.ToString(); } }
        
        /// <summary>
        /// Para retornar el precio por el servicio del cliente actual (instancia)
        /// </summary>
        /// <exception cref="PrecioNoEncontradoException">En caso de que no haya sido cargado el precio del tipo de servicio</exception>
        /// <exception cref="Exception">En caso de ocurrir un error desconocido</exception>
       public decimal PrecioServicio { get { return this.ObtenerPrecio(this.tipoDeServicio); } }
       public Cliente ClienteAtendido { get { return this.clienteAtendido; } }


        /// <summary>
        /// Para asignar o retornar el precio por el servicio de corte de pelo
        /// </summary>
        /// <exception cref="PrecioNoValidoException">En caso de que el valor a ingresar resulte invalido (menor a 0)</exception>
        ///<exception cref="PrecioNoEncontradoException">En caso de que no se encuentre el precio del corte registrado</exception>
        public decimal PrecioCorte
        {
            get
            {
                decimal precioRetornado = 0;
                try
                {
                    bool flagEstaCargado = ServicioPeluqueria.listadoDePrecios.ContainsKey(EServicioPeluqueria.Corte);
                    if (!flagEstaCargado)
                    {
                        throw new PrecioNoEncontradoException("Error, no se ha ingresado el precio del corte");
                    }
                    else
                    {
                        ServicioPeluqueria.listadoDePrecios.TryGetValue(EServicioPeluqueria.Corte, out decimal precio);
                        precioRetornado = precio;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new PrecioNoEncontradoException("Error al obtener el precio del servicio", ex);
                }
                return precioRetornado;

            }
            set
            {
                if (value < 0)
                {
                    throw new PrecioNoValidoException("Error al cargar el precio al corte");
                }
                else
                {
                    ServicioPeluqueria.listadoDePrecios.Add(EServicioPeluqueria.Corte, value);
                }
            }
        }

        /// <summary>
        /// Para asignar o retornar el precio por el servicio de planchado de pelo
        /// </summary>
        /// <exception cref="PrecioNoValidoException">En caso de que el valor a ingresar resulte invalido (menor a 0)</exception>
        ///<exception cref="PrecioNoEncontradoException">En caso de que no se encuentre el precio del planchado registrado</exception>
        public decimal PrecioPlanchado
        {
            get
            {
                decimal precioRetornado = 0;
                try
                {
                    bool flagEstaCargado = ServicioPeluqueria.listadoDePrecios.ContainsKey(EServicioPeluqueria.Planchado);
                    if (!flagEstaCargado)
                    {
                        throw new PrecioNoEncontradoException("Error, no se ha ingresado el precio del planchado");
                    }
                    else
                    {
                        ServicioPeluqueria.listadoDePrecios.TryGetValue(EServicioPeluqueria.Planchado, out decimal precio);
                        precioRetornado = precio;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new PrecioNoEncontradoException("Error al obtener el precio del servicio", ex);
                }
                return precioRetornado;

            }
            set
            {
                if (value < 0)
                {
                    throw new PrecioNoValidoException("Error al cargar el precio al planchado");
                }
                else
                {
                    ServicioPeluqueria.listadoDePrecios.Add(EServicioPeluqueria.Planchado, value);
                }
            }
        }

        /// <summary>
        /// Para asignar o retornar el precio por el servicio de Tintura
        /// </summary>
        /// <exception cref="PrecioNoValidoException">En caso de que el valor a ingresar resulte invalido (menor a 0)</exception>
        ///<exception cref="PrecioNoEncontradoException">En caso de que no se encuentre el precio de la tintura registrado</exception>
        public decimal PrecioTintura
        {
            get
            {
                decimal precioRetornado = 0;
                try
                {
                    bool flagEstaCargado = ServicioPeluqueria.listadoDePrecios.ContainsKey(EServicioPeluqueria.Tintura);
                    if (!flagEstaCargado)
                    {
                        throw new PrecioNoEncontradoException("Error, no se ha ingresado el precio de la tintura");
                    }
                    else
                    {
                        ServicioPeluqueria.listadoDePrecios.TryGetValue(EServicioPeluqueria.Tintura, out decimal precio);
                        precioRetornado = precio;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new PrecioNoEncontradoException("Error al obtener el precio del servicio", ex);
                }
                return precioRetornado;

            }
            set
            {
                if (value < 0)
                {
                    throw new PrecioNoValidoException("Error al cargar el precio a la tintura");
                }
                else
                {
                    ServicioPeluqueria.listadoDePrecios.Add(EServicioPeluqueria.Tintura, value);
                }
            }
        }

        /// <summary>
        /// Muestra los precios por cada servicio de la peluquería
        /// </summary>
        /// <returns></returns>
        public string MostrarPreciosServicio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Precios de la Peluquería");
            try
            {
                if (this.PrecioCorte != 0 && this.PrecioPlanchado != 0 && this.PrecioTintura != 0)
                {
                    foreach (KeyValuePair<EServicioPeluqueria, decimal> item in ServicioPeluqueria.listadoDePrecios)
                    {
                        sb.AppendLine($"Precio por {item.Key.ToString()} : ${item.Value}");
                    }
                }
                else
                {
                    throw new Exception("Error al mostrar los precios de la peluqueria, no se han cargado todos los precios");
                }

            }
            catch (PrecioNoEncontradoException ex)
            {
                throw new Exception("Error al mostrar todos los precios", ex);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retorna toda la información del servicio, incluyendo datos del cliente atendido, el servicio a realizar y el precio
        /// </summary>
        /// <returns></returns>
        public string MostrarServicioCompleto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Información completa del servicio:");
            sb.AppendLine("**********************************");
            sb.AppendLine("*******Datos del Cliente**********");
            sb.AppendLine($"{this.clienteAtendido.ToString()}");
            sb.AppendLine($"Tipo de servicio recibido: {this.tipoDeServicio.ToString()}");
            sb.AppendLine($"Precio por el servicio: ${this.PrecioServicio}");
            sb.AppendLine("**********************************");

            return sb.ToString();
        }

        public ServicioPeluqueria()
        {
            ServicioPeluqueria.listadoDePrecios = new Dictionary<EServicioPeluqueria, decimal>();
        }

        /// <summary>
        /// Para cargar los precios del corte, planchado y tintura
        /// </summary>
        /// <param name="precioCorte"></param>
        /// <param name="precioPlanchado"></param>
        /// <param name="precioTintura"></param>
        /// <exception cref="PrecioNoValidoException">en caso de que alguno de los precios ingresados sea menor a 0</exception>
        public void CargarPrecios(decimal precioCorte, decimal precioPlanchado, decimal precioTintura)
        {
            this.PrecioCorte = precioCorte;
            this.PrecioPlanchado = precioPlanchado;
            this.PrecioTintura = precioTintura;
        }

        /// <summary>
        /// Retorna el precio del servicio por atender al cliente, parámetro tipoServicio: 0 -corte, 1-planchado, 2-tintura, 3-corteYplanchado, 4-corteYtintura, 5-planchadoYtintura, 6-todos
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="tipoServicio"></param>
        /// <returns></returns>
        /// <exception cref="PrecioNoEncontradoException">En caso de no encontrarse el precio Cargado</exception>
        /// <exception cref="Exception">En caso de producise un error desconocido</exception>
        public decimal AtenderCliente(Cliente cliente, int tipoServicio)
        {
            decimal precio = 0;
            EServicioPeluqueria tipoDeServicio = EServicioPeluqueria.Corte;
            if (cliente is not null)
            {
                try 
                {
                    this.clienteAtendido = cliente;
                    switch (tipoServicio)
                    {
                        case 0:
                            tipoDeServicio = EServicioPeluqueria.Corte;
                            break;
                        case 1:
                            tipoDeServicio = EServicioPeluqueria.Planchado;
                            break;
                        case 2:
                            tipoDeServicio = EServicioPeluqueria.Tintura;
                            break;
                        case 3:
                            tipoDeServicio = EServicioPeluqueria.CorteYPlanchado;
                            break;
                        case 4:
                            tipoDeServicio = EServicioPeluqueria.CorteYTintura;
                            break;
                        case 5:
                            tipoDeServicio = EServicioPeluqueria.PlanchadoYTintura;
                            break;
                        case 6:
                            tipoDeServicio = EServicioPeluqueria.Todos;
                            break;
                    }
                    this.tipoDeServicio = tipoDeServicio;
                    precio = this.ObtenerPrecio(tipoDeServicio);
                }
                catch (PrecioNoEncontradoException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new Exception("Se ha producido un error desconocido", ex);
                }
            }
            return precio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoServicio"></param>
        /// <returns></returns>
        /// <exception cref="PrecioNoEncontradoException">En caso de no encontrarse registrado el precio del tipo de servicio</exception>
        /// <exception cref="Exception">En caso de ocurrir un error desconocido</exception>
        private decimal ObtenerPrecio(EServicioPeluqueria tipoServicio)
        {
            decimal precio = 0;
            try
            {
                switch (tipoServicio)
                {
                    case EServicioPeluqueria.Corte:
                        precio = this.PrecioCorte;
                        break;
                    case EServicioPeluqueria.Planchado:
                        precio = this.PrecioPlanchado;
                        break;
                    case EServicioPeluqueria.Tintura:
                        precio = this.PrecioTintura;
                        break;
                    case EServicioPeluqueria.CorteYPlanchado:
                        precio = this.PrecioCorte + this.PrecioPlanchado;
                        break;
                    case EServicioPeluqueria.CorteYTintura:
                        precio = this.PrecioCorte + this.PrecioTintura;
                        break;
                    case EServicioPeluqueria.PlanchadoYTintura:
                        precio = this.PrecioPlanchado + this.PrecioTintura;
                        break;
                    case EServicioPeluqueria.Todos:
                        precio = this.PrecioCorte + this.PrecioPlanchado + this.PrecioTintura;
                        break;
                }
            }
            catch (PrecioNoEncontradoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error desconocido", ex);
            }

            return precio;
        }

        /// <summary>
        /// Dos servicios de peluquería serán iguales si el cliente es el mismo y el servicio es el mismo
        /// </summary>
        /// <param name="sv1"></param>
        /// <param name="sv2"></param>
        /// <returns></returns>
        public static bool operator ==(ServicioPeluqueria sv1, ServicioPeluqueria sv2)
        {
            return sv1.clienteAtendido == sv2.clienteAtendido && sv1.clienteAtendido == sv2.clienteAtendido;
        }

        public static bool operator !=(ServicioPeluqueria sv1, ServicioPeluqueria sv2)
        {
            return !(sv1 == sv2);
        }
        /// <summary>
        /// Tipos de servicios que ofrece la peluquería
        /// </summary>
        public enum EServicioPeluqueria 
        {
            Corte, Planchado, Tintura, CorteYPlanchado, CorteYTintura, PlanchadoYTintura, Todos
        }

    }
}
