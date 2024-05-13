namespace intento1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoCarne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCarneactual = new System.Windows.Forms.TextBox();
            this.bottonqr = new System.Windows.Forms.Button();
            this.TxtNuevoCarne = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxqr = new System.Windows.Forms.PictureBox();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxqr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCarne
            // 
            this.btnNuevoCarne.Location = new System.Drawing.Point(182, 232);
            this.btnNuevoCarne.Name = "btnNuevoCarne";
            this.btnNuevoCarne.Size = new System.Drawing.Size(227, 23);
            this.btnNuevoCarne.TabIndex = 0;
            this.btnNuevoCarne.Text = "Nuevo número de carné:";
            this.btnNuevoCarne.UseVisualStyleBackColor = true;
            this.btnNuevoCarne.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el numero de carne actual:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carrera:";
            // 
            // TxtCarneactual
            // 
            this.TxtCarneactual.Location = new System.Drawing.Point(570, 38);
            this.TxtCarneactual.Name = "TxtCarneactual";
            this.TxtCarneactual.Size = new System.Drawing.Size(190, 22);
            this.TxtCarneactual.TabIndex = 4;
            // 
            // bottonqr
            // 
            this.bottonqr.Location = new System.Drawing.Point(166, 344);
            this.bottonqr.Name = "bottonqr";
            this.bottonqr.Size = new System.Drawing.Size(117, 23);
            this.bottonqr.TabIndex = 7;
            this.bottonqr.Text = "Codigo QR";
            this.bottonqr.UseVisualStyleBackColor = true;
            this.bottonqr.Click += new System.EventHandler(this.bottonqr_Click);
            // 
            // TxtNuevoCarne
            // 
            this.TxtNuevoCarne.Location = new System.Drawing.Point(570, 233);
            this.TxtNuevoCarne.Name = "TxtNuevoCarne";
            this.TxtNuevoCarne.Size = new System.Drawing.Size(190, 22);
            this.TxtNuevoCarne.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pictureBoxqr
            // 
            this.pictureBoxqr.Location = new System.Drawing.Point(347, 308);
            this.pictureBoxqr.Name = "pictureBoxqr";
            this.pictureBoxqr.Size = new System.Drawing.Size(413, 262);
            this.pictureBoxqr.TabIndex = 10;
            this.pictureBoxqr.TabStop = false;
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Items.AddRange(new object[] {
            "Ingeniería en Sistemas",
            "Ingeniería en Electrónica",
            "Ingeniería en Telecomunicaciones"});
            this.comboBoxCarrera.Location = new System.Drawing.Point(570, 170);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(190, 24);
            this.comboBoxCarrera.TabIndex = 11;
            this.comboBoxCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarrera_SelectedIndexChanged);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(166, 432);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 12;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 635);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxCarrera);
            this.Controls.Add(this.pictureBoxqr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtNuevoCarne);
            this.Controls.Add(this.bottonqr);
            this.Controls.Add(this.TxtCarneactual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoCarne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxqr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCarne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCarneactual;
        private System.Windows.Forms.Button bottonqr;
        private System.Windows.Forms.TextBox TxtNuevoCarne;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBoxqr;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

