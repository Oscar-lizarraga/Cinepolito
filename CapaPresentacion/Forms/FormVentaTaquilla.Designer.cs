
namespace CapaPresentacion.Forms
{
    partial class FormVentaTaquilla
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
            this.comboBoxPelicula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.groupBoxBoleto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrecioPorBoleto = new System.Windows.Forms.TextBox();
            this.labelAsientosOcupados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelAsientos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.groupBoxBoleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPelicula
            // 
            this.comboBoxPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPelicula.FormattingEnabled = true;
            this.comboBoxPelicula.Location = new System.Drawing.Point(245, 68);
            this.comboBoxPelicula.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPelicula.Name = "comboBoxPelicula";
            this.comboBoxPelicula.Size = new System.Drawing.Size(117, 25);
            this.comboBoxPelicula.TabIndex = 1;
            this.comboBoxPelicula.SelectedIndexChanged += new System.EventHandler(this.comboBoxPelicula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pelicula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sala :";
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(245, 141);
            this.comboBoxSala.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(117, 25);
            this.comboBoxSala.TabIndex = 3;
            this.comboBoxSala.SelectedIndexChanged += new System.EventHandler(this.comboBoxSala_SelectedIndexChanged);
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Location = new System.Drawing.Point(245, 103);
            this.comboBoxHora.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(117, 25);
            this.comboBoxHora.TabIndex = 2;
            this.comboBoxHora.SelectedIndexChanged += new System.EventHandler(this.comboBoxHora_SelectedIndexChanged);
            // 
            // groupBoxBoleto
            // 
            this.groupBoxBoleto.BackColor = System.Drawing.Color.White;
            this.groupBoxBoleto.Controls.Add(this.label6);
            this.groupBoxBoleto.Controls.Add(this.textBoxPrecioPorBoleto);
            this.groupBoxBoleto.Controls.Add(this.labelAsientosOcupados);
            this.groupBoxBoleto.Controls.Add(this.label5);
            this.groupBoxBoleto.Controls.Add(this.labelDuracion);
            this.groupBoxBoleto.Controls.Add(this.label11);
            this.groupBoxBoleto.Controls.Add(this.dateTimePickerFecha);
            this.groupBoxBoleto.Controls.Add(this.label10);
            this.groupBoxBoleto.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxBoleto.Controls.Add(this.labelAsientos);
            this.groupBoxBoleto.Controls.Add(this.label8);
            this.groupBoxBoleto.Controls.Add(this.label4);
            this.groupBoxBoleto.Controls.Add(this.comboBoxPelicula);
            this.groupBoxBoleto.Controls.Add(this.label1);
            this.groupBoxBoleto.Controls.Add(this.comboBoxHora);
            this.groupBoxBoleto.Controls.Add(this.label2);
            this.groupBoxBoleto.Controls.Add(this.comboBoxSala);
            this.groupBoxBoleto.Controls.Add(this.label3);
            this.groupBoxBoleto.Location = new System.Drawing.Point(43, 37);
            this.groupBoxBoleto.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxBoleto.Name = "groupBoxBoleto";
            this.groupBoxBoleto.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxBoleto.Size = new System.Drawing.Size(753, 249);
            this.groupBoxBoleto.TabIndex = 0;
            this.groupBoxBoleto.TabStop = false;
            this.groupBoxBoleto.Text = "NuevoBoleto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio x boleto:";
            // 
            // textBoxPrecioPorBoleto
            // 
            this.textBoxPrecioPorBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecioPorBoleto.Location = new System.Drawing.Point(574, 142);
            this.textBoxPrecioPorBoleto.Name = "textBoxPrecioPorBoleto";
            this.textBoxPrecioPorBoleto.Size = new System.Drawing.Size(100, 24);
            this.textBoxPrecioPorBoleto.TabIndex = 17;
            // 
            // labelAsientosOcupados
            // 
            this.labelAsientosOcupados.AutoSize = true;
            this.labelAsientosOcupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsientosOcupados.Location = new System.Drawing.Point(571, 103);
            this.labelAsientosOcupados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsientosOcupados.Name = "labelAsientosOcupados";
            this.labelAsientosOcupados.Size = new System.Drawing.Size(17, 17);
            this.labelAsientosOcupados.TabIndex = 16;
            this.labelAsientosOcupados.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Asientos ocupados";
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracion.Location = new System.Drawing.Point(571, 38);
            this.labelDuracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(17, 17);
            this.labelDuracion.TabIndex = 14;
            this.labelDuracion.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(174, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Fecha :";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(245, 32);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(117, 23);
            this.dateTimePickerFecha.TabIndex = 0;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad de boletos :";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.Location = new System.Drawing.Point(245, 181);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(117, 23);
            this.numericUpDownCantidad.TabIndex = 4;
            // 
            // labelAsientos
            // 
            this.labelAsientos.AutoSize = true;
            this.labelAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsientos.Location = new System.Drawing.Point(571, 68);
            this.labelAsientos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsientos.Name = "labelAsientos";
            this.labelAsientos.Size = new System.Drawing.Size(17, 17);
            this.labelAsientos.TabIndex = 15;
            this.labelAsientos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Asientos en sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duracion:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(591, 300);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 40);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(493, 300);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(94, 40);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Cobrar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.Location = new System.Drawing.Point(689, 300);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(107, 40);
            this.buttonReportes.TabIndex = 4;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // FormVentaTaquilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 378);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBoxBoleto);
            this.Controls.Add(this.buttonAceptar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVentaTaquilla";
            this.Text = "VentaTaquilla";
            this.groupBoxBoleto.ResumeLayout(false);
            this.groupBoxBoleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.GroupBox groupBoxBoleto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelAsientos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Label labelAsientosOcupados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrecioPorBoleto;
    }
}