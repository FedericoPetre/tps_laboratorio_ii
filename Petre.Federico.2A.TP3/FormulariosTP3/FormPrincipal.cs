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
        public Negocio<Cliente, ServicioPeluqueria> peluqueria;

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
                if (formCliente.cliente is not null)
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
            this.richTxtBoxInfo.Text = " ";
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
                    decimal gananciaPorElCliente = this.peluqueria.AtenderCliente(indexSeleccionado, tipoServicio);

                    if (gananciaPorElCliente != 0)
                    {
                        this.txtGanancias.Text = $"${gananciaPorElCliente}";
                        this.cmbClientesSinAtender.Items.RemoveAt(indexSeleccionado);
                        this.peluqueria.ClientesNoAtendidos.RemoveAt(indexSeleccionado);
                    }
                }
                else
                {
                    MessageBox.Show("Error, ningún cliente a sido seleccionado para atenderlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Error al mostrar los servicios realizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
