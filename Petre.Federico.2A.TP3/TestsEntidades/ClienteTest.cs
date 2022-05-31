using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesTP3;

namespace TestsEntidades
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        [ExpectedException(typeof(EdadNoValidaException))]
        public void InstanciarUnCliente_CuandoLaEdadPasadaPorParametroEsMenorACero_DeberiaArrojarEdadNoValidaException()
        {
            Cliente cliente = new Cliente("pepe", -1, 444444, 1525252525);
        }

        [TestMethod]
        [ExpectedException(typeof(numeroDeTelefonoNoValidoException))]
        public void InstanciarUnCliente_CuandoElNumeroDeTelefonoEsMenorA1500000000_DeberiaArrojarNumeroDeTelefonoNoValidoException()
        {
            Cliente cliente = new Cliente("pepe", 10, 444444 , 1499999999);
        }

        [TestMethod]
        [ExpectedException(typeof(numeroDeTelefonoNoValidoException))]
        public void InstanciarUnCliente_CuandoElNumeroDeTelefonoEsMayorA1600000000_DeberiaArrojarNumeroDeTelefonoNoValidoException()
        {
            Cliente cliente = new Cliente("pepe", 10, 444444, 1600000001);
        }

        [TestMethod]
        public void CompararModificacion_CuandoSeModificaElNombre_DeberiaSerOtroCliente()
        {
            Cliente cliente = new Cliente("Pepe", 10, 444444, 1554000001);
            Cliente cliente2 = new Cliente("Juan", 10, 444444, 1554000001);

            Cliente.ModificarNombreCliente(cliente, "Juan");
            bool expected = true;
            bool actual = cliente.Equals(cliente2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompararModificacion_CuandoSeModificaLaEdad_DeberiaSerOtroCliente()
        {
            Cliente cliente = new Cliente("Juan", 10, 444444, 1554000001);
            Cliente cliente2 = new Cliente("Juan", 24, 444444, 1554000001);

            Cliente.ModificarEdadCliente(cliente, 24);
            bool expected = true;
            bool actual = cliente.Equals(cliente2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompararModificacion_CuandoSeModificaElDNI_DeberiaSerOtroCliente()
        {
            Cliente cliente = new Cliente("Juan", 24, 444444, 1554000001);
            Cliente cliente2 = new Cliente("Juan", 24, 41000000, 1554000001);

            Cliente.ModificarDniCliente(cliente, 41000000);
            bool expected = true;
            bool actual = cliente.Equals(cliente2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompararModificacion_CuandoSeModificaElTelefono_DeberiaCambiarPorElNuevo()
        {
            Cliente cliente = new Cliente("Juan", 24, 444444, 1554000001);

            Cliente.ModificarTelefono(cliente, 1525252525);
            int expected = 1525252525;
            int actual = cliente.Telefono;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompararModificacion_CuandoSeModificaNombreDniYEdad_DeberiaSerOtroCliente()
        {
            Cliente cliente = new Cliente("Juan", 24, 444444, 1554000001);
            Cliente cliente2 = new Cliente("Pedro", 25, 41000000, 1554000001);

            Cliente.ModificarNombreCliente(cliente, "Pedro");
            Cliente.ModificarEdadCliente(cliente, 25);
            Cliente.ModificarDniCliente(cliente, 41000000);
            bool expected = true;
            bool actual = cliente.Equals(cliente2);

            Assert.AreEqual(expected, actual);
        }
    }
}
