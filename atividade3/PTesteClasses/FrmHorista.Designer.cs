namespace PTesteClasses
{
    partial class FrmHorista
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
            this.txtEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEntradaEmpresa = new System.Windows.Forms.Label();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.txtFalta = new System.Windows.Forms.TextBox();
            this.lblFalta = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEntradaEmpresa
            // 
            this.txtEntradaEmpresa.Location = new System.Drawing.Point(403, 270);
            this.txtEntradaEmpresa.Name = "txtEntradaEmpresa";
            this.txtEntradaEmpresa.Size = new System.Drawing.Size(140, 26);
            this.txtEntradaEmpresa.TabIndex = 15;
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(403, 187);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(140, 26);
            this.txtSalarioHora.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(403, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 26);
            this.txtNome.TabIndex = 13;
            // 
            // lblEntradaEmpresa
            // 
            this.lblEntradaEmpresa.AutoSize = true;
            this.lblEntradaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaEmpresa.Location = new System.Drawing.Point(86, 266);
            this.lblEntradaEmpresa.Name = "lblEntradaEmpresa";
            this.lblEntradaEmpresa.Size = new System.Drawing.Size(286, 29);
            this.lblEntradaEmpresa.TabIndex = 12;
            this.lblEntradaEmpresa.Text = "Data Entrada na Empresa";
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHora.Location = new System.Drawing.Point(86, 183);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(160, 29);
            this.lblSalarioHora.TabIndex = 11;
            this.lblSalarioHora.Text = "Valor da Hora";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(86, 109);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(110, 29);
            this.lblMatricula.TabIndex = 10;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(403, 113);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(124, 26);
            this.txtMatricula.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(86, 146);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 29);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Location = new System.Drawing.Point(322, 383);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(143, 58);
            this.btnInstanciarHorista.TabIndex = 16;
            this.btnInstanciarHorista.Text = "instanciar horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.InstanciarHorista_Click);
            // 
            // txtFalta
            // 
            this.txtFalta.Location = new System.Drawing.Point(403, 313);
            this.txtFalta.Name = "txtFalta";
            this.txtFalta.Size = new System.Drawing.Size(140, 26);
            this.txtFalta.TabIndex = 17;
            // 
            // lblFalta
            // 
            this.lblFalta.AutoSize = true;
            this.lblFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalta.Location = new System.Drawing.Point(87, 313);
            this.lblFalta.Name = "lblFalta";
            this.lblFalta.Size = new System.Drawing.Size(78, 29);
            this.lblFalta.TabIndex = 18;
            this.lblFalta.Text = "Faltas";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(87, 225);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(77, 29);
            this.lblHoras.TabIndex = 19;
            this.lblHoras.Text = "Horas";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(403, 228);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(140, 26);
            this.txtHora.TabIndex = 20;
            // 
            // FrmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 495);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblFalta);
            this.Controls.Add(this.txtFalta);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Controls.Add(this.txtEntradaEmpresa);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEntradaEmpresa);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmHorista";
            this.Text = "FrmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaEmpresa;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEntradaEmpresa;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.TextBox txtFalta;
        private System.Windows.Forms.Label lblFalta;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHora;
    }
}