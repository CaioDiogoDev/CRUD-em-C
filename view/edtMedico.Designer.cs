namespace Clinica.view
{
    partial class edtMedico
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
            this.titulo_label = new System.Windows.Forms.Label();
            this.EspecialidadeValor = new System.Windows.Forms.TextBox();
            this.doenca_label = new System.Windows.Forms.Label();
            this.CpfValor = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.CidadeValor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.codigo_label = new System.Windows.Forms.Label();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(264, 55);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(139, 24);
            this.titulo_label.TabIndex = 39;
            this.titulo_label.Text = "Editar Medico";
            // 
            // EspecialidadeValor
            // 
            this.EspecialidadeValor.Location = new System.Drawing.Point(242, 339);
            this.EspecialidadeValor.Name = "EspecialidadeValor";
            this.EspecialidadeValor.Size = new System.Drawing.Size(223, 20);
            this.EspecialidadeValor.TabIndex = 38;
            // 
            // doenca_label
            // 
            this.doenca_label.AutoSize = true;
            this.doenca_label.Location = new System.Drawing.Point(146, 346);
            this.doenca_label.Name = "doenca_label";
            this.doenca_label.Size = new System.Drawing.Size(76, 13);
            this.doenca_label.TabIndex = 37;
            this.doenca_label.Text = "Especialidade:";
            // 
            // CpfValor
            // 
            this.CpfValor.Location = new System.Drawing.Point(242, 302);
            this.CpfValor.Name = "CpfValor";
            this.CpfValor.Size = new System.Drawing.Size(223, 20);
            this.CpfValor.TabIndex = 36;
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(163, 309);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(30, 13);
            this.cpf_label.TabIndex = 35;
            this.cpf_label.Text = "CPF:";
            // 
            // CidadeValor
            // 
            this.CidadeValor.Location = new System.Drawing.Point(242, 254);
            this.CidadeValor.Name = "CidadeValor";
            this.CidadeValor.Size = new System.Drawing.Size(223, 20);
            this.CidadeValor.TabIndex = 34;
            this.CidadeValor.TextChanged += new System.EventHandler(this.cidadeValor_TextChanged);
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(163, 261);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(43, 13);
            this.cidade_label.TabIndex = 33;
            this.cidade_label.Text = "Cidade:";
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(242, 212);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 32;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(163, 219);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(37, 13);
            this.idade_label.TabIndex = 31;
            this.idade_label.Text = "Idade:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(242, 168);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 30;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(163, 175);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 29;
            this.nome_label.Text = "Nome:";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(580, 370);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 26;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(12, 12);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 40;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(163, 130);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 27;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // codigoValor
            // 
            this.codigoValor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.codigoValor.Location = new System.Drawing.Point(242, 123);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 20);
            this.codigoValor.TabIndex = 28;
            // 
            // edtMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.EspecialidadeValor);
            this.Controls.Add(this.doenca_label);
            this.Controls.Add(this.CpfValor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.CidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Controls.Add(this.Salvar);
            this.Name = "edtMedico";
            this.Text = "Editar Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox EspecialidadeValor;
        private System.Windows.Forms.Label doenca_label;
        private System.Windows.Forms.TextBox CpfValor;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox CidadeValor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.TextBox codigoValor;
    }
}