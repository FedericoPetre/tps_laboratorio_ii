using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTP3;

namespace FormulariosTP3
{  
    public partial class FormPrincipal : Form
    {
        protected Negocio<Cliente, ServicioPeluqueria> peluqueria;

        public FormPrincipal()
        {
            InitializeComponent();
            this.peluqueria = new Negocio<Cliente, ServicioPeluqueria>();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            FormIngresarCliente formCliente = new FormIngresarCliente();

            try
            {
                formCliente.ShowDialog();
                if (formCliente.cliente is not null && formCliente.DialogResult == DialogResult.OK)
                {
                    this.peluqueria.RegistrarCliente(formCliente.cliente);
                    this.cmbClientesSinAtender.Items.Add(formCliente.cliente.ATexto());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error desconocido, no se ha podido agregar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegistrarPrecios_Click(object sender, EventArgs e)
        {
            FormCargaDePrecios formCargaPrecios = new FormCargaDePrecios();
            formCargaPrecios.ShowDialog();

            if (formCargaPrecios.DialogResult == DialogResult.OK)
            {
                this.btnRegistrarPrecios.Text = "Modificar Precios";
            }            
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int indexSeleccionado = this.cmbClientesSinAtender.SelectedIndex;

                if (indexSeleccionado != -1)
                {
                    FormModificarDatos formModificar = new FormModificarDatos();
                    formModificar.cliente = this.peluqueria.ClientesNoAtendidos[indexSeleccionado];
                    formModificar.ShowDialog();
                    this.cmbClientesSinAtender.Items.RemoveAt(indexSeleccionado);
                    this.cmbClientesSinAtender.Items.Insert(indexSeleccionado, formModificar.cliente.ATexto());
                }
                else
                {
                    MessageBox.Show("Error al modificar. No has seleccionado ningún cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error al modificar datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error desconocido, no se ha podido modificar datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         

        }

        private void btnClientesNoAtendidos_Click(object sender, EventArgs e)
        {
            this.richTxtBoxInfo.Text = this.peluqueria.MostrarClientesNoAtendidos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.richTxtBoxInfo.Text = "Aquí aparecerá la información del negocio.";
            this.txtGanancias.Text = "$0";
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = this.cmbClientesSinAtender.SelectedIndex;
            if (indexSeleccionado != -1)
            {
                this.peluqueria.DarDeBajaCliente(this.peluqueria.ClientesNoAtendidos[indexSeleccionado]);
                this.cmbClientesSinAtender.Items.RemoveAt(indexSeleccionado);
            }
            else
            {
                MessageBox.Show("No has seleccionado un cliente para dar de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            try
            {
                decimal ganancias = this.peluqueria.GananciaTotal;
                this.txtGanancias.Text = $"${ganancias}";

            }
            catch (PrecioNoEncontradoException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = this.cmbClientesSinAtender.SelectedIndex;

            try
            {
                if (indexSeleccionado != -1)
                {
                    FormAtenderCliente formAtender = new FormAtenderCliente(this.peluqueria.ClientesNoAtendidos[indexSeleccionado]);
                    formAtender.ShowDialog();
                    int tipoServicio = formAtender.IndexTipoServicio;

                    if (formAtender.DialogResult == DialogResult.OK)
                    {
                        decimal gananciaPorElCliente = this.peluqueria.AtenderCliente(indexSeleccionado, tipoServicio);

                        if (gananciaPorElCliente != 0)
                        {
                            this.txtGanancias.Text = $"${gananciaPorElCliente}";
                            this.cmbClientesSinAtender.Items.RemoveAt(indexSeleccionado);
                            this.peluqueria.ClientesNoAtendidos.RemoveAt(indexSeleccionado);
                            MessageBox.Show("El cliente ha sido atendido exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error, ningún cliente ha sido seleccionado para atenderlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (PrecioNoEncontradoException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnMostrarPrecios_Click(object sender, EventArgs e)
        {
            try
            {
                this.richTxtBoxInfo.Text = ServicioPeluqueria.MostrarPreciosServicio();
            }
            catch(PrecioNoEncontradoException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnServiciosRealizados_Click(object sender, EventArgs e)
        {
            try
            {
                this.richTxtBoxInfo.Text = this.peluqueria.MostrarServiciosRealizados();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar los servicios realizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarDatosClientes_Click(object sender, EventArgs e)
        {
            try
            {
                GestionDeArchivos.SerializarXML("clientesNoAtendidos.xml", this.peluqueria.ClientesNoAtendidos);
                GestionDeArchivos.GuardarTexto("clientesNoAtendidos.txt", this.peluqueria.MostrarClientesNoAtendidos());
                GestionDeArchivos.SerializarJSON("clientesAtentidos.json", this.peluqueria.ClientesAtendidos);
                GestionDeArchivos.GuardarTexto("clientesAtendidos.txt", this.peluqueria.MostrarServiciosRealizados());
                GestionDeArchivos.GuardarTexto("preciosPeluqueria.txt", ServicioPeluqueria.MostrarPreciosServicio());
                MessageBox.Show("Se han guardado los datos exitosamente", "atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PrecioNoEncontradoException)
            {
                MessageBox.Show("Ocurrió un error al guardar el listado de precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos de los clientes, por favor verifique que todo sea correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarDatosClientes_Click(object sender, EventArgs e)
        {
            List<Cliente> clientesNoAtendidos = null;
            List<ServicioPeluqueria> clientesAtendidos = null;
            try
            {
                clientesNoAtendidos = GestionDeArchivos.DeserializarXML("clientesNoAtendidos.xml");
                clientesAtendidos = GestionDeArchivos.DeserializarJSON("clientesAtentidos.json");

                if (clientesNoAtendidos is not null && clientesAtendidos is not null)
                {
                    MessageBox.Show("Se han cargado los datos exitosamente", "atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnCargarDatosClientes.Visible = false;
                    this.btnGuardarDatosClientes.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos de los clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                foreach (Cliente item in clientesNoAtendidos)
                {
                    if (item is not null && this.peluqueria != item)
                    {
                        this.peluqueria.ClientesNoAtendidos.Add(item);
                        this.cmbClientesSinAtender.Items.Add(item.ATexto());
                    }
                }

                foreach(ServicioPeluqueria item in clientesAtendidos)
                {
                    if (item is not null && this.peluqueria != item)
                    {
                        this.peluqueria.ClientesAtendidos.Add(item);
                    }
                }
            }

            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
