namespace ProyectoFinal_Francisco.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedConferencista = new System.Windows.Forms.TextBox();
            this.txtNomConferencista = new System.Windows.Forms.TextBox();
            this.txtApeConferencista = new System.Windows.Forms.TextBox();
            this.btAgregaProf = new System.Windows.Forms.Button();
            this.dgvConferencistas = new System.Windows.Forms.DataGridView();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoConferencista = new System.Windows.Forms.TextBox();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferencistas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // txtCedConferencista
            // 
            this.txtCedConferencista.Location = new System.Drawing.Point(67, 9);
            this.txtCedConferencista.Name = "txtCedConferencista";
            this.txtCedConferencista.Size = new System.Drawing.Size(100, 20);
            this.txtCedConferencista.TabIndex = 3;
            // 
            // txtNomConferencista
            // 
            this.txtNomConferencista.Location = new System.Drawing.Point(67, 45);
            this.txtNomConferencista.Name = "txtNomConferencista";
            this.txtNomConferencista.Size = new System.Drawing.Size(100, 20);
            this.txtNomConferencista.TabIndex = 4;
            // 
            // txtApeConferencista
            // 
            this.txtApeConferencista.Location = new System.Drawing.Point(67, 84);
            this.txtApeConferencista.Name = "txtApeConferencista";
            this.txtApeConferencista.Size = new System.Drawing.Size(100, 20);
            this.txtApeConferencista.TabIndex = 5;
            // 
            // btAgregaProf
            // 
            this.btAgregaProf.Location = new System.Drawing.Point(92, 168);
            this.btAgregaProf.Name = "btAgregaProf";
            this.btAgregaProf.Size = new System.Drawing.Size(75, 23);
            this.btAgregaProf.TabIndex = 6;
            this.btAgregaProf.Text = "Registrar";
            this.btAgregaProf.UseVisualStyleBackColor = true;
            this.btAgregaProf.Click += new System.EventHandler(this.btAgregaProf_Click);
            // 
            // dgvConferencistas
            // 
            this.dgvConferencistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConferencistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cédula,
            this.Nombre,
            this.Apellidos,
            this.Correo});
            this.dgvConferencistas.Location = new System.Drawing.Point(189, 9);
            this.dgvConferencistas.Name = "dgvConferencistas";
            this.dgvConferencistas.ReadOnly = true;
            this.dgvConferencistas.Size = new System.Drawing.Size(536, 182);
            this.dgvConferencistas.TabIndex = 7;
            this.dgvConferencistas.Click += new System.EventHandler(this.dgvConferencistas_Click);
            // 
            // Cédula
            // 
            this.Cédula.HeaderText = "Cédula";
            this.Cédula.Name = "Cédula";
            this.Cédula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correo";
            // 
            // txtCorreoConferencista
            // 
            this.txtCorreoConferencista.Location = new System.Drawing.Point(67, 124);
            this.txtCorreoConferencista.Name = "txtCorreoConferencista";
            this.txtCorreoConferencista.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoConferencista.TabIndex = 9;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(15, 168);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(71, 23);
            this.btEliminar.TabIndex = 12;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // RegistrarAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 239);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.txtCorreoConferencista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvConferencistas);
            this.Controls.Add(this.btAgregaProf);
            this.Controls.Add(this.txtApeConferencista);
            this.Controls.Add(this.txtNomConferencista);
            this.Controls.Add(this.txtCedConferencista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarAsistencias";
            this.Text = "Registro de Conferencistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferencistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedConferencista;
        private System.Windows.Forms.TextBox txtNomConferencista;
        private System.Windows.Forms.TextBox txtApeConferencista;
        private System.Windows.Forms.Button btAgregaProf;
        private System.Windows.Forms.DataGridView dgvConferencistas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoConferencista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.Button btEliminar;
    }
}