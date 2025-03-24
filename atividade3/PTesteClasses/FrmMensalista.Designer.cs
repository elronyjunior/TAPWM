namespace PTesteClasses
{
    partial class FrmMensalista
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblEntradaEmpresa = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnInstaciarMensalistaParametros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(158, 159);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(475, 126);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(124, 26);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(158, 122);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(110, 29);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMensal.Location = new System.Drawing.Point(158, 196);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(173, 29);
            this.lblSalarioMensal.TabIndex = 3;
            this.lblSalarioMensal.Text = "Sálario Mensal";
            // 
            // lblEntradaEmpresa
            // 
            this.lblEntradaEmpresa.AutoSize = true;
            this.lblEntradaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaEmpresa.Location = new System.Drawing.Point(158, 233);
            this.lblEntradaEmpresa.Name = "lblEntradaEmpresa";
            this.lblEntradaEmpresa.Size = new System.Drawing.Size(286, 29);
            this.lblEntradaEmpresa.TabIndex = 4;
            this.lblEntradaEmpresa.Text = "Data Entrada na Empresa";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(475, 163);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 26);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(475, 200);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(140, 26);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(475, 237);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(140, 26);
            this.txtDataEntradaEmpresa.TabIndex = 7;
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(191, 309);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(269, 130);
            this.btnInstanciarMensalista.TabIndex = 8;
            this.btnInstanciarMensalista.Text = "instanciar mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.Instanciar_Click);
            // 
            // btnInstaciarMensalistaParametros
            // 
            this.btnInstaciarMensalistaParametros.Location = new System.Drawing.Point(578, 309);
            this.btnInstaciarMensalistaParametros.Name = "btnInstaciarMensalistaParametros";
            this.btnInstaciarMensalistaParametros.Size = new System.Drawing.Size(345, 130);
            this.btnInstaciarMensalistaParametros.TabIndex = 9;
            this.btnInstaciarMensalistaParametros.Text = "insatnciar mensalista passando parametros";
            this.btnInstaciarMensalistaParametros.UseVisualStyleBackColor = true;
            this.btnInstaciarMensalistaParametros.Click += new System.EventHandler(this.InstanciarComParametro);
            // 
            // FrmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 504);
            this.Controls.Add(this.btnInstaciarMensalistaParametros);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEntradaEmpresa);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmMensalista";
            this.Text = "FrmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblEntradaEmpresa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnInstaciarMensalistaParametros;
    }
}