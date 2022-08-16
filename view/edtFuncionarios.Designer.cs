namespace Clinica.view
{
    partial class edtFuncionarios
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
            this.CargoValor = new System.Windows.Forms.TextBox();
            this.doenca_label = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.SalarioValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(264, 56);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(182, 24);
            this.titulo_label.TabIndex = 53;
            this.titulo_label.Text = "Editar Funcionario";
            // 
            // CargoValor
            // 
            this.CargoValor.Location = new System.Drawing.Point(242, 340);
            this.CargoValor.Name = "CargoValor";
            this.CargoValor.Size = new System.Drawing.Size(223, 20);
            this.CargoValor.TabIndex = 52;
            // 
            // doenca_label
            // 
            this.doenca_label.AutoSize = true;
            this.doenca_label.Location = new System.Drawing.Point(163, 343);
            this.doenca_label.Name = "doenca_label";
            this.doenca_label.Size = new System.Drawing.Size(35, 13);
            this.doenca_label.TabIndex = 51;
            this.doenca_label.Text = "Cargo";
            // 
            // cpfValor
            // 
            this.cpfValor.Location = new System.Drawing.Point(242, 303);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(223, 20);
            this.cpfValor.TabIndex = 50;
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(163, 310);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(30, 13);
            this.cpf_label.TabIndex = 49;
            this.cpf_label.Text = "CPF:";
            // 
            // cidadeValor
            // 
            this.cidadeValor.Location = new System.Drawing.Point(242, 255);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(223, 20);
            this.cidadeValor.TabIndex = 48;
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(163, 262);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(43, 13);
            this.cidade_label.TabIndex = 47;
            this.cidade_label.Text = "Cidade:";
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(242, 213);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 46;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(163, 220);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(37, 13);
            this.idade_label.TabIndex = 45;
            this.idade_label.Text = "Idade:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(242, 169);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 44;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(163, 176);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 43;
            this.nome_label.Text = "Nome:";
            // 
            // SalarioValor
            // 
            this.SalarioValor.Location = new System.Drawing.Point(242, 124);
            this.SalarioValor.Name = "SalarioValor";
            this.SalarioValor.Size = new System.Drawing.Size(223, 20);
            this.SalarioValor.TabIndex = 42;
            this.SalarioValor.TextChanged += new System.EventHandler(this.codigoValor_TextChanged);
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(163, 131);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(39, 13);
            this.codigo_label.TabIndex = 41;
            this.codigo_label.Text = "Salario";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(580, 371);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 40;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(12, 12);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 55;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // edtFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.CargoValor);
            this.Controls.Add(this.doenca_label);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.SalarioValor);
            this.Controls.Add(this.codigo_label);
            this.Controls.Add(this.Salvar);
            this.Name = "edtFuncionarios";
            this.Text = "Editar Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox CargoValor;
        private System.Windows.Forms.Label doenca_label;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox SalarioValor;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button voltar;
    }
}