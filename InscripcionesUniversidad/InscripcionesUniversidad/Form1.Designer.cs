namespace InscripcionesUniversidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbNombreE = new System.Windows.Forms.TextBox();
            this.txtbApellidosE = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.Siguiente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbNumeroID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "       DATOS BÁSICOS DEL ESTUDIANTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos Completos* :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° documento Id* :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad* :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° telefono* :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo electronico* :  ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Targeta de Identidad",
            "Cedula de Ciudadania",
            "Cedula Extranjera",
            "Pasaporte"});
            this.comboBox1.Location = new System.Drawing.Point(212, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "seleccione una opccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(45, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tipo de Documento";
            // 
            // txtbNombreE
            // 
            this.txtbNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtbNombreE.Location = new System.Drawing.Point(212, 105);
            this.txtbNombreE.Name = "txtbNombreE";
            this.txtbNombreE.Size = new System.Drawing.Size(153, 23);
            this.txtbNombreE.TabIndex = 9;
            this.txtbNombreE.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtbApellidosE
            // 
            this.txtbApellidosE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtbApellidosE.Location = new System.Drawing.Point(212, 167);
            this.txtbApellidosE.Name = "txtbApellidosE";
            this.txtbApellidosE.Size = new System.Drawing.Size(153, 23);
            this.txtbApellidosE.TabIndex = 10;
            // 
            // txtbEdad
            // 
            this.txtbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtbEdad.Location = new System.Drawing.Point(544, 219);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(127, 23);
            this.txtbEdad.TabIndex = 12;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtbTelefono.Location = new System.Drawing.Point(544, 167);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(127, 23);
            this.txtbTelefono.TabIndex = 13;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtbEmail.Location = new System.Drawing.Point(544, 102);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(127, 23);
            this.txtbEmail.TabIndex = 14;
            // 
            // Siguiente
            // 
            this.Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Siguiente.Location = new System.Drawing.Point(528, 313);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(127, 26);
            this.Siguiente.TabIndex = 15;
            this.Siguiente.Text = "SIGUIENTE";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(528, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Limpiar.Location = new System.Drawing.Point(528, 362);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(127, 26);
            this.Limpiar.TabIndex = 17;
            this.Limpiar.Text = "LIMPIAR DATOS";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(45, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de Nacimiento* :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 23);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // txtbNumeroID
            // 
            this.txtbNumeroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtbNumeroID.Location = new System.Drawing.Point(212, 294);
            this.txtbNumeroID.Name = "txtbNumeroID";
            this.txtbNumeroID.Size = new System.Drawing.Size(153, 23);
            this.txtbNumeroID.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(31, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Los campos marcados con * son obligatorios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(705, 494);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.txtbNumeroID);
            this.Controls.Add(this.txtbApellidosE);
            this.Controls.Add(this.txtbNombreE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbNombreE;
        private System.Windows.Forms.TextBox txtbApellidosE;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbNumeroID;
        private System.Windows.Forms.Label label10;
    }
}

