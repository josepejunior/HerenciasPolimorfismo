namespace pjVentaHeredada
{
    partial class frmPrincipal
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
            this.btnContado = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContado
            // 
            this.btnContado.Location = new System.Drawing.Point(240, 58);
            this.btnContado.Name = "btnContado";
            this.btnContado.Size = new System.Drawing.Size(155, 23);
            this.btnContado.TabIndex = 5;
            this.btnContado.Text = "VENTA AL CONTADO";
            this.btnContado.UseVisualStyleBackColor = true;
            this.btnContado.Click += new System.EventHandler(this.btnContado_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(34, 58);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(155, 23);
            this.btnCredito.TabIndex = 4;
            this.btnCredito.Text = "VENTA AL  CRÉDITO";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "VENTA DE PRODUCTOS";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 113);
            this.Controls.Add(this.btnContado);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Formulario principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnContado;
        private Button btnCredito;
        private Label label1;
    }
}