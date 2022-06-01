
namespace FormulariosTP3
{
    partial class FormCargaDePrecios
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
            this.lblCargaPrecios = new System.Windows.Forms.Label();
            this.lblPrecioCorte = new System.Windows.Forms.Label();
            this.lblPrecioPlanchado = new System.Windows.Forms.Label();
            this.lblPrecioTintura = new System.Windows.Forms.Label();
            this.txtPrecioCorte = new System.Windows.Forms.TextBox();
            this.txtPrecioPlanchado = new System.Windows.Forms.TextBox();
            this.txtPrecioTintura = new System.Windows.Forms.TextBox();
            this.btnRegistrarPrecios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCargaPrecios
            // 
            this.lblCargaPrecios.AutoSize = true;
            this.lblCargaPrecios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargaPrecios.Location = new System.Drawing.Point(93, 24);
            this.lblCargaPrecios.Name = "lblCargaPrecios";
            this.lblCargaPrecios.Size = new System.Drawing.Size(126, 21);
            this.lblCargaPrecios.TabIndex = 0;
            this.lblCargaPrecios.Text = "Carga de Precios";
            // 
            // lblPrecioCorte
            // 
            this.lblPrecioCorte.AutoSize = true;
            this.lblPrecioCorte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioCorte.Location = new System.Drawing.Point(12, 71);
            this.lblPrecioCorte.Name = "lblPrecioCorte";
            this.lblPrecioCorte.Size = new System.Drawing.Size(120, 21);
            this.lblPrecioCorte.TabIndex = 1;
            this.lblPrecioCorte.Text = "Precio del Corte";
            // 
            // lblPrecioPlanchado
            // 
            this.lblPrecioPlanchado.AutoSize = true;
            this.lblPrecioPlanchado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioPlanchado.Location = new System.Drawing.Point(12, 140);
            this.lblPrecioPlanchado.Name = "lblPrecioPlanchado";
            this.lblPrecioPlanchado.Size = new System.Drawing.Size(154, 21);
            this.lblPrecioPlanchado.TabIndex = 2;
            this.lblPrecioPlanchado.Text = "Precio del Planchado";
            // 
            // lblPrecioTintura
            // 
            this.lblPrecioTintura.AutoSize = true;
            this.lblPrecioTintura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTintura.Location = new System.Drawing.Point(12, 208);
            this.lblPrecioTintura.Name = "lblPrecioTintura";
            this.lblPrecioTintura.Size = new System.Drawing.Size(143, 21);
            this.lblPrecioTintura.TabIndex = 3;
            this.lblPrecioTintura.Text = "Precio de la Tintura";
            // 
            // txtPrecioCorte
            // 
            this.txtPrecioCorte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCorte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioCorte.Location = new System.Drawing.Point(12, 95);
            this.txtPrecioCorte.Name = "txtPrecioCorte";
            this.txtPrecioCorte.Size = new System.Drawing.Size(154, 29);
            this.txtPrecioCorte.TabIndex = 4;
            // 
            // txtPrecioPlanchado
            // 
            this.txtPrecioPlanchado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioPlanchado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioPlanchado.Location = new System.Drawing.Point(12, 164);
            this.txtPrecioPlanchado.Name = "txtPrecioPlanchado";
            this.txtPrecioPlanchado.Size = new System.Drawing.Size(154, 29);
            this.txtPrecioPlanchado.TabIndex = 5;
            // 
            // txtPrecioTintura
            // 
            this.txtPrecioTintura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioTintura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioTintura.Location = new System.Drawing.Point(12, 232);
            this.txtPrecioTintura.Name = "txtPrecioTintura";
            this.txtPrecioTintura.Size = new System.Drawing.Size(154, 29);
            this.txtPrecioTintura.TabIndex = 6;
            // 
            // btnRegistrarPrecios
            // 
            this.btnRegistrarPrecios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPrecios.Location = new System.Drawing.Point(164, 284);
            this.btnRegistrarPrecios.Name = "btnRegistrarPrecios";
            this.btnRegistrarPrecios.Size = new System.Drawing.Size(147, 44);
            this.btnRegistrarPrecios.TabIndex = 7;
            this.btnRegistrarPrecios.Text = "Registrar Precios";
            this.btnRegistrarPrecios.UseVisualStyleBackColor = true;
            this.btnRegistrarPrecios.Click += new System.EventHandler(this.btnRegistrarPrecios_Click);
            // 
            // FormCargaDePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 354);
            this.Controls.Add(this.btnRegistrarPrecios);
            this.Controls.Add(this.txtPrecioTintura);
            this.Controls.Add(this.txtPrecioPlanchado);
            this.Controls.Add(this.txtPrecioCorte);
            this.Controls.Add(this.lblPrecioTintura);
            this.Controls.Add(this.lblPrecioPlanchado);
            this.Controls.Add(this.lblPrecioCorte);
            this.Controls.Add(this.lblCargaPrecios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaDePrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargaPrecios;
        private System.Windows.Forms.Label lblPrecioCorte;
        private System.Windows.Forms.Label lblPrecioPlanchado;
        private System.Windows.Forms.Label lblPrecioTintura;
        private System.Windows.Forms.TextBox txtPrecioCorte;
        private System.Windows.Forms.TextBox txtPrecioPlanchado;
        private System.Windows.Forms.TextBox txtPrecioTintura;
        private System.Windows.Forms.Button btnRegistrarPrecios;
    }
}