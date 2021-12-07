
namespace CapaPresentacion.Forms
{
    partial class FormSala
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewSalas = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAsientos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxTipoSala = new System.Windows.Forms.ComboBox();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).BeginInit();
            this.groupBoxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.buttonEliminar);
            this.groupBoxDatos.Controls.Add(this.buttonEditar);
            this.groupBoxDatos.Controls.Add(this.dataGridViewSalas);
            this.groupBoxDatos.Location = new System.Drawing.Point(343, 19);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatos.Size = new System.Drawing.Size(686, 405);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(90, 365);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(81, 35);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(4, 365);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(81, 35);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridViewSalas
            // 
            this.dataGridViewSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalas.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSalas.MultiSelect = false;
            this.dataGridViewSalas.Name = "dataGridViewSalas";
            this.dataGridViewSalas.ReadOnly = true;
            this.dataGridViewSalas.RowHeadersWidth = 51;
            this.dataGridViewSalas.RowTemplate.Height = 24;
            this.dataGridViewSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalas.Size = new System.Drawing.Size(682, 330);
            this.dataGridViewSalas.TabIndex = 0;
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.label2);
            this.groupBoxRegistro.Controls.Add(this.numericUpDownAsientos);
            this.groupBoxRegistro.Controls.Add(this.label1);
            this.groupBoxRegistro.Controls.Add(this.buttonCancelar);
            this.groupBoxRegistro.Controls.Add(this.buttonGuardar);
            this.groupBoxRegistro.Controls.Add(this.comboBoxTipoSala);
            this.groupBoxRegistro.Location = new System.Drawing.Point(32, 19);
            this.groupBoxRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistro.Size = new System.Drawing.Size(295, 405);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Rgistro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de asientos";
            // 
            // numericUpDownAsientos
            // 
            this.numericUpDownAsientos.Location = new System.Drawing.Point(20, 119);
            this.numericUpDownAsientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownAsientos.Name = "numericUpDownAsientos";
            this.numericUpDownAsientos.Size = new System.Drawing.Size(182, 20);
            this.numericUpDownAsientos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de sala";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(121, 365);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(81, 35);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(20, 365);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(81, 35);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxTipoSala
            // 
            this.comboBoxTipoSala.FormattingEnabled = true;
            this.comboBoxTipoSala.Items.AddRange(new object[] {
            "Tradicional",
            "3D",
            "4DX",
            "IMAX",
            "PREMIUM"});
            this.comboBoxTipoSala.Location = new System.Drawing.Point(20, 52);
            this.comboBoxTipoSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTipoSala.Name = "comboBoxTipoSala";
            this.comboBoxTipoSala.Size = new System.Drawing.Size(183, 21);
            this.comboBoxTipoSala.TabIndex = 0;
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 455);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxRegistro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSala";
            this.Text = "FormSala";
            this.groupBoxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).EndInit();
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAsientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridViewSalas;
        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBoxTipoSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAsientos;
    }
}