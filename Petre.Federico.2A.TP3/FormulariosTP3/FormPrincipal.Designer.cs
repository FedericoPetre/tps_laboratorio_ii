
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
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.btnMostrarPrecios = new System.Windows.Forms.Button();
            this.btnRegistrarPrecios = new System.Windows.Forms.Button();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.btnClientesNoAtendidos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnServiciosRealizados = new System.Windows.Forms.Button();
            this.groupClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCargarDatosClientes = new System.Windows.Forms.Button();
            this.btnGuardarDatosClientes = new System.Windows.Forms.Button();
            this.groupClientes.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGanancias
            // 
            this.txtGanancias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGanancias.Location = new System.Drawing.Point(12, 49);
            this.txtGanancias.Name = "txtGanancias";
            this.txtGanancias.ReadOnly = true;
            this.txtGanancias.Size = new System.Drawing.Size(250, 29);
            this.txtGanancias.TabIndex = 0;
            this.txtGanancias.Text = "$0";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGanancias.Location = new System.Drawing.Point(12, 25);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(81, 21);
            this.lblGanancias.TabIndex = 1;
            this.lblGanancias.Text = "Ganancias";
            // 
            // richTxtBoxInfo
            // 
            this.richTxtBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTxtBoxInfo.Location = new System.Drawing.Point(284, 26);
            this.richTxtBoxInfo.Name = "richTxtBoxInfo";
            this.richTxtBoxInfo.ReadOnly = true;
            this.richTxtBoxInfo.Size = new System.Drawing.Size(565, 263);
            this.richTxtBoxInfo.TabIndex = 2;
            this.richTxtBoxInfo.Text = "Aquí aparecerá la información del negocio.";
            // 
            // cmbClientesSinAtender
            // 
            this.cmbClientesSinAtender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesSinAtender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbClientesSinAtender.FormattingEnabled = true;
            this.cmbClientesSinAtender.Location = new System.Drawing.Point(6, 77);
            this.cmbClientesSinAtender.Name = "cmbClientesSinAtender";
            this.cmbClientesSinAtender.Size = new System.Drawing.Size(414, 25);
            this.cmbClientesSinAtender.TabIndex = 3;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCliente.Location = new System.Drawing.Point(141, 110);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(157, 35);
            this.btnModificarCliente.TabIndex = 5;
            this.btnModificarCliente.Text = "Modificar Datos";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtenderCliente.Location = new System.Drawing.Point(6, 110);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(129, 35);
            this.btnAtenderCliente.TabIndex = 6;
            this.btnAtenderCliente.Text = "Atender";
            this.btnAtenderCliente.UseVisualStyleBackColor = true;
            this.btnAtenderCliente.Click += new System.EventHandler(this.btnAtenderCliente_Click);
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarCliente.Location = new System.Drawing.Point(6, 22);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(414, 35);
            this.btnIngresarCliente.TabIndex = 7;
            this.btnIngresarCliente.Text = "Ingresar nuevo cliente";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // btnMostrarPrecios
            // 
            this.btnMostrarPrecios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarPrecios.Location = new System.Drawing.Point(6, 22);
            this.btnMostrarPrecios.Name = "btnMostrarPrecios";
            this.btnMostrarPrecios.Size = new System.Drawing.Size(238, 35);
            this.btnMostrarPrecios.TabIndex = 8;
            this.btnMostrarPrecios.Text = "Mostrar Precios";
            this.btnMostrarPrecios.UseVisualStyleBackColor = true;
            this.btnMostrarPrecios.Click += new System.EventHandler(this.btnMostrarPrecios_Click);
            // 
            // btnRegistrarPrecios
            // 
            this.btnRegistrarPrecios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPrecios.Location = new System.Drawing.Point(15, 24);
            this.btnRegistrarPrecios.Name = "btnRegistrarPrecios";
            this.btnRegistrarPrecios.Size = new System.Drawing.Size(185, 35);
            this.btnRegistrarPrecios.TabIndex = 9;
            this.btnRegistrarPrecios.Text = "Registrar Precios";
            this.btnRegistrarPrecios.UseVisualStyleBackColor = true;
            this.btnRegistrarPrecios.Click += new System.EventHandler(this.btnRegistrarPrecios_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGanancias.Location = new System.Drawing.Point(6, 145);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(238, 36);
            this.btnGanancias.TabIndex = 10;
            this.btnGanancias.Text = "Mostrar Ganancias";
            this.btnGanancias.UseVisualStyleBackColor = true;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDarDeBaja.Location = new System.Drawing.Point(304, 110);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(116, 35);
            this.btnDarDeBaja.TabIndex = 11;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // btnClientesNoAtendidos
            // 
            this.btnClientesNoAtendidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientesNoAtendidos.Location = new System.Drawing.Point(6, 63);
            this.btnClientesNoAtendidos.Name = "btnClientesNoAtendidos";
            this.btnClientesNoAtendidos.Size = new System.Drawing.Size(238, 35);
            this.btnClientesNoAtendidos.TabIndex = 12;
            this.btnClientesNoAtendidos.Text = "Mostrar Clientes No Atendidos";
            this.btnClientesNoAtendidos.UseVisualStyleBackColor = true;
            this.btnClientesNoAtendidos.Click += new System.EventHandler(this.btnClientesNoAtendidos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(205, 24);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(169, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnServiciosRealizados
            // 
            this.btnServiciosRealizados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServiciosRealizados.Location = new System.Drawing.Point(6, 104);
            this.btnServiciosRealizados.Name = "btnServiciosRealizados";
            this.btnServiciosRealizados.Size = new System.Drawing.Size(238, 35);
            this.btnServiciosRealizados.TabIndex = 14;
            this.btnServiciosRealizados.Text = "Mostrar Servicios Realizados";
            this.btnServiciosRealizados.UseVisualStyleBackColor = true;
            this.btnServiciosRealizados.Click += new System.EventHandler(this.btnServiciosRealizados_Click);
            // 
            // groupClientes
            // 
            this.groupClientes.Controls.Add(this.cmbClientesSinAtender);
            this.groupClientes.Controls.Add(this.btnIngresarCliente);
            this.groupClientes.Controls.Add(this.btnAtenderCliente);
            this.groupClientes.Controls.Add(this.btnModificarCliente);
            this.groupClientes.Controls.Add(this.btnDarDeBaja);
            this.groupClientes.Location = new System.Drawing.Point(12, 295);
            this.groupClientes.Name = "groupClientes";
            this.groupClientes.Size = new System.Drawing.Size(440, 154);
            this.groupClientes.TabIndex = 15;
            this.groupClientes.TabStop = false;
            this.groupClientes.Text = "Zona Clientes";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.btnMostrarPrecios);
            this.groupBoxInfo.Controls.Add(this.btnClientesNoAtendidos);
            this.groupBoxInfo.Controls.Add(this.btnServiciosRealizados);
            this.groupBoxInfo.Controls.Add(this.btnGanancias);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 87);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(250, 193);
            this.groupBoxInfo.TabIndex = 16;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Zona Información";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnCargarDatosClientes);
            this.groupBox1.Controls.Add(this.btnGuardarDatosClientes);
            this.groupBox1.Controls.Add(this.btnRegistrarPrecios);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(469, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 154);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zona control";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(15, 65);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(185, 35);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCargarDatosClientes
            // 
            this.btnCargarDatosClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarDatosClientes.Location = new System.Drawing.Point(205, 65);
            this.btnCargarDatosClientes.Name = "btnCargarDatosClientes";
            this.btnCargarDatosClientes.Size = new System.Drawing.Size(169, 35);
            this.btnCargarDatosClientes.TabIndex = 15;
            this.btnCargarDatosClientes.Text = "Cargar Datos Clientes";
            this.btnCargarDatosClientes.UseVisualStyleBackColor = true;
            this.btnCargarDatosClientes.Click += new System.EventHandler(this.btnCargarDatosClientes_Click);
            // 
            // btnGuardarDatosClientes
            // 
            this.btnGuardarDatosClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarDatosClientes.Location = new System.Drawing.Point(15, 106);
            this.btnGuardarDatosClientes.Name = "btnGuardarDatosClientes";
            this.btnGuardarDatosClientes.Size = new System.Drawing.Size(365, 35);
            this.btnGuardarDatosClientes.TabIndex = 14;
            this.btnGuardarDatosClientes.Text = "Guardar Datos Clientes";
            this.btnGuardarDatosClientes.UseVisualStyleBackColor = true;
            this.btnGuardarDatosClientes.Visible = false;
            this.btnGuardarDatosClientes.Click += new System.EventHandler(this.btnGuardarDatosClientes_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupClientes);
            this.Controls.Add(this.richTxtBoxInfo);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.txtGanancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petre.Federico.2A.TP3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.groupClientes.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGanancias;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.RichTextBox richTxtBoxInfo;
        private System.Windows.Forms.ComboBox cmbClientesSinAtender;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnAtenderCliente;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Button btnMostrarPrecios;
        private System.Windows.Forms.Button btnRegistrarPrecios;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Button btnClientesNoAtendidos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnServiciosRealizados;
        private System.Windows.Forms.GroupBox groupClientes;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarDatosClientes;
        private System.Windows.Forms.Button btnCargarDatosClientes;
        private System.Windows.Forms.Button btnCerrar;
    }
}

