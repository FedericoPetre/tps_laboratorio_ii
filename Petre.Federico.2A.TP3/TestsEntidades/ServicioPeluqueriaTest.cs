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
        [ExpectedException(typeof(Exception))]
        public void MostrarPreciosServiciosPeluqueria_CuandoNoFueronCargados_DeberiaArrojarException()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();

            string precioServicios = peluqueria.MostrarPreciosServicio();
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MostrarPreciosServiciosPeluqueria_CuandoDosNoFueronCargados_DeberiaArrojarException()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            peluqueria.PrecioCorte = 100;

            string precioServicios = peluqueria.MostrarPreciosServicio();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MostrarPreciosServiciosPeluqueria_CuandoUnoNoFueCargado_DeberiaArrojarException()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;

            string precioServicios = peluqueria.MostrarPreciosServicio();
        }

        [TestMethod]
        [ExpectedException(typeof(PrecioNoEncontradoException))]
        public void AtenderClienteCorteYPlanchado_CuandoPreciosNoFueronCargados_DeberiaArrojarPrecioNoEncontradoException()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            decimal precio = peluqueria.AtenderCliente(cliente, 3);           
        }

        [TestMethod]
        public void AtenderClienteCorte_CuandoPreciosFueronCargados_DeberiaDevolverPrecioCorte()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;
            peluqueria.PrecioTintura = 300;
            decimal expected = 100;
            decimal actual = peluqueria.AtenderCliente(cliente, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderClienteTintura_CuandoPreciosFueronCargados_DeberiaDevolverPrecioTintura()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;
            peluqueria.PrecioTintura = 300;
            decimal expected = 300;
            decimal actual = peluqueria.AtenderCliente(cliente, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderClientePlanchado_CuandoPreciosFueronCargados_DeberiaDevolverPrecioPlanchado()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;
            peluqueria.PrecioTintura = 300;
            decimal expected = 200;
            decimal actual = peluqueria.AtenderCliente(cliente, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderClienteCorteYPlanchado_CuandoPreciosFueronCargados_DeberiaDevolverLaSuma()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;
            peluqueria.PrecioTintura = 300;
            decimal expected = 300;
            decimal actual = peluqueria.AtenderCliente(cliente, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderClienteCorteYTintura_CuandoPreciosFueronCargados_DeberiaDevolverLaSuma()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;
            peluqueria.PrecioTintura = 300;
            decimal expected = 400;
            decimal actual = peluqueria.AtenderCliente(cliente, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderClientePlanchadoYTintura_CuandoPreciosFueronCargados_DeberiaDevolverLaSuma()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;
            peluqueria.PrecioTintura = 300;
            decimal expected = 500;
            decimal actual = peluqueria.AtenderCliente(cliente, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtenderClienteTodos_CuandoPreciosFueronCargados_DeberiaDevolverLaSumaPreciosCortePlanchadoYTintura()
        {
            ServicioPeluqueria peluqueria = new ServicioPeluqueria();
            Cliente cliente = new Cliente("Juan", 24, 42424422, 1525252525);
            peluqueria.PrecioCorte = 100;
            peluqueria.PrecioPlanchado = 200;
            peluqueria.PrecioTintura = 300;
            decimal expected = 600;
            decimal actual = peluqueria.AtenderCliente(cliente, 6);

            Assert.AreEqual(expected, actual);
        }

    }
}
