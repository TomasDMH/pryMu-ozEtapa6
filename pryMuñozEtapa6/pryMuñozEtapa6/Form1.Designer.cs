namespace pryMuñozEtapa6
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cmdMover = new System.Windows.Forms.Button();
            this.pctEspacio = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctEspacio)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(11, 230);
            this.cmdCrear.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(104, 56);
            this.cmdCrear.TabIndex = 0;
            this.cmdCrear.Text = "Crear Vehiculos";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // cmdMover
            // 
            this.cmdMover.Location = new System.Drawing.Point(317, 230);
            this.cmdMover.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMover.Name = "cmdMover";
            this.cmdMover.Size = new System.Drawing.Size(104, 56);
            this.cmdMover.TabIndex = 1;
            this.cmdMover.Text = "Mover Vehiculos";
            this.cmdMover.UseVisualStyleBackColor = true;
            this.cmdMover.Click += new System.EventHandler(this.button2_Click);
            // 
            // pctEspacio
            // 
            this.pctEspacio.Location = new System.Drawing.Point(11, 11);
            this.pctEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.pctEspacio.Name = "pctEspacio";
            this.pctEspacio.Size = new System.Drawing.Size(410, 212);
            this.pctEspacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEspacio.TabIndex = 2;
            this.pctEspacio.TabStop = false;
            this.pctEspacio.Click += new System.EventHandler(this.pctEspacio_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(120, 266);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(107, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 298);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.pctEspacio);
            this.Controls.Add(this.cmdMover);
            this.Controls.Add(this.cmdCrear);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Etapa 6";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctEspacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Button cmdMover;
        private System.Windows.Forms.PictureBox pctEspacio;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

