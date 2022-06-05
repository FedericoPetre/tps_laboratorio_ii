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
    public partial class FormModificarDatos : Form
    {
        public Cliente cliente;

        public FormModificarDatos()
        {
            InitializeComponent();
        }

        private void FormModificarDatos_Load(object sender, EventArgs e)
        {
            this.cmbModificarDatos.Items.Add("Nombre");
            this.cmbModificarDatos.Items.Add("Edad");
            this.cmbModificarDatos.Items.Add("DNI");
            this.cmbModificarDatos.Items.Add("Número de Teléfono");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = this.cmbModificarDatos.SelectedIndex;
            int numeroTransformado = 0;

            try
            { 
                switch (indexSeleccionado)
                {
                    case 0:
                        Cliente.ModificarNombreCliente(this.cliente, this.txtDatoModificado.Text);
                        break;
                    case 1:
                        numeroTransformado = int.Parse(this.txtDatoModificado.Text);
                        Cliente.ModificarEdadCliente(this.cliente, numeroTransformado);
                        break;
                    case 2:
                        numeroTransformado = int.Parse(this.txtDatoModificado.Text);
                        Cliente.ModificarDniCliente(this.cliente, numeroTransformado);
                        break;
                    case 3:
                        numeroTransformado = int.Parse(this.txtDatoModificado.Text);
                        Cliente.ModificarTelefono(this.cliente, numeroTransformado);
                        break;
                    default:
                        MessageBox.Show("Error, no has seleccionado dato a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                DialogResult respuesta = MessageBox.Show("Los datos se han modificado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (respuesta == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (numeroDeTelefonoNoValidoException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EdadNoValidaException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error desconocido, por favor comprueba que el dato ingresado sea correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = this.cmbModificarDatos.SelectedIndex;

            switch (indexSeleccionado)
            {
                case 0:
                    this.lblNuevoDato.Text = "Ingrese nuevo nombre aquí :";
                    this.groupBoxModificacion.Visible = true;
                    break;
                case 1:
                    this.lblNuevoDato.Text = "Ingrese nueva edad aquí :";
                    this.groupBoxModificacion.Visible = true;
                    break;
                case 2:
                    this.lblNuevoDato.Text = "Ingrese nuevo dni aquí :";
                    this.groupBoxModificacion.Visible = true;
                    break;
                case 3:
                    this.lblNuevoDato.Text = "Ingrese nuevo teléfono aquí :";
                    this.groupBoxModificacion.Visible = true;
                    break;
                default:
                    MessageBox.Show("Error, no has seleccionado dato a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
