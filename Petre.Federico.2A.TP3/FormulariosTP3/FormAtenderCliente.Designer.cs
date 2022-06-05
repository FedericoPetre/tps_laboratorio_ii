
namespace FormulariosTP3
{
    partial class FormAtenderCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClienteAtendido = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDeServicio = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.richCliente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblClienteAtendido
            // 
            this.lblClienteAtendido.AutoSize = true;
            this.lblClienteAtendido.Location = new System.Drawing.Point(12, 22);
            this.lblClienteAtendido.Name = "lblClienteAtendido";
            this.lblClienteAtendido.Size = new System.Drawing.Size(163, 21);
            this.lblClienteAtendido.TabIndex = 0;
            this.lblClienteAtendido.Text = "Cliente a ser atendido:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 249);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 44);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de servicio a recibir:";
            // 
            // cmbTipoDeServicio
            // 
            this.cmbTipoDeServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeServicio.FormattingEnabled = true;
            this.cmbTipoDeServicio.Location = new System.Drawing.Point(12, 194);
            this.cmbTipoDeServicio.Name = "cmbTipoDeServicio";
            this.cmbTipoDeServicio.Size = new System.Drawing.Size(294, 29);
            this.cmbTipoDeServicio.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(165, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // richCliente
            // 
            this.richCliente.Location = new System.Drawing.Point(12, 46);
            this.richCliente.MaxLength = 300;
            this.richCliente.Name = "richCliente";
            this.richCliente.ReadOnly = true;
            this.richCliente.Size = new System.Drawing.Size(294, 112);
            this.richCliente.TabIndex = 6;
            this.richCliente.Text = "";
            // 
            // FormAtenderCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 323);
            this.ControlBox = false;
            this.Controls.Add(this.richCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbTipoDeServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblClienteAtendido);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtenderCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atención al Cliente";
            this.Load += new System.EventHandler(this.FormAtenderCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienteAtendido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDeServicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox richCliente;
    }
}