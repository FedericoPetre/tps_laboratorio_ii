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

        private static decimal precioCorte;
        private static decimal precioPlanchado;
        private static decimal precioTintura;

        public string TipoServicio { get { return this.tipoDeServicio.ToString(); } }

        /// <summary>
        /// Para retornar el precio por el servicio del cliente actual (instancia)
        /// </summary>
        /// <exception cref="PrecioNoEncontradoException">En caso de que no haya sido cargado el precio del tipo de servicio</exception>
        /// <exception cref="Exception">En caso de ocurrir un error desconocido</exception>
        public decimal PrecioServicio { get { return this.ObtenerPrecio(this.tipoDeServicio); } }
        public Cliente ClienteAtendido { get { return this.clienteAtendido; } set { this.clienteAtendido = value; } }

        /// <summary>
        /// Para asignar o retornar el Precio del corte de pelo
        /// </summary>
        /// <exception cref="PrecioNoEncontradoException">En caso de que el precio no haya sido registrado</exception>
        /// <exception cref="PrecioNoValidoException">En caso de que el precio ingresado sea menor a cero</exception>
        public static decimal PrecioCorte
        {
            get 
            {
                if (ServicioPeluqueria.precioCorte == 0)
                {
                    throw new PrecioNoEncontradoException("Error, el precio del corte no fue registrado");
                }
                else
                {
                    return ServicioPeluqueria.precioCorte;
                }
            }

            set 
            {
                if (value < 0)
                {
                    throw new PrecioNoValidoException("Error al registrar el precio del corte, este debe ser mayor a 0");
                }
                else
                {
                    ServicioPeluqueria.precioCorte = value;
                }
            }
        }

        /// <summary>
        /// Para asignar o retornar el Precio del planchado de pelo
        /// </summary>
        /// <exception cref="PrecioNoEncontradoException">En caso de que el precio no haya sido registrado</exception>
        /// <exception cref="PrecioNoValidoException">En caso de que el precio ingresado sea menor a cero</exception>
        public static decimal PrecioPlanchado
        {
            get
            {
                if (ServicioPeluqueria.precioPlanchado == 0)
                {
                    throw new PrecioNoEncontradoException("Error, el precio del planchado no fue registrado");
                }
                else
                {
                    return ServicioPeluqueria.precioPlanchado;
                }
            }

            set
            {
                if (value < 0)
                {
                    throw new PrecioNoValidoException("Error al registrar el precio del planchado, este debe ser mayor a 0");
                }
                else
                {
                    ServicioPeluqueria.precioPlanchado = value;
                }
            }
        }

        /// <summary>
        /// Para asignar o retornar el Precio de la tintura de pelo
        /// </summary>
        /// <exception cref="PrecioNoEncontradoException">En caso de que el precio no haya sido registrado</exception>
        /// <exception cref="PrecioNoValidoException">En caso de que el precio ingresado sea menor a cero</exception>
        public static decimal PrecioTintura
        {
            get
            {
                if (ServicioPeluqueria.precioTintura == 0)
                {
                    throw new PrecioNoEncontradoException("Error, el precio de la tintura no fue registrado");
                }
                else
                {
                    return ServicioPeluqueria.precioTintura;
                }
            }

            set
            {
                if (value < 0)
                {
                    throw new PrecioNoValidoException("Error al registrar el precio de la tintura, este debe ser mayor a 0");
                }
                else
                {
                    ServicioPeluqueria.precioTintura = value;
                }
            }
        }


        /// <summary>
        /// Muestra los precios por cada servicio de la peluquería
        /// </summary>
        /// <returns></returns>
        /// <exception cref="PrecioNoEncontradoException"></exception>
        /// <exception cref="Exception"></exception>
        public static string MostrarPreciosServicio()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                decimal precioCorte = ServicioPeluqueria.PrecioCorte;
                decimal precioTintura = ServicioPeluqueria.PrecioTintura;
                decimal precioPlanchado = ServicioPeluqueria.PrecioPlanchado;

                sb.AppendLine("Precios de la Peluquería");
                sb.AppendLine($"Corte: ${precioCorte}");
                sb.AppendLine($"Planchado: ${precioPlanchado}");
                sb.AppendLine($"Tintura: ${precioTintura}");
            }
            catch (PrecioNoEncontradoException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
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

        static ServicioPeluqueria()
        {
            ServicioPeluqueria.precioCorte = 0;
            ServicioPeluqueria.precioPlanchado = 0;
            ServicioPeluqueria.precioTintura = 0;
        }

        /// <summary>
        /// Para cargar los precios del corte, planchado y tintura
        /// </summary>
        /// <param name="precioCorte"></param>
        /// <param name="precioPlanchado"></param>
        /// <param name="precioTintura"></param>
        /// <exception cref="PrecioNoValidoException">en caso de que alguno de los precios ingresados sea menor a 0</exception>
        private static void CargarPrecios(decimal precioCorte, decimal precioPlanchado, decimal precioTintura)
        {
            ServicioPeluqueria.PrecioCorte = precioCorte;
            ServicioPeluqueria.PrecioPlanchado = precioPlanchado;
            ServicioPeluqueria.PrecioTintura = precioTintura;
        }

        /// <summary>
        /// Para cargar los precios de la peluqueria con parámetros string
        /// </summary>
        /// <param name="precioCorteStr"></param>
        /// <param name="precioPlanchadoStr"></param>
        /// <param name="precioTinturaStr"></param>
        /// <exception cref="PrecioNoValidoException">En caso de que alguno de los precios ingresados sea menor a cero</exception>
        ///<exception cref="Exception">En caso de no poder convertir alguno de los precios ingresados por parámetro</exception>
        public static void CargarPreciosPeluqueria(string precioCorteStr, string precioPlanchadoStr, string precioTinturaStr)
        {
            bool convirtioCorte;
            bool convirtioPlanchado;
            bool convirtioTintura;

            try
            {
                convirtioCorte = decimal.TryParse(precioCorteStr, out decimal precioCorte);
                convirtioPlanchado = decimal.TryParse(precioPlanchadoStr, out decimal precioPlanchado);
                convirtioTintura = decimal.TryParse(precioTinturaStr, out decimal precioTintura);

                if (convirtioCorte && convirtioPlanchado && convirtioTintura)
                {
                    ServicioPeluqueria.CargarPrecios(precioCorte, precioPlanchado, precioTintura);
                }
                else
                {
                    throw new Exception("Error, los valores ingresados deben ser numéricos");
                }
            }
            catch (PrecioNoValidoException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Retorna el precio del servicio por atender al cliente, entrada tipoServicio: 0 -corte, 1-planchado, 2-tintura, 3-corteYplanchado, 4-corteYtintura, 5-planchadoYtintura, 6-todos
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

            try
            {
                if (cliente is not null)
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
                else
                {
                    throw new Exception("Error, no se ha encontrado ningún cliente para atender");
                }

            }
            catch (PrecioNoEncontradoException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
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
                        precio = ServicioPeluqueria.PrecioCorte;
                        break;
                    case EServicioPeluqueria.Planchado:
                        precio = ServicioPeluqueria.PrecioPlanchado;
                        break;
                    case EServicioPeluqueria.Tintura:
                        precio = ServicioPeluqueria.PrecioTintura;
                        break;
                    case EServicioPeluqueria.CorteYPlanchado:
                        precio = ServicioPeluqueria.PrecioCorte + ServicioPeluqueria.PrecioPlanchado;
                        break;
                    case EServicioPeluqueria.CorteYTintura:
                        precio = ServicioPeluqueria.PrecioCorte + ServicioPeluqueria.PrecioTintura;
                        break;
                    case EServicioPeluqueria.PlanchadoYTintura:
                        precio = ServicioPeluqueria.PrecioPlanchado + ServicioPeluqueria.PrecioTintura;
                        break;
                    case EServicioPeluqueria.Todos:
                        precio = ServicioPeluqueria.PrecioCorte + ServicioPeluqueria.PrecioPlanchado + ServicioPeluqueria.PrecioTintura;
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

        public override bool Equals(object obj)
        {
            ServicioPeluqueria sp = obj as ServicioPeluqueria;
            return sp is not null && this == sp;
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