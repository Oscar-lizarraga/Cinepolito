
namespace CapaPresentacion.Forms
{
    partial class FormVentaCobrarBoleto
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelTotalVenta = new System.Windows.Forms.Label();
            this.radioButtonTarjeta = new System.Windows.Forms.RadioButton();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRecibio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecibio)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(128, 267);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 36);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Olive;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(20, 267);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(88, 36);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click_1);
            // 
            // labelTotalVenta
            // 
            this.labelTotalVenta.AutoSize = true;
            this.labelTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVenta.Location = new System.Drawing.Point(143, 31);
            this.labelTotalVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalVenta.Name = "labelTotalVenta";
            this.labelTotalVenta.Size = new System.Drawing.Size(45, 29);
            this.labelTotalVenta.TabIndex = 7;
            this.labelTotalVenta.Text = "0.0";
            // 
            // radioButtonTarjeta
            // 
            this.radioButtonTarjeta.AutoSize = true;
            this.radioButtonTarjeta.Location = new System.Drawing.Point(94, 106);
            this.radioButtonTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTarjeta.Name = "radioButtonTarjeta";
            this.radioButtonTarjeta.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTarjeta.TabIndex = 1;
            this.radioButtonTarjeta.Text = "Tarjeta";
            this.radioButtonTarjeta.UseVisualStyleBackColor = true;
            this.radioButtonTarjeta.CheckedChanged += new System.EventHandler(this.radioButtonTarjeta_CheckedChanged);
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Checked = true;
            this.radioButtonEfectivo.Location = new System.Drawing.Point(20, 106);
            this.radioButtonEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(64, 17);
            this.radioButtonEfectivo.TabIndex = 0;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            this.radioButtonEfectivo.CheckedChanged += new System.EventHandler(this.radioButtonEfectivo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cambio";
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.Location = new System.Drawing.Point(20, 223);
            this.textBoxCambio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.Size = new System.Drawing.Size(168, 28);
            this.textBoxCambio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Recibio";
            // 
            // numericUpDownRecibio
            // 
            this.numericUpDownRecibio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRecibio.Location = new System.Drawing.Point(20, 163);
            this.numericUpDownRecibio.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRecibio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRecibio.Name = "numericUpDownRecibio";
            this.numericUpDownRecibio.Size = new System.Drawing.Size(166, 28);
            this.numericUpDownRecibio.TabIndex = 2;
            this.numericUpDownRecibio.ValueChanged += new System.EventHandler(this.numericUpDownRecibio_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Forma de pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // FormVentaCobrarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 334);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelTotalVenta);
            this.Controls.Add(this.radioButtonTarjeta);
            this.Controls.Add(this.radioButtonEfectivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCambio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownRecibio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVentaCobrarBoleto";
            this.Text = "FormVentaCobrarBoleto";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecibio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelTotalVenta;
        private System.Windows.Forms.RadioButton radioButtonTarjeta;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRecibio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}