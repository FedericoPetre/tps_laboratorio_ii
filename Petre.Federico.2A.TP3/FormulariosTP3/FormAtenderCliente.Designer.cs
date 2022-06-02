
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
            this.txtClienteAtendido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDeServicio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblClienteAtendido
            // 
            this.lblClienteAtendido.AutoSize = true;
            this.lblClienteAtendido.Location = new System.Drawing.Point(12, 50);
            this.lblClienteAtendido.Name = "lblClienteAtendido";
            this.lblClienteAtendido.Size = new System.Drawing.Size(163, 21);
            this.lblClienteAtendido.TabIndex = 0;
            this.lblClienteAtendido.Text = "Cliente a ser atendido:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(165, 255);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 44);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtClienteAtendido
            // 
            this.txtClienteAtendido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteAtendido.Location = new System.Drawing.Point(12, 83);
            this.txtClienteAtendido.Name = "txtClienteAtendido";
            this.txtClienteAtendido.ReadOnly = true;
            this.txtClienteAtendido.Size = new System.Drawing.Size(294, 29);
            this.txtClienteAtendido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de servicio a recibir:";
            // 
            // cmbTipoDeServicio
            // 
            this.cmbTipoDeServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeServicio.FormattingEnabled = true;
            this.cmbTipoDeServicio.Location = new System.Drawing.Point(12, 186);
            this.cmbTipoDeServicio.Name = "cmbTipoDeServicio";
            this.cmbTipoDeServicio.Size = new System.Drawing.Size(294, 29);
            this.cmbTipoDeServicio.TabIndex = 4;
            // 
            // FormAtenderCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 323);
            this.Controls.Add(this.cmbTipoDeServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClienteAtendido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblClienteAtendido);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtClienteAtendido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDeServicio;
    }
}