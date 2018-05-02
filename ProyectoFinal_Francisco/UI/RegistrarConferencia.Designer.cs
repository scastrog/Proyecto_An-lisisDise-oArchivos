namespace Proyecto_Final.UI
{
    partial class RegistrarConferencia
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAgregaAlum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.utilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvConferencias = new System.Windows.Forms.DataGridView();
            this.Tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEliminar = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.utilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tema ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugar";
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(109, 52);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(129, 20);
            this.txtTema.TabIndex = 3;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(109, 137);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(129, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datos del Conferencia";
            // 
            // btAgregaAlum
            // 
            this.btAgregaAlum.Location = new System.Drawing.Point(158, 201);
            this.btAgregaAlum.Name = "btAgregaAlum";
            this.btAgregaAlum.Size = new System.Drawing.Size(80, 37);
            this.btAgregaAlum.TabIndex = 7;
            this.btAgregaAlum.Text = "Registrar";
            this.btAgregaAlum.UseVisualStyleBackColor = true;
            this.btAgregaAlum.Click += new System.EventHandler(this.btAgregaAlum_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha";
            // 
            // dgvConferencias
            // 
            this.dgvConferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tema,
            this.Hora,
            this.Lugar,
            this.Fecha});
            this.dgvConferencias.Location = new System.Drawing.Point(256, 52);
            this.dgvConferencias.Name = "dgvConferencias";
            this.dgvConferencias.ReadOnly = true;
            this.dgvConferencias.Size = new System.Drawing.Size(420, 186);
            this.dgvConferencias.TabIndex = 10;
            this.dgvConferencias.Click += new System.EventHandler(this.dgvConferencias_Click);
            // 
            // Tema
            // 
            this.Tema.HeaderText = "Tema";
            this.Tema.Name = "Tema";
            this.Tema.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(54, 201);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(87, 37);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(109, 97);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(129, 20);
            this.dtpHora.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(109, 172);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(129, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // RegistrarConferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 243);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.dgvConferencias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btAgregaAlum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarConferencia";
            this.Text = "Conferencias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarConferencia_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.utilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAgregaAlum;
        private System.Windows.Forms.BindingSource utilBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvConferencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}