namespace ZooManagement
{
    partial class Form1
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
            this.cmbTipoAnimal = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstAnimales = new System.Windows.Forms.ListBox();
            this.btnSonido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoAnimal
            // 
            this.cmbTipoAnimal.FormattingEnabled = true;
            this.cmbTipoAnimal.Location = new System.Drawing.Point(57, 95);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(129, 21);
            this.cmbTipoAnimal.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(57, 232);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(129, 20);
            this.txtEdad.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(80, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstAnimales
            // 
            this.lstAnimales.FormattingEnabled = true;
            this.lstAnimales.Location = new System.Drawing.Point(466, 30);
            this.lstAnimales.Name = "lstAnimales";
            this.lstAnimales.Size = new System.Drawing.Size(301, 290);
            this.lstAnimales.TabIndex = 4;
            // 
            // btnSonido
            // 
            this.btnSonido.Location = new System.Drawing.Point(299, 163);
            this.btnSonido.Name = "btnSonido";
            this.btnSonido.Size = new System.Drawing.Size(75, 23);
            this.btnSonido.TabIndex = 5;
            this.btnSonido.Text = "Sonido";
            this.btnSonido.UseVisualStyleBackColor = true;
            this.btnSonido.Click += new System.EventHandler(this.btnSonido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSonido);
            this.Controls.Add(this.lstAnimales);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cmbTipoAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoAnimal;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstAnimales;
        private System.Windows.Forms.Button btnSonido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

