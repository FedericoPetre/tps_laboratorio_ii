
namespace FormulariosTP3
{
    partial class FormModificarDatos
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
            this.cmbModificarDatos = new System.Windows.Forms.ComboBox();
            this.lblModificarDatos = new System.Windows.Forms.Label();
            this.bntModificar = new System.Windows.Forms.Button();
            this.txtDatoModificado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNuevoDato = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbModificarDatos
            // 
            this.cmbModificarDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModificarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbModificarDatos.FormattingEnabled = true;
            this.cmbModificarDatos.Location = new System.Drawing.Point(28, 60);
            this.cmbModificarDatos.Name = "cmbModificarDatos";
            this.cmbModificarDatos.Size = new System.Drawing.Size(241, 29);
            this.cmbModificarDatos.TabIndex = 0;
            // 
            // lblModificarDatos
            // 
            this.lblModificarDatos.AutoSize = true;
            this.lblModificarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModificarDatos.Location = new System.Drawing.Point(28, 26);
            this.lblModificarDatos.Name = "lblModificarDatos";
            this.lblModificarDatos.Size = new System.Drawing.Size(203, 21);
            this.lblModificarDatos.TabIndex = 1;
            this.lblModificarDatos.Text = "Seleccione dato a modificar:";
            // 
            // bntModificar
            // 
            this.bntModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntModificar.Location = new System.Drawing.Point(253, 250);
            this.bntModificar.Name = "bntModificar";
            this.bntModificar.Size = new System.Drawing.Size(172, 41);
            this.bntModificar.TabIndex = 2;
            this.bntModificar.Text = "Guardar Modificación";
            this.bntModificar.UseVisualStyleBackColor = true;
            this.bntModificar.Visible = false;
            this.bntModificar.Click += new System.EventHandler(this.bntModificar_Click);
            // 
            // txtDatoModificado
            // 
            this.txtDatoModificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatoModificado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatoModificado.Location = new System.Drawing.Point(28, 234);
            this.txtDatoModificado.Name = "txtDatoModificado";
            this.txtDatoModificado.Size = new System.Drawing.Size(185, 29);
            this.txtDatoModificado.TabIndex = 3;
            this.txtDatoModificado.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(238, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNuevoDato
            // 
            this.lblNuevoDato.AutoSize = true;
            this.lblNuevoDato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNuevoDato.Location = new System.Drawing.Point(28, 200);
            this.lblNuevoDato.Name = "lblNuevoDato";
            this.lblNuevoDato.Size = new System.Drawing.Size(96, 21);
            this.lblNuevoDato.TabIndex = 5;
            this.lblNuevoDato.Text = "Nuevo Dato:";
            this.lblNuevoDato.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(28, 112);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(172, 41);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormModificarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 316);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNuevoDato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDatoModificado);
            this.Controls.Add(this.bntModificar);
            this.Controls.Add(this.lblModificarDatos);
            this.Controls.Add(this.cmbModificarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModificarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de Datos";
            this.Load += new System.EventHandler(this.FormModificarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModificarDatos;
        private System.Windows.Forms.Label lblModificarDatos;
        private System.Windows.Forms.Button bntModificar;
        private System.Windows.Forms.TextBox txtDatoModificado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNuevoDato;
        private System.Windows.Forms.Button btnAceptar;
    }
}