using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesTP3;

namespace TestsEntidades
{
    [TestClass]
    public class ServicioPeluqueriaTest
    {
        [TestMethod]
        [ExpectedException(typeof(PrecioNoEncontradoException))]
        public void MostrarPreciosServicio_CuandoNoFueronCargados_DeberiaArrojarPrecioNoEncontradoException()
        {
            string precios = ServicioPeluqueria.MostrarPreciosServicio();
        }

        [TestMethod]
        [ExpectedException(typeof(PrecioNoEncontradoException))]
        public void MostrarPreciosServicio_CuandoDosNoFueronCargados_DeberiaArrojarPrecioNoEncontradoException()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            string precios = ServicioPeluqueria.MostrarPreciosServicio();
        }

        [TestMethod]
        [ExpectedException(typeof(PrecioNoEncontradoException))]
        public void MostrarPreciosServicio_CuandoUnoNoFueCargados_DeberiaArrojarPrecioNoEncontradoException()
        {
            ServicioPeluqueria.PrecioCorte = 100;
            ServicioPeluqueria.PrecioPlanchado = 200;
            string precios = ServicioPeluqueria.MostrarPreciosServicio();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AtenderCliente_CuandoElClienteEsNull_DeberiaArrojarException()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();
            decimal precio = serviciopeluqueria.AtenderCliente(null, 0);
        }

        [TestMethod]
        public void AtenderCliente_ConCorte_CuandoLosPreciosFueronCargadosCorrectamenteYElClienteEsNoNull_DeberiaRetornarPrecioCorte()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;

            Cliente cliente = new Cliente("Pepe", 30, 11111111, 1525252525);
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();

            decimal expected = 500;
            decimal actual = serviciopeluqueria.AtenderCliente(cliente, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderCliente_ConPlanchado_CuandoLosPreciosFueronCargadosCorrectamenteYElClienteEsNoNull_DeberiaRetornarPrecioPlanchado()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;

            Cliente cliente = new Cliente("Pepe", 30, 11111111, 1525252525);
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();

            decimal expected = 1000;
            decimal actual = serviciopeluqueria.AtenderCliente(cliente, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderCliente_ConTintura_CuandoLosPreciosFueronCargadosCorrectamenteYElClienteEsNoNull_DeberiaRetornarPrecioTintura()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;

            Cliente cliente = new Cliente("Pepe", 30, 11111111, 1525252525);
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();

            decimal expected = 2000;
            decimal actual = serviciopeluqueria.AtenderCliente(cliente, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderCliente_ConCorteYPlanchado_CuandoLosPreciosFueronCargadosCorrectamenteYElClienteEsNoNull_DeberiaRetornarLaSumaCorteYPlanchado()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;

            Cliente cliente = new Cliente("Pepe", 30, 11111111, 1525252525);
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();

            decimal expected = 1500;
            decimal actual = serviciopeluqueria.AtenderCliente(cliente, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderCliente_ConCorteYTintura_CuandoLosPreciosFueronCargadosCorrectamenteYElClienteEsNoNull_DeberiaRetornarLaSumaCorteYTintura()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;

            Cliente cliente = new Cliente("Pepe", 30, 11111111, 1525252525);
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();

            decimal expected = 2500;
            decimal actual = serviciopeluqueria.AtenderCliente(cliente, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderCliente_ConPlanchadoYTintura_CuandoLosPreciosFueronCargadosCorrectamenteYElClienteEsNoNull_DeberiaRetornarLaSumaPlanchadoYTintura()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;

            Cliente cliente = new Cliente("Pepe", 30, 11111111, 1525252525);
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();

            decimal expected = 3000;
            decimal actual = serviciopeluqueria.AtenderCliente(cliente, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderCliente_ConTodos_CuandoLosPreciosFueronCargadosCorrectamenteYElClienteEsNoNull_DeberiaRetornarLaSumaCortePlanchadoYTintura()
        {
            ServicioPeluqueria.PrecioCorte = 500;
            ServicioPeluqueria.PrecioPlanchado = 1000;
            ServicioPeluqueria.PrecioTintura = 2000;

            Cliente cliente = new Cliente("Pepe", 30, 11111111, 1525252525);
            ServicioPeluqueria serviciopeluqueria = new ServicioPeluqueria();

            decimal expected = 3500;
            decimal actual = serviciopeluqueria.AtenderCliente(cliente, 6);

            Assert.AreEqual(expected, actual);
        }

    }
}
