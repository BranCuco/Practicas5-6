namespace DevolucionMinimaMonedas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.btnCalcularDevolucion = new System.Windows.Forms.Button();
            this.btnResolverTorres = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.lblDiscos = new System.Windows.Forms.Label();
            this.txtDiscos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 15);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(95, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad a Pagar:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(12, 43);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(71, 13);
            this.lblPago.TabIndex = 1;
            this.lblPago.Text = "Pago con ($):";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(113, 12);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(113, 40);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 3;
            // 
            // btnCalcularDevolucion
            // 
            this.btnCalcularDevolucion.Location = new System.Drawing.Point(15, 98);
            this.btnCalcularDevolucion.Name = "btnCalcularDevolucion";
            this.btnCalcularDevolucion.Size = new System.Drawing.Size(198, 23);
            this.btnCalcularDevolucion.TabIndex = 4;
            this.btnCalcularDevolucion.Text = "Calcular Devolución";
            this.btnCalcularDevolucion.UseVisualStyleBackColor = true;
            this.btnCalcularDevolucion.Click += new System.EventHandler(this.btnCalcularDevolucion_Click);
            // 
            // btnResolverTorres
            // 
            this.btnResolverTorres.Location = new System.Drawing.Point(15, 127);
            this.btnResolverTorres.Name = "btnResolverTorres";
            this.btnResolverTorres.Size = new System.Drawing.Size(198, 23);
            this.btnResolverTorres.TabIndex = 8;
            this.btnResolverTorres.Text = "Resolver Torres de Hanói";
            this.btnResolverTorres.UseVisualStyleBackColor = true;
            this.btnResolverTorres.Click += new System.EventHandler(this.btnResolverTorres_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(15, 160);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResultados.Size = new System.Drawing.Size(200, 500);
            this.txtResultados.TabIndex = 9;
            // 
            // lblDiscos
            // 
            this.lblDiscos.AutoSize = true;
            this.lblDiscos.Location = new System.Drawing.Point(12, 68);
            this.lblDiscos.Name = "lblDiscos";
            this.lblDiscos.Size = new System.Drawing.Size(75, 13);
            this.lblDiscos.TabIndex = 6;
            this.lblDiscos.Text = "Número Discos:";
            // 
            // txtDiscos
            // 
            this.txtDiscos.Location = new System.Drawing.Point(113, 65);
            this.txtDiscos.Name = "txtDiscos";
            this.txtDiscos.Size = new System.Drawing.Size(100, 20);
            this.txtDiscos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(250, 800);
            this.Controls.Add(this.txtDiscos);
            this.Controls.Add(this.lblDiscos);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnResolverTorres);
            this.Controls.Add(this.btnCalcularDevolucion);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución de Monedas y Torres de Hanói";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnCalcularDevolucion;
        private System.Windows.Forms.Button btnResolverTorres;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label lblDiscos;
        private System.Windows.Forms.TextBox txtDiscos;
    }
}
