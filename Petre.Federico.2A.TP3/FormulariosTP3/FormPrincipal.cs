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
                    this.peluqueria.ClientesNoAtendidos.Add(formCliente.cliente);
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
                FormModificarDatos formModificar = new FormModificarDatos();
                formModificar.cliente = this.peluqueria.ClientesNoAtendidos[indexSeleccionado];
                formModificar.ShowDialog();
                this.cmbClientesSinAtender.Items.RemoveAt(indexSeleccionado);
                this.cmbClientesSinAtender.Items.Insert(indexSeleccionado, formModificar.cliente.ATexto());
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
                this.peluqueria.ClientesNoAtendidos.RemoveAt(indexSeleccionado);
                this.cmbClientesSinAtender.Items.RemoveAt(indexSeleccionado);
            }
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            try
            {
                decimal ganancias = this.peluqueria.GananciaTotal;
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

            if (indexSeleccionado != -1)
            {
                ServicioPeluqueria nuevoServicio = new ServicioPeluqueria();
                nuevoServicio.ClienteAtendido = this.peluqueria.ClientesNoAtendidos[indexSeleccionado];
                this.peluqueria.ClientesAtendidos.Add(nuevoServicio);
                int countAtendidos = this.peluqueria.ClientesAtendidos.Count;
                FormAtenderCliente formAtender = new FormAtenderCliente(this.peluqueria.ClientesAtendidos[countAtendidos-1]);
                              
                formAtender.ShowDialog();

                this.txtGanancias.Text = formAtender.PrecioPorAtencion.ToString();
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
    }
}
