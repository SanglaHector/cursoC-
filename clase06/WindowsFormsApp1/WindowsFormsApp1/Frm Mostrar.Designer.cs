namespace WindowsFormsApp1
{
  partial class Frm_Mostrar
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
            this.listPersonas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listPersonas
            // 
            this.listPersonas.FormattingEnabled = true;
            this.listPersonas.Location = new System.Drawing.Point(12, 12);
            this.listPersonas.Name = "listPersonas";
            this.listPersonas.Size = new System.Drawing.Size(384, 212);
            this.listPersonas.TabIndex = 0;
            this.listPersonas.SelectedIndexChanged += new System.EventHandler(this.listPersonas_SelectedIndexChanged);
            // 
            // Frm_Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 249);
            this.Controls.Add(this.listPersonas);
            this.Name = "Frm_Mostrar";
            this.Text = "Frm_Mostrar";
            this.Load += new System.EventHandler(this.Frm_Mostrar_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox listPersonas;
  }
}
