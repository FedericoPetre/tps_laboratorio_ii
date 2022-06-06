using System;
using System.Text;

namespace EntidadesTP3
{
    public class Cliente
    {
        private string nombre;
        private int edad;
        private int dni;
        private int numeroDeTelefono;

        /// <summary>
        /// Devuelve o asigna el nombre de un cliente
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Devuelve o asigna la edad de un cliente
        /// </summary>
        /// <exception cref="EdadNoValidaException">Lanza una excepcion si se intenta ingresar una edad menor a 0</exception>
        public int Edad
        {
            get { return this.edad; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new EdadNoValidaException("Error al ingresar la edad, debe ser un número mayor a 0 y menor a 120");
                }
                else
                {
                    this.edad = value;
                }
            }
        }

        /// <summary>
        /// Para asignar o retornar el DNI del cliente
        /// </summary>
        public int Dni { get { return this.dni; } set { this.dni = value; } }

        /// <summary>
        /// Para asignar o retornar el Teléfono del cliente
        /// </summary>
        /// <exception cref="numeroDeTelefonoNoValidoException">Lanza la excepcion si el número de teléfono ingresado no se encuentra en el rango 1500000000 - 1600000000</exception>
        public int Telefono
        {
            get
            {
                return this.numeroDeTelefono;
            }
            set
            {
                if (value < 1500000000 || value > 1599999999)
                {
                    throw new numeroDeTelefonoNoValidoException("Error al ingresar el número de celular, debe estar entre 1500000000 y 1600000000");
                }
                else
                {
                    this.numeroDeTelefono = value;
                }
            }
        }

        public Cliente()
        { 
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="telefono"></param>
        /// <exception cref="EdadNoValidaException"></exception>
        /// <exception cref="numeroDeTelefonoNoValidoException"></exception>
        public Cliente(string nombre, int edad, int dni, int telefono)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Dni = dni;
            this.Telefono = telefono;
        }

        /// <summary>
        /// Para retornar todos los datos del cliente
        /// </summary>
        /// <returns></returns>
        private string MostrarCliente()
        {
            return $"Nombre: {this.Nombre}\nEdad: {this.Edad} años \nDNI: {this.Dni} \nTeléfono: {this.Telefono}\n";
        }

        /// <summary>
        /// Retorna todos los datos del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarCliente();
        }

        /// <summary>
        /// Para retornar los datos del cliente, en el formato mostrado en el ComboBox del Form Principal
        /// </summary>
        /// <returns></returns>
        public string ATexto()
        {
            return $"{this.Nombre}-{this.Edad}-{this.Dni}-{this.Telefono}";
        }

        /// <summary>
        /// Para modificar el nombre del cliente ingresado por parámetro
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="nuevoNombre"></param>
        public static void ModificarNombreCliente(Cliente cliente, string nuevoNombre)
        {
            cliente.Nombre = nuevoNombre;
        }

        /// <summary>
        /// Para modificar la edad del cliente ingresado por parámetro
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="nuevaEdad"></param>
        /// <exception cref="EdadNoValidaException">En caso de que la edad sea menor a cero</exception>
        public static void ModificarEdadCliente(Cliente cliente, int nuevaEdad)
        {
            cliente.Edad = nuevaEdad;
        }

        /// <summary>
        /// Para modificar el dni del cliente ingresado por parámetro
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="nuevoDni"></param>
        public static void ModificarDniCliente(Cliente cliente, int nuevoDni)
        {
            cliente.Dni = nuevoDni;
        }

        /// <summary>
        /// Para modificar el teléfono del cliente ingresado por parámetro
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="nuevoTelefono"></param>
        /// <exception cref="numeroDeTelefonoNoValidoException">En caso de no estar en el rango 1500000000-1600000000</exception>
        public static void ModificarTelefono(Cliente cliente, int nuevoTelefono)
        {
            cliente.Telefono = nuevoTelefono;
        }


        /// <summary>
        /// Dos clientes serán iguales si comparten nombre, edad, dni y telefono
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Nombre == c2.Nombre && c1.Edad == c2.Edad && c1.Dni == c2.Dni && c1.Telefono == c2.Telefono;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente is not null && this == cliente;            
        }
    }
}
