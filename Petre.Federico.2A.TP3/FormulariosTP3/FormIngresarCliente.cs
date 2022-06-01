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
    public partial class FormIngresarCliente : Form
    {
        public Cliente cliente;

        public FormIngresarCliente()
        {
            InitializeComponent();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string edadStr = this.txtEdad.Text;
            string dniStr= this.txtDni.Text;
            string numeroTelefonoStr = this.txtTelefono.Text;
            bool flagEdad;
            bool flagDni;
            bool flagNumeroTelefono;

            try
            {

                flagEdad = int.TryParse(edadStr, out int edad);
                flagDni = int.TryParse(dniStr, out int dni);
                flagNumeroTelefono = int.TryParse(numeroTelefonoStr, out int numeroTelefono);

                if (flagEdad && flagDni && flagNumeroTelefono)
                {
                    this.cliente = new Cliente(nombre, edad, dni, numeroTelefono);

                    DialogResult respuesta = MessageBox.Show("Los datos han sido registrados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error al ingresar alguno de los datos, por favor verifique que la edad, dni y número de teléfono ingresados sean números sin punto ni coma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (EdadNoValidaException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (numeroDeTelefonoNoValidoException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Se ha producido un error desconocido, por favor verifique que los datos ingresados sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
