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
                this.peluqueria.ClientesNoAtendidos.Add(formCliente.cliente);
                this.cmbClientesSinAtender.Items.Add(formCliente.cliente.ATexto());
            }
            catch (Exception)
            {
                MessageBox.Show("Error desconocido, no se ha podido agregar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegistrarPrecios_Click(object sender, EventArgs e)
        {
            FormCargaDePrecios formCargaPrecios = new FormCargaDePrecios();

            formCargaPrecios.peluqueria = this.peluqueria;

            formCargaPrecios.ShowDialog();            
        }
    }
}
