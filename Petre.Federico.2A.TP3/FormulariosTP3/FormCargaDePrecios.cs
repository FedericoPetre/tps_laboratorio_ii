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
    public partial class FormCargaDePrecios : Form
    {
        public Negocio<Cliente, ServicioPeluqueria> peluqueria;

        public FormCargaDePrecios()
        {
            InitializeComponent();
            this.peluqueria = new Negocio<Cliente, ServicioPeluqueria>();
        }

        private void btnRegistrarPrecios_Click(object sender, EventArgs e)
        {
            string precioCorteStr = this.txtPrecioCorte.Text;
            string precioPlanchadoStr = this.txtPrecioPlanchado.Text;
            string precioTinturaStr = this.txtPrecioTintura.Text;

            try
            {
                this.peluqueria.CargarPreciosPeluqueria(precioCorteStr, precioPlanchadoStr, precioTinturaStr);

                DialogResult respuesta = MessageBox.Show("Los precios se han sido registrado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (respuesta == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (PrecioNoValidoException)
            {
                MessageBox.Show("Error al cargar los precios de la peluquería", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          


        }
    }
}
