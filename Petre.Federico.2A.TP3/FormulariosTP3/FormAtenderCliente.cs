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
    public partial class FormAtenderCliente : Form
    {
        protected ServicioPeluqueria servicio;
        protected decimal precioPorAtencion;

        private FormAtenderCliente()
        {
            InitializeComponent();
            this.precioPorAtencion = 0;
        }

        public FormAtenderCliente(ServicioPeluqueria servicio) : this()
        {
            this.servicio = servicio;
        }

        public ServicioPeluqueria Servicio { get { return this.servicio; } set { this.servicio = value; } }
        public decimal PrecioPorAtencion { get { return this.precioPorAtencion; } }

        private void FormAtenderCliente_Load(object sender, EventArgs e)
        {
            this.cmbTipoDeServicio.Items.Add("Corte");
            this.cmbTipoDeServicio.Items.Add("Planchado");
            this.cmbTipoDeServicio.Items.Add("Tintura");
            this.cmbTipoDeServicio.Items.Add("Corte y Planchado");
            this.cmbTipoDeServicio.Items.Add("Corte y Tintura");
            this.cmbTipoDeServicio.Items.Add("Planchado y Tintura");
            this.cmbTipoDeServicio.Items.Add("Todos");
            if (this.Servicio.ClienteAtendido is not null)
            {
                this.txtClienteAtendido.Text = this.Servicio.ClienteAtendido.ToString();
            }            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = this.Servicio.ClienteAtendido;

            if (cliente is not null)
            {
                try
                {
                    int index = this.cmbTipoDeServicio.SelectedIndex;
                    if (index != -1)
                    {
                        this.precioPorAtencion = this.servicio.AtenderCliente(this.servicio.ClienteAtendido, index);
                    }
                    else
                    {
                        MessageBox.Show($"Error, no has seleccionado ningún servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
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
            else
            {
                MessageBox.Show($"Error al atender, no se ha encontrado ningún cliente para la atención", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          

        }
    }
}
