
namespace CapaPresentacion
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonVentaTaquilla = new System.Windows.Forms.Button();
            this.buttonFuncion = new System.Windows.Forms.Button();
            this.buttonArticulo = new System.Windows.Forms.Button();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.buttonVentaDulceria = new System.Windows.Forms.Button();
            this.buttonSala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVentaTaquilla
            // 
            this.buttonVentaTaquilla.BackColor = System.Drawing.Color.Wheat;
            this.buttonVentaTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentaTaquilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentaTaquilla.Location = new System.Drawing.Point(418, 126);
            this.buttonVentaTaquilla.Name = "buttonVentaTaquilla";
            this.buttonVentaTaquilla.Size = new System.Drawing.Size(184, 103);
            this.buttonVentaTaquilla.TabIndex = 0;
            this.buttonVentaTaquilla.Text = "Taquilla";
            this.buttonVentaTaquilla.UseVisualStyleBackColor = false;
            this.buttonVentaTaquilla.Click += new System.EventHandler(this.buttonVentaTaquilla_Click);
            // 
            // buttonFuncion
            // 
            this.buttonFuncion.BackColor = System.Drawing.Color.Aqua;
            this.buttonFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFuncion.Location = new System.Drawing.Point(706, 384);
            this.buttonFuncion.Name = "buttonFuncion";
            this.buttonFuncion.Size = new System.Drawing.Size(184, 103);
            this.buttonFuncion.TabIndex = 1;
            this.buttonFuncion.Text = "Funciones";
            this.buttonFuncion.UseVisualStyleBackColor = false;
            this.buttonFuncion.Click += new System.EventHandler(this.buttonFuncion_Click);
            // 
            // buttonArticulo
            // 
            this.buttonArticulo.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArticulo.Location = new System.Drawing.Point(140, 126);
            this.buttonArticulo.Name = "buttonArticulo";
            this.buttonArticulo.Size = new System.Drawing.Size(184, 103);
            this.buttonArticulo.TabIndex = 2;
            this.buttonArticulo.Text = "Articulos";
            this.buttonArticulo.UseVisualStyleBackColor = false;
            this.buttonArticulo.Click += new System.EventHandler(this.buttonArticulo_Click);
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.BackColor = System.Drawing.Color.Yellow;
            this.buttonEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleado.Location = new System.Drawing.Point(140, 384);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(184, 103);
            this.buttonEmpleado.TabIndex = 3;
            this.buttonEmpleado.Text = "Empleados";
            this.buttonEmpleado.UseVisualStyleBackColor = false;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // buttonVentaDulceria
            // 
            this.buttonVentaDulceria.BackColor = System.Drawing.Color.Coral;
            this.buttonVentaDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentaDulceria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentaDulceria.Location = new System.Drawing.Point(706, 126);
            this.buttonVentaDulceria.Name = "buttonVentaDulceria";
            this.buttonVentaDulceria.Size = new System.Drawing.Size(184, 103);
            this.buttonVentaDulceria.TabIndex = 4;
            this.buttonVentaDulceria.Text = "Dulceria";
            this.buttonVentaDulceria.UseVisualStyleBackColor = false;
            this.buttonVentaDulceria.Click += new System.EventHandler(this.buttonVentaDulceria_Click);
            // 
            // buttonSala
            // 
            this.buttonSala.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSala.Location = new System.Drawing.Point(418, 384);
            this.buttonSala.Name = "buttonSala";
            this.buttonSala.Size = new System.Drawing.Size(184, 103);
            this.buttonSala.TabIndex = 5;
            this.buttonSala.Text = "Salas";
            this.buttonSala.UseVisualStyleBackColor = false;
            this.buttonSala.Click += new System.EventHandler(this.buttonSala_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 598);
            this.Controls.Add(this.buttonVentaTaquilla);
            this.Controls.Add(this.buttonEmpleado);
            this.Controls.Add(this.buttonVentaDulceria);
            this.Controls.Add(this.buttonSala);
            this.Controls.Add(this.buttonFuncion);
            this.Controls.Add(this.buttonArticulo);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVentaTaquilla;
        private System.Windows.Forms.Button buttonFuncion;
        private System.Windows.Forms.Button buttonArticulo;
        private System.Windows.Forms.Button buttonEmpleado;
        private System.Windows.Forms.Button buttonVentaDulceria;
        private System.Windows.Forms.Button buttonSala;
    }
}