
namespace CapaPresentacion.Forms
{
    partial class FormFuncion
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
            this.dataGridViewFunciones = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTiempo = new System.Windows.Forms.DateTimePicker();
            this.labelPrecioVenta = new System.Windows.Forms.Label();
            this.numericUpDownPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDuracion = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.comboBoxSalas = new System.Windows.Forms.ComboBox();
            this.labelIdSala = new System.Windows.Forms.Label();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.textBoxNombreDescripcion = new System.Windows.Forms.TextBox();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunciones)).BeginInit();
            this.groupBoxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.buttonEliminar);
            this.groupBoxDatos.Controls.Add(this.buttonEditar);
            this.groupBoxDatos.Controls.Add(this.dataGridViewFunciones);
            this.groupBoxDatos.Location = new System.Drawing.Point(426, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(915, 498);
            this.groupBoxDatos.TabIndex = 3;
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
            // dataGridViewFunciones
            // 
            this.dataGridViewFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunciones.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewFunciones.MultiSelect = false;
            this.dataGridViewFunciones.Name = "dataGridViewFunciones";
            this.dataGridViewFunciones.ReadOnly = true;
            this.dataGridViewFunciones.RowHeadersWidth = 51;
            this.dataGridViewFunciones.RowTemplate.Height = 24;
            this.dataGridViewFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFunciones.Size = new System.Drawing.Size(909, 406);
            this.dataGridViewFunciones.TabIndex = 0;
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.dateTimePickerTiempo);
            this.groupBoxRegistro.Controls.Add(this.labelPrecioVenta);
            this.groupBoxRegistro.Controls.Add(this.numericUpDownPrecioVenta);
            this.groupBoxRegistro.Controls.Add(this.numericUpDownDuracion);
            this.groupBoxRegistro.Controls.Add(this.dateTimePickerFecha);
            this.groupBoxRegistro.Controls.Add(this.buttonCancelar);
            this.groupBoxRegistro.Controls.Add(this.buttonGuardar);
            this.groupBoxRegistro.Controls.Add(this.labelDuracion);
            this.groupBoxRegistro.Controls.Add(this.labelUsuario);
            this.groupBoxRegistro.Controls.Add(this.comboBoxSalas);
            this.groupBoxRegistro.Controls.Add(this.labelIdSala);
            this.groupBoxRegistro.Controls.Add(this.labelNombreEmpleado);
            this.groupBoxRegistro.Controls.Add(this.textBoxGenero);
            this.groupBoxRegistro.Controls.Add(this.textBoxNombreDescripcion);
            this.groupBoxRegistro.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(393, 498);
            this.groupBoxRegistro.TabIndex = 2;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Rgistro";
            // 
            // dateTimePickerTiempo
            // 
            this.dateTimePickerTiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTiempo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerTiempo.Location = new System.Drawing.Point(26, 393);
            this.dateTimePickerTiempo.Name = "dateTimePickerTiempo";
            this.dateTimePickerTiempo.ShowUpDown = true;
            this.dateTimePickerTiempo.Size = new System.Drawing.Size(243, 22);
            this.dateTimePickerTiempo.TabIndex = 16;
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Location = new System.Drawing.Point(28, 274);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(91, 17);
            this.labelPrecioVenta.TabIndex = 14;
            this.labelPrecioVenta.Text = "Precio venta:";
            // 
            // numericUpDownPrecioVenta
            // 
            this.numericUpDownPrecioVenta.Location = new System.Drawing.Point(26, 294);
            this.numericUpDownPrecioVenta.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            this.numericUpDownPrecioVenta.Size = new System.Drawing.Size(243, 22);
            this.numericUpDownPrecioVenta.TabIndex = 13;
            // 
            // numericUpDownDuracion
            // 
            this.numericUpDownDuracion.Location = new System.Drawing.Point(26, 183);
            this.numericUpDownDuracion.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDuracion.Name = "numericUpDownDuracion";
            this.numericUpDownDuracion.Size = new System.Drawing.Size(243, 22);
            this.numericUpDownDuracion.TabIndex = 12;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(26, 346);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(243, 22);
            this.dateTimePickerFecha.TabIndex = 11;
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
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Location = new System.Drawing.Point(28, 163);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(142, 17);
            this.labelDuracion.TabIndex = 8;
            this.labelDuracion.Text = "Duracion en minutos:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(28, 219);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 17);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "Genero :";
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.Location = new System.Drawing.Point(26, 67);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(243, 24);
            this.comboBoxSalas.TabIndex = 6;
            this.comboBoxSalas.Text = "Sala";
            // 
            // labelIdSala
            // 
            this.labelIdSala.AutoSize = true;
            this.labelIdSala.Location = new System.Drawing.Point(23, 47);
            this.labelIdSala.Name = "labelIdSala";
            this.labelIdSala.Size = new System.Drawing.Size(40, 17);
            this.labelIdSala.TabIndex = 5;
            this.labelIdSala.Text = "Sala:";
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(23, 106);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(86, 17);
            this.labelNombreEmpleado.TabIndex = 4;
            this.labelNombreEmpleado.Text = "Descripcion:";
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(26, 239);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(243, 22);
            this.textBoxGenero.TabIndex = 1;
            // 
            // textBoxNombreDescripcion
            // 
            this.textBoxNombreDescripcion.Location = new System.Drawing.Point(26, 126);
            this.textBoxNombreDescripcion.Name = "textBoxNombreDescripcion";
            this.textBoxNombreDescripcion.Size = new System.Drawing.Size(243, 22);
            this.textBoxNombreDescripcion.TabIndex = 0;
            // 
            // FormFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 529);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxRegistro);
            this.Name = "FormFuncion";
            this.Text = "FormFuncion";
            this.groupBoxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunciones)).EndInit();
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridViewFunciones;
        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.ComboBox comboBoxSalas;
        private System.Windows.Forms.Label labelIdSala;
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.TextBox textBoxNombreDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.NumericUpDown numericUpDownDuracion;
        private System.Windows.Forms.Label labelPrecioVenta;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecioVenta;
        private System.Windows.Forms.DateTimePicker dateTimePickerTiempo;
    }
}