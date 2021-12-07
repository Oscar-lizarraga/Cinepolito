
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
            this.groupBoxDatos.Location = new System.Drawing.Point(320, 10);
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
            // dataGridViewFunciones
            // 
            this.dataGridViewFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunciones.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewFunciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFunciones.MultiSelect = false;
            this.dataGridViewFunciones.Name = "dataGridViewFunciones";
            this.dataGridViewFunciones.ReadOnly = true;
            this.dataGridViewFunciones.RowHeadersWidth = 51;
            this.dataGridViewFunciones.RowTemplate.Height = 24;
            this.dataGridViewFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFunciones.Size = new System.Drawing.Size(682, 330);
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
            this.groupBoxRegistro.Location = new System.Drawing.Point(9, 10);
            this.groupBoxRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRegistro.Size = new System.Drawing.Size(295, 405);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Rgistro";
            // 
            // dateTimePickerTiempo
            // 
            this.dateTimePickerTiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTiempo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerTiempo.Location = new System.Drawing.Point(20, 319);
            this.dateTimePickerTiempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerTiempo.Name = "dateTimePickerTiempo";
            this.dateTimePickerTiempo.ShowUpDown = true;
            this.dateTimePickerTiempo.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerTiempo.TabIndex = 6;
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Location = new System.Drawing.Point(21, 223);
            this.labelPrecioVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(70, 13);
            this.labelPrecioVenta.TabIndex = 13;
            this.labelPrecioVenta.Text = "Precio venta:";
            // 
            // numericUpDownPrecioVenta
            // 
            this.numericUpDownPrecioVenta.Location = new System.Drawing.Point(20, 239);
            this.numericUpDownPrecioVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPrecioVenta.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPrecioVenta.Name = "numericUpDownPrecioVenta";
            this.numericUpDownPrecioVenta.Size = new System.Drawing.Size(182, 20);
            this.numericUpDownPrecioVenta.TabIndex = 4;
            // 
            // numericUpDownDuracion
            // 
            this.numericUpDownDuracion.Location = new System.Drawing.Point(20, 149);
            this.numericUpDownDuracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownDuracion.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDuracion.Name = "numericUpDownDuracion";
            this.numericUpDownDuracion.Size = new System.Drawing.Size(182, 20);
            this.numericUpDownDuracion.TabIndex = 2;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(20, 281);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerFecha.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(121, 365);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(81, 35);
            this.buttonCancelar.TabIndex = 8;
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
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Location = new System.Drawing.Point(21, 132);
            this.labelDuracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(107, 13);
            this.labelDuracion.TabIndex = 11;
            this.labelDuracion.Text = "Duracion en minutos:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(21, 178);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(48, 13);
            this.labelUsuario.TabIndex = 12;
            this.labelUsuario.Text = "Genero :";
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.Location = new System.Drawing.Point(20, 54);
            this.comboBoxSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(183, 21);
            this.comboBoxSalas.TabIndex = 0;
            this.comboBoxSalas.Text = "Sala";
            // 
            // labelIdSala
            // 
            this.labelIdSala.AutoSize = true;
            this.labelIdSala.Location = new System.Drawing.Point(17, 38);
            this.labelIdSala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdSala.Name = "labelIdSala";
            this.labelIdSala.Size = new System.Drawing.Size(31, 13);
            this.labelIdSala.TabIndex = 9;
            this.labelIdSala.Text = "Sala:";
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(17, 86);
            this.labelNombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(66, 13);
            this.labelNombreEmpleado.TabIndex = 10;
            this.labelNombreEmpleado.Text = "Descripcion:";
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(20, 194);
            this.textBoxGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(183, 20);
            this.textBoxGenero.TabIndex = 3;
            // 
            // textBoxNombreDescripcion
            // 
            this.textBoxNombreDescripcion.Location = new System.Drawing.Point(20, 102);
            this.textBoxNombreDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreDescripcion.Name = "textBoxNombreDescripcion";
            this.textBoxNombreDescripcion.Size = new System.Drawing.Size(183, 20);
            this.textBoxNombreDescripcion.TabIndex = 1;
            // 
            // FormFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 430);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxRegistro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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