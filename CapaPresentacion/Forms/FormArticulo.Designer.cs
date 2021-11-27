
namespace CapaPresentacion.Forms
{
    partial class FormArticulo
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
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.labelPrecioVenta = new System.Windows.Forms.Label();
            this.numericUpDownPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrecioProveedor = new System.Windows.Forms.NumericUpDown();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelPrecioProveedor = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombreCodigo = new System.Windows.Forms.TextBox();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.groupBoxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.buttonEliminar);
            this.groupBoxDatos.Controls.Add(this.buttonEditar);
            this.groupBoxDatos.Controls.Add(this.dataGridViewArticulos);
            this.groupBoxDatos.Location = new System.Drawing.Point(426, 27);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(915, 498);
            this.groupBoxDatos.TabIndex = 5;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(120, 449);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(108, 43);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(6, 449);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(108, 43);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewArticulos.MultiSelect = false;
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.ReadOnly = true;
            this.dataGridViewArticulos.RowHeadersWidth = 51;
            this.dataGridViewArticulos.RowTemplate.Height = 24;
            this.dataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulos.Size = new System.Drawing.Size(909, 406);
            this.dataGridViewArticulos.TabIndex = 0;
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.labelPrecioVenta);
            this.groupBoxRegistro.Controls.Add(this.numericUpDownPrecioVenta);
            this.groupBoxRegistro.Controls.Add(this.numericUpDownPrecioProveedor);
            this.groupBoxRegistro.Controls.Add(this.buttonCancelar);
            this.groupBoxRegistro.Controls.Add(this.buttonGuardar);
            this.groupBoxRegistro.Controls.Add(this.labelPrecioProveedor);
            this.groupBoxRegistro.Controls.Add(this.labelDescripcion);
            this.groupBoxRegistro.Controls.Add(this.labelCodigo);
            this.groupBoxRegistro.Controls.Add(this.textBoxDescripcion);
            this.groupBoxRegistro.Controls.Add(this.textBoxNombreCodigo);
            this.groupBoxRegistro.Location = new System.Drawing.Point(12, 27);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(393, 498);
            this.groupBoxRegistro.TabIndex = 4;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Rgistro";
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Location = new System.Drawing.Point(28, 251);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(91, 17);
            this.labelPrecioVenta.TabIndex = 14;
            this.labelPrecioVenta.Text = "Precio venta:";
            // 
            // numericUpDownPrecioVenta
            // 
            this.numericUpDownPrecioVenta.DecimalPlaces = 1;
            this.numericUpDownPrecioVenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPrecioVenta.Location = new System.Drawing.Point(26, 271);
            this.numericUpDownPrecioVenta.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            this.numericUpDownPrecioVenta.Size = new System.Drawing.Size(243, 22);
            this.numericUpDownPrecioVenta.TabIndex = 13;
            // 
            // numericUpDownPrecioProveedor
            // 
            this.numericUpDownPrecioProveedor.DecimalPlaces = 1;
            this.numericUpDownPrecioProveedor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPrecioProveedor.Location = new System.Drawing.Point(26, 200);
            this.numericUpDownPrecioProveedor.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPrecioProveedor.Name = "numericUpDownPrecioProveedor";
            this.numericUpDownPrecioProveedor.Size = new System.Drawing.Size(243, 22);
            this.numericUpDownPrecioProveedor.TabIndex = 12;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(161, 449);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 43);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(26, 449);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(108, 43);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelPrecioProveedor
            // 
            this.labelPrecioProveedor.AutoSize = true;
            this.labelPrecioProveedor.Location = new System.Drawing.Point(28, 180);
            this.labelPrecioProveedor.Name = "labelPrecioProveedor";
            this.labelPrecioProveedor.Size = new System.Drawing.Size(122, 17);
            this.labelPrecioProveedor.TabIndex = 8;
            this.labelPrecioProveedor.Text = "Precio Proveedor:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(28, 111);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(86, 17);
            this.labelDescripcion.TabIndex = 7;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(23, 50);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(60, 17);
            this.labelCodigo.TabIndex = 4;
            this.labelCodigo.Text = "Codigo: ";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(26, 131);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(243, 22);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // textBoxNombreCodigo
            // 
            this.textBoxNombreCodigo.Location = new System.Drawing.Point(26, 70);
            this.textBoxNombreCodigo.Name = "textBoxNombreCodigo";
            this.textBoxNombreCodigo.Size = new System.Drawing.Size(243, 22);
            this.textBoxNombreCodigo.TabIndex = 0;
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 552);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxRegistro);
            this.Name = "FormArticulo";
            this.Text = "FormArticulo";
            this.groupBoxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Label labelPrecioVenta;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelPrecioProveedor;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNombreCodigo;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecioVenta;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecioProveedor;
    }
}