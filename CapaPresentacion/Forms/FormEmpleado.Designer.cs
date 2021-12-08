
namespace CapaPresentacion.Forms
{
    partial class FormEmpleado
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
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelContrasenaVerificada = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.comboBoxRango = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.textBoxContrasenaVerificada = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistro.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.buttonCancelar);
            this.groupBoxRegistro.Controls.Add(this.buttonGuardar);
            this.groupBoxRegistro.Controls.Add(this.labelContrasenaVerificada);
            this.groupBoxRegistro.Controls.Add(this.labelContrasena);
            this.groupBoxRegistro.Controls.Add(this.labelUsuario);
            this.groupBoxRegistro.Controls.Add(this.comboBoxRango);
            this.groupBoxRegistro.Controls.Add(this.label1);
            this.groupBoxRegistro.Controls.Add(this.labelNombreEmpleado);
            this.groupBoxRegistro.Controls.Add(this.textBoxContrasenaVerificada);
            this.groupBoxRegistro.Controls.Add(this.textBoxContrasena);
            this.groupBoxRegistro.Controls.Add(this.textBoxUsuario);
            this.groupBoxRegistro.Controls.Add(this.textBoxNombreEmpleado);
            this.groupBoxRegistro.Location = new System.Drawing.Point(9, 10);
            this.groupBoxRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRegistro.Size = new System.Drawing.Size(295, 405);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Rgistro";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(121, 365);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(81, 35);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(20, 365);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(81, 35);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelContrasenaVerificada
            // 
            this.labelContrasenaVerificada.AutoSize = true;
            this.labelContrasenaVerificada.Location = new System.Drawing.Point(17, 182);
            this.labelContrasenaVerificada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasenaVerificada.Name = "labelContrasenaVerificada";
            this.labelContrasenaVerificada.Size = new System.Drawing.Size(110, 13);
            this.labelContrasenaVerificada.TabIndex = 11;
            this.labelContrasenaVerificada.Text = "Confirmar contraseña:";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(17, 145);
            this.labelContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(61, 13);
            this.labelContrasena.TabIndex = 10;
            this.labelContrasena.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(17, 109);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Usuario:";
            // 
            // comboBoxRango
            // 
            this.comboBoxRango.FormattingEnabled = true;
            this.comboBoxRango.Items.AddRange(new object[] {
            "General",
            "Supervisor",
            "Gerente"});
            this.comboBoxRango.Location = new System.Drawing.Point(20, 87);
            this.comboBoxRango.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRango.Name = "comboBoxRango";
            this.comboBoxRango.Size = new System.Drawing.Size(183, 21);
            this.comboBoxRango.TabIndex = 1;
            this.comboBoxRango.Text = "Rango";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nivel de acceso:";
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(17, 34);
            this.labelNombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(97, 13);
            this.labelNombreEmpleado.TabIndex = 7;
            this.labelNombreEmpleado.Text = "Nombre Empleado:";
            // 
            // textBoxContrasenaVerificada
            // 
            this.textBoxContrasenaVerificada.Location = new System.Drawing.Point(20, 198);
            this.textBoxContrasenaVerificada.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContrasenaVerificada.Name = "textBoxContrasenaVerificada";
            this.textBoxContrasenaVerificada.PasswordChar = '*';
            this.textBoxContrasenaVerificada.Size = new System.Drawing.Size(183, 20);
            this.textBoxContrasenaVerificada.TabIndex = 4;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(20, 162);
            this.textBoxContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(183, 20);
            this.textBoxContrasena.TabIndex = 3;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(20, 125);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(183, 20);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxNombreEmpleado
            // 
            this.textBoxNombreEmpleado.Location = new System.Drawing.Point(20, 50);
            this.textBoxNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
            this.textBoxNombreEmpleado.Size = new System.Drawing.Size(183, 20);
            this.textBoxNombreEmpleado.TabIndex = 0;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.buttonEliminar);
            this.groupBoxDatos.Controls.Add(this.buttonEditar);
            this.groupBoxDatos.Controls.Add(this.dataGridViewEmpleados);
            this.groupBoxDatos.Location = new System.Drawing.Point(320, 10);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDatos.Size = new System.Drawing.Size(686, 405);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(90, 365);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(81, 35);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmpleados.MultiSelect = false;
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.ReadOnly = true;
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(682, 330);
            this.dataGridViewEmpleados.TabIndex = 0;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 429);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxRegistro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            this.groupBoxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.ComboBox comboBoxRango;
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.TextBox textBoxContrasenaVerificada;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxNombreEmpleado;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Label labelContrasenaVerificada;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label label1;
    }
}