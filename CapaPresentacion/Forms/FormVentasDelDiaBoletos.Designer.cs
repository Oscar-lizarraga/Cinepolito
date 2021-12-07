
namespace CapaPresentacion.Forms
{
    partial class FormVentasDelDiaBoletos
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.labelVentasTotales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(692, 7);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(142, 19);
            this.buttonBuscar.TabIndex = 25;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha Final";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Entre fechas";
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(506, 8);
            this.dateTimePickerFechaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaFinal.TabIndex = 21;
            // 
            // dateTimePickerFechaInicial
            // 
            this.dateTimePickerFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicial.Location = new System.Drawing.Point(238, 9);
            this.dateTimePickerFechaInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechaInicial.Name = "dateTimePickerFechaInicial";
            this.dateTimePickerFechaInicial.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaInicial.TabIndex = 20;
            // 
            // labelVentasTotales
            // 
            this.labelVentasTotales.AutoSize = true;
            this.labelVentasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentasTotales.Location = new System.Drawing.Point(823, 367);
            this.labelVentasTotales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVentasTotales.Name = "labelVentasTotales";
            this.labelVentasTotales.Size = new System.Drawing.Size(31, 17);
            this.labelVentasTotales.TabIndex = 15;
            this.labelVentasTotales.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ventas totales";
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(17, 39);
            this.dataGridViewVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.RowHeadersWidth = 51;
            this.dataGridViewVentas.RowTemplate.Height = 24;
            this.dataGridViewVentas.Size = new System.Drawing.Size(840, 317);
            this.dataGridViewVentas.TabIndex = 13;
            // 
            // FormVentasDelDiaBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 415);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerFechaFinal);
            this.Controls.Add(this.dateTimePickerFechaInicial);
            this.Controls.Add(this.labelVentasTotales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVentas);
            this.Name = "FormVentasDelDiaBoletos";
            this.Text = "FormVentasDelDiaBoletos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicial;
        private System.Windows.Forms.Label labelVentasTotales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
    }
}