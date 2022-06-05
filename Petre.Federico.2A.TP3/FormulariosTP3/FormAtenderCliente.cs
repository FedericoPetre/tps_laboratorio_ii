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
        protected int indexTipoServicio;
        protected Cliente cliente;

        private FormAtenderCliente()
        {
            InitializeComponent();
            this.indexTipoServicio = 0;
        }

        public FormAtenderCliente(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }

        public int IndexTipoServicio { get { return this.indexTipoServicio; } set { this.indexTipoServicio = value; } }

        private void FormAtenderCliente_Load(object sender, EventArgs e)
        {
            this.cmbTipoDeServicio.Items.Add("Corte");
            this.cmbTipoDeServicio.Items.Add("Planchado");
            this.cmbTipoDeServicio.Items.Add("Tintura");
            this.cmbTipoDeServicio.Items.Add("Corte y Planchado");
            this.cmbTipoDeServicio.Items.Add("Corte y Tintura");
            this.cmbTipoDeServicio.Items.Add("Planchado y Tintura");
            this.cmbTipoDeServicio.Items.Add("Todos");

            if (this.cliente is not null)
            {
                this.richCliente.Text = this.cliente.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int index = this.cmbTipoDeServicio.SelectedIndex;
            if (index != -1)
            {
                this.IndexTipoServicio = index;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Error, no has seleccionado ningún servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
