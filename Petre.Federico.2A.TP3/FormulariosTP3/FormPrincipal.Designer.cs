﻿
namespace FormulariosTP3
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGanancias = new System.Windows.Forms.TextBox();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.richTxtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.cmbClientesSinAtender = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.btnMostrarInfoNegocio = new System.Windows.Forms.Button();
            this.btnRegistrarPrecios = new System.Windows.Forms.Button();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGanancias
            // 
            this.txtGanancias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGanancias.Location = new System.Drawing.Point(12, 52);
            this.txtGanancias.Name = "txtGanancias";
            this.txtGanancias.ReadOnly = true;
            this.txtGanancias.Size = new System.Drawing.Size(148, 29);
            this.txtGanancias.TabIndex = 0;
            this.txtGanancias.Text = "$0";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGanancias.Location = new System.Drawing.Point(12, 26);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(81, 21);
            this.lblGanancias.TabIndex = 1;
            this.lblGanancias.Text = "Ganancias";
            // 
            // richTxtBoxInfo
            // 
            this.richTxtBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtBoxInfo.Location = new System.Drawing.Point(405, 52);
            this.richTxtBoxInfo.Name = "richTxtBoxInfo";
            this.richTxtBoxInfo.ReadOnly = true;
            this.richTxtBoxInfo.Size = new System.Drawing.Size(293, 275);
            this.richTxtBoxInfo.TabIndex = 2;
            this.richTxtBoxInfo.Text = "Aquí aparecerá la información del negocio.";
            // 
            // cmbClientesSinAtender
            // 
            this.cmbClientesSinAtender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesSinAtender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbClientesSinAtender.FormattingEnabled = true;
            this.cmbClientesSinAtender.Location = new System.Drawing.Point(12, 257);
            this.cmbClientesSinAtender.Name = "cmbClientesSinAtender";
            this.cmbClientesSinAtender.Size = new System.Drawing.Size(273, 29);
            this.cmbClientesSinAtender.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(12, 224);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 21);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCliente.Location = new System.Drawing.Point(156, 292);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(129, 35);
            this.btnModificarCliente.TabIndex = 5;
            this.btnModificarCliente.Text = "Modificar Datos";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtenderCliente.Location = new System.Drawing.Point(12, 292);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(129, 35);
            this.btnAtenderCliente.TabIndex = 6;
            this.btnAtenderCliente.Text = "Atender";
            this.btnAtenderCliente.UseVisualStyleBackColor = true;
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarCliente.Location = new System.Drawing.Point(12, 162);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(194, 35);
            this.btnIngresarCliente.TabIndex = 7;
            this.btnIngresarCliente.Text = "Ingresar nuevo cliente";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // btnMostrarInfoNegocio
            // 
            this.btnMostrarInfoNegocio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarInfoNegocio.Location = new System.Drawing.Point(12, 110);
            this.btnMostrarInfoNegocio.Name = "btnMostrarInfoNegocio";
            this.btnMostrarInfoNegocio.Size = new System.Drawing.Size(194, 35);
            this.btnMostrarInfoNegocio.TabIndex = 8;
            this.btnMostrarInfoNegocio.Text = "Mostrar Información";
            this.btnMostrarInfoNegocio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPrecios
            // 
            this.btnRegistrarPrecios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPrecios.Location = new System.Drawing.Point(228, 110);
            this.btnRegistrarPrecios.Name = "btnRegistrarPrecios";
            this.btnRegistrarPrecios.Size = new System.Drawing.Size(161, 35);
            this.btnRegistrarPrecios.TabIndex = 9;
            this.btnRegistrarPrecios.Text = "Registrar Precios";
            this.btnRegistrarPrecios.UseVisualStyleBackColor = true;
            this.btnRegistrarPrecios.Click += new System.EventHandler(this.btnRegistrarPrecios_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGanancias.Location = new System.Drawing.Point(228, 162);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(161, 35);
            this.btnGanancias.TabIndex = 10;
            this.btnGanancias.Text = "Mostrar Ganancias";
            this.btnGanancias.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 354);
            this.Controls.Add(this.btnGanancias);
            this.Controls.Add(this.btnRegistrarPrecios);
            this.Controls.Add(this.btnMostrarInfoNegocio);
            this.Controls.Add(this.btnIngresarCliente);
            this.Controls.Add(this.btnAtenderCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbClientesSinAtender);
            this.Controls.Add(this.richTxtBoxInfo);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.txtGanancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petre.Federico.2A.TP3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGanancias;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.RichTextBox richTxtBoxInfo;
        private System.Windows.Forms.ComboBox cmbClientesSinAtender;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnAtenderCliente;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Button btnMostrarInfoNegocio;
        private System.Windows.Forms.Button btnRegistrarPrecios;
        private System.Windows.Forms.Button btnGanancias;
    }
}
