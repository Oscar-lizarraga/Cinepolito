
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
            this.groupBoxDatos.Location = new System.Drawing.Point(320, 22);
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
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewArticulos.MultiSelect = false;
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.ReadOnly = true;
            this.dataGridViewArticulos.RowHeadersWidth = 51;
            this.dataGridViewArticulos.RowTemplate.Height = 24;
            this.dataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulos.Size = new System.Drawing.Size(682, 330);
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
            this.groupBoxRegistro.Location = new System.Drawing.Point(9, 22);
            this.groupBoxRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistro.Size = new System.Drawing.Size(295, 405);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Rgistro";
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Location = new System.Drawing.Point(21, 204);
            this.labelPrecioVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(70, 13);
            this.labelPrecioVenta.TabIndex = 9;
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
            this.numericUpDownPrecioVenta.Location = new System.Drawing.Point(20, 220);
            this.numericUpDownPrecioVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPrecioVenta.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            this.numericUpDownPrecioVenta.Size = new System.Drawing.Size(182, 20);
            this.numericUpDownPrecioVenta.TabIndex = 3;
            // 
            // numericUpDownPrecioProveedor
            // 
            this.numericUpDownPrecioProveedor.DecimalPlaces = 1;
            this.numericUpDownPrecioProveedor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPrecioProveedor.Location = new System.Drawing.Point(20, 162);
            this.numericUpDownPrecioProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPrecioProveedor.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPrecioProveedor.Name = "numericUpDownPrecioProveedor";
            this.numericUpDownPrecioProveedor.Size = new System.Drawing.Size(182, 20);
            this.numericUpDownPrecioProveedor.TabIndex = 2;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(121, 365);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(81, 35);
            this.buttonCancelar.TabIndex = 5;
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
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelPrecioProveedor
            // 
            this.labelPrecioProveedor.AutoSize = true;
            this.labelPrecioProveedor.Location = new System.Drawing.Point(21, 146);
            this.labelPrecioProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecioProveedor.Name = "labelPrecioProveedor";
            this.labelPrecioProveedor.Size = new System.Drawing.Size(92, 13);
            this.labelPrecioProveedor.TabIndex = 8;
            this.labelPrecioProveedor.Text = "Precio Proveedor:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(21, 90);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 7;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(17, 41);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(46, 13);
            this.labelCodigo.TabIndex = 6;
            this.labelCodigo.Text = "Codigo: ";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(20, 106);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(183, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // textBoxNombreCodigo
            // 
            this.textBoxNombreCodigo.Location = new System.Drawing.Point(20, 57);
            this.textBoxNombreCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreCodigo.Name = "textBoxNombreCodigo";
            this.textBoxNombreCodigo.Size = new System.Drawing.Size(183, 20);
            this.textBoxNombreCodigo.TabIndex = 0;
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 448);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxRegistro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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