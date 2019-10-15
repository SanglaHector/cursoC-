namespace FormSistemaSolar
{
    partial class FormSistemaSolar
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboPlaneta = new System.Windows.Forms.ComboBox();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacion = new System.Windows.Forms.NumericUpDown();
            this.numSatelites = new System.Windows.Forms.NumericUpDown();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.richTextInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelites)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de planeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo en completar orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo en completar rotacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de planeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Planeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre de satelite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiempo en completar la orbita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiempo en completar la rotacion";
            // 
            // comboPlaneta
            // 
            this.comboPlaneta.FormattingEnabled = true;
            this.comboPlaneta.Location = new System.Drawing.Point(513, 6);
            this.comboPlaneta.Name = "comboPlaneta";
            this.comboPlaneta.Size = new System.Drawing.Size(121, 21);
            this.comboPlaneta.TabIndex = 9;
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(12, 221);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(320, 46);
            this.btnAgregarPlaneta.TabIndex = 10;
            this.btnAgregarPlaneta.Text = "Agregar planeta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.BtnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(358, 221);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(276, 46);
            this.btnAgregarSatelite.TabIndex = 11;
            this.btnAgregarSatelite.Text = "Agregar satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.BtnAgregarSatelite_Click);
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(15, 273);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(619, 48);
            this.btninfo.TabIndex = 12;
            this.btninfo.Text = "Mostrar informacion";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.Btninfo_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(15, 327);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(619, 48);
            this.btnMoverAstros.TabIndex = 13;
            this.btnMoverAstros.Text = "Mover astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.BtnMoverAstros_Click);
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(167, 6);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(155, 20);
            this.txtNombrePlaneta.TabIndex = 14;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(167, 51);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(155, 20);
            this.txtOrbitaPlaneta.TabIndex = 15;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(513, 51);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(121, 20);
            this.txtNombreSatelite.TabIndex = 16;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(513, 90);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(121, 20);
            this.numOrbitaSatelite.TabIndex = 17;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(513, 140);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(121, 20);
            this.numRotacionSatelite.TabIndex = 18;
            // 
            // numRotacion
            // 
            this.numRotacion.Location = new System.Drawing.Point(167, 95);
            this.numRotacion.Name = "numRotacion";
            this.numRotacion.Size = new System.Drawing.Size(155, 20);
            this.numRotacion.TabIndex = 19;
            // 
            // numSatelites
            // 
            this.numSatelites.Location = new System.Drawing.Point(167, 133);
            this.numSatelites.Name = "numSatelites";
            this.numSatelites.Size = new System.Drawing.Size(155, 20);
            this.numSatelites.TabIndex = 20;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(167, 173);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(155, 21);
            this.comboTipo.TabIndex = 21;
            // 
            // richTextInfo
            // 
            this.richTextInfo.Location = new System.Drawing.Point(646, 6);
            this.richTextInfo.Name = "richTextInfo";
            this.richTextInfo.Size = new System.Drawing.Size(256, 369);
            this.richTextInfo.TabIndex = 22;
            this.richTextInfo.Text = "";
            // 
            // FormSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 397);
            this.Controls.Add(this.richTextInfo);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.numSatelites);
            this.Controls.Add(this.numRotacion);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.comboPlaneta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSistemaSolar";
            this.Text = "Hector Sangla";
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelites)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboPlaneta;
        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.NumericUpDown numRotacion;
        private System.Windows.Forms.NumericUpDown numSatelites;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.RichTextBox richTextInfo;
    }
}

