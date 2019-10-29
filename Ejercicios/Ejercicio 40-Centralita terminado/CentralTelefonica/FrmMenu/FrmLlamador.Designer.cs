namespace FrmMenu
{
    partial class FrmLlamador
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
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(12, 29);
            this.txtDestino.MaxLength = 16;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(316, 26);
            this.txtDestino.TabIndex = 0;
            this.txtDestino.Text = "Nro destino";
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(197, 194);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(131, 26);
            this.txtOrigen.TabIndex = 1;
            this.txtOrigen.Text = "Nro origen";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(197, 82);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(131, 34);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.BtnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(197, 132);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 34);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNumeral);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Controls.Add(this.btnAsterisco);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(17, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(107, 151);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(40, 38);
            this.btnNumeral.TabIndex = 11;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.BtnNumeral_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(61, 151);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(40, 38);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(15, 151);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(40, 38);
            this.btnAsterisco.TabIndex = 9;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.BtnAsterisco_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(107, 107);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 38);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(61, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 38);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 107);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(107, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(61, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Franja";
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 341);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtDestino);
            this.Name = "FrmLlamador";
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}