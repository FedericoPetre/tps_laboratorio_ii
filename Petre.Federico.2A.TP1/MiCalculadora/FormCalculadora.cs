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

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = -1;
            this.lblResultado.Text = "";
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
        }

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

            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            string resultadoString = resultado.ToString();
            this.lblResultado.Text = resultadoString;
            this.lstOperaciones.Items.Add($"{this.txtNumero1.Text} {this.cmbOperador.Text} {this.txtNumero2.Text} = {resultadoString}");            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = Operando.DecimalBinario(this.lblResultado.Text);
            this.lstOperaciones.Items.Add($"{resultado}");
            this.lblResultado.Text = resultado;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = Operando.BinarioDecimal(this.lblResultado.Text);
            this.lstOperaciones.Items.Add($"{resultado}");
            this.lblResultado.Text = resultado;
        }
    }
}
