namespace Proyecto_Final.UI
{
    partial class RegistrarAsistencias
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
            this.btRegistrar = new System.Windows.Forms.Button();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(12, 75);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(106, 23);
            this.btRegistrar.TabIndex = 0;
            this.btRegistrar.Text = "Asistir";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTema
            // 
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(12, 12);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(169, 21);
            this.cbTema.TabIndex = 1;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(192, 12);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(169, 21);
            this.cbUsuario.TabIndex = 2;
            // 
            // RegistrarAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 133);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.btRegistrar);
            this.Name = "RegistrarAsistencias";
            this.Text = "RegistrarAsistencias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarAsistencias_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.ComboBox cbUsuario;
    }
}