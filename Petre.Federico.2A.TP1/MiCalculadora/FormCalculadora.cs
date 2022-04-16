using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento FormClosing, al intentar cerrar el formulario, aparecera un MessageBox : Seguro que desea salir?, con opciones SI y NO.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Al hacer click en el boton cerrar, se ejecuta el evento FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al hacer click en el botón limpiar, se ejecuta el método limpiar, el cual limpia los textBoxs, comboBox y label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia el contenido de los textBoxs y label; y el comboBox queda en opción sin seleccionar
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = -1;
            this.lblResultado.Text = "";
        }

        /// <summary>
        /// Evento Load del Formulario, se crea, se limpia y agrega opciones al comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
        }

        /// <summary>
        /// Método operar del Forms. Se invoca al método Operar de Calculadora.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operando"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operando)
        {
            double resultado=0;

           char operandoChar = char.Parse(operando);
            
            Operando num1 = new Operando();
            Operando num2 = new Operando();

            num1.Numero = numero1;
            num2.Numero = numero2;


            resultado = Calculadora.Operar(num1, num2, operandoChar);            

            return resultado;
        }

        /// <summary>
        /// Al hacer click en operar, se invoca al método Operar del Form, validando que: Si el usuario no eligio opcion en el comboBox, sea la opcio del + por defecto. Los txtBoxs reemplazan la , por el . para no confundir al usuario en decimales. Y si se ingresó texto, sea reemplazado por 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            
            if (this.cmbOperador.SelectedIndex == -1)
            {
                this.cmbOperador.SelectedIndex = 0;
            }

            if (string.IsNullOrEmpty(this.txtNumero1.Text))
            {
                this.txtNumero1.Text = "0";
            }

            if (string.IsNullOrEmpty(this.txtNumero2.Text))
            {
                this.txtNumero2.Text = "0";
            }


            if (this.txtNumero1.Text.Contains('.'))
            {
                this.txtNumero1.Text = this.txtNumero1.Text.Replace('.', ',');
            }

            if (this.txtNumero2.Text.Contains('.'))
            {
                this.txtNumero2.Text = this.txtNumero2.Text.Replace('.', ',');
            }

            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            string resultadoString = resultado.ToString();
            this.lblResultado.Text = resultadoString;
            this.lstOperaciones.Items.Add($"{this.txtNumero1.Text} {this.cmbOperador.Text} {this.txtNumero2.Text} = {resultadoString}");            
        }

        /// <summary>
        /// Al hacer click en ConvertirABinario, se invoca al método DecimalBinario de Operando para realizar la conversión del último resultado guardado en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando nuevoOperando = new Operando();

            string resultado = nuevoOperando.DecimalBinario(this.lblResultado.Text);
            this.lstOperaciones.Items.Add($"{resultado}");
            this.lblResultado.Text = resultado;
        }

        /// <summary>
        /// Al hacer click en el botón ConvertirADecimal, se invoca al método DecimalBinario de Operando para realizar la conversión del último resultado guardado en el label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando nuevoOperando = new Operando();

            string resultado = nuevoOperando.BinarioDecimal(this.lblResultado.Text);
            this.lstOperaciones.Items.Add($"{resultado}");
            this.lblResultado.Text = resultado;
        }
    }
}
