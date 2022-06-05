using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace EntidadesTP3
{
    public static class GestionDeArchivos
    {
        /// <summary>
        /// Para serializar (guardar) una lista de clientes en el archivo ubicado en la ruta pasada como parámetro
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="clientes"></param>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        public static void SerializarXML(string ruta, List<Cliente> clientes)
        {
            using (StreamWriter sWriter = new StreamWriter(ruta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Cliente>));

                if (sWriter is not null)
                {
                    xml.Serialize(sWriter, clientes);

                    sWriter.Close();
                    sWriter.Dispose();
                }          
            }
        }
        /// <summary>
        /// Para recuperar una lista de clientes guardada en el archivo ubicado en la ruta pasada como parámetro (si existe)
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static List<Cliente> DeserializarXML(string ruta)
        {
            List<Cliente> objetoRecuperado = null;
            using (StreamReader sReader = new StreamReader(ruta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Cliente>));
                objetoRecuperado = xml.Deserialize(sReader) as List<Cliente>;
            }
            return objetoRecuperado;
        }

        /// <summary>
        /// Para guardar el texto ingresado por parámetro en el archivo correspondiente a la ruta donde se encuentra ubicado
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="textoAGuardar"></param>
        /// <exception cref="Exception">En caso de que el streamWriter lanze una excepcion al momento de instanciarse</exception>
        public static void GuardarTexto(string ruta, string textoAGuardar)
        {
            StreamWriter sWriter = null;
            try
            {
                sWriter = new StreamWriter(ruta);
                sWriter.WriteLine(textoAGuardar);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sWriter is not null)
                {
                    sWriter.Close();
                    sWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Para recuperar el contenido del archivo correspondiente a la ruta pasada por parámetro (si existe)
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        /// <exception cref="Exception">en caso de que OpenText lanze alguna excepción o el archivo no exista</exception>
        public static string LeerTexto(string ruta)
        {
            string retornoStr = string.Empty;
            StreamReader sReader = null;

            if (File.Exists(ruta))
            {
                try
                {
                    sReader = File.OpenText(ruta);
                    retornoStr = sReader.ReadToEnd();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sReader is not null)
                    {
                        sReader.Close();
                        sReader.Dispose();
                    }
                }
            }
            else
            {
                throw new Exception("Error, el archivo no existe");
            }

            return retornoStr;
        }

        /// <summary>
        /// Para guardar una lista de servicios de peluqueria en el archivo de la ruta pasado por parámetro
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="servicio"></param>
        /// <exception cref="Exception"></exception>
        public static void SerializarJSON(string ruta, List<ServicioPeluqueria> servicio)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string stringJson = JsonSerializer.Serialize(servicio, opciones);

            GestionDeArchivos.GuardarTexto(ruta, stringJson);
        }

        /// <summary>
        /// Para recuperar una lista de servicios de peluqueria del archivo correspondiente a la ruta pasada por parémetro (si existe)
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="Exception"></exception>
        public static List<ServicioPeluqueria> DeserializarJSON(string ruta)
        {
            string stringJson = GestionDeArchivos.LeerTexto(ruta);

            List<ServicioPeluqueria> servicios = JsonSerializer.Deserialize<List<ServicioPeluqueria>>(stringJson);

            return servicios;
        }

    }
}
