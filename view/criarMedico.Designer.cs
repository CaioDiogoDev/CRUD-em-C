namespace Clinica.view
{
    partial class criarMedico
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
            this.Salvar = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.doenca_label = new System.Windows.Forms.Label();
            this.especialidadeValor = new System.Windows.Forms.TextBox();
            this.voltar = new System.Windows.Forms.Button();
            this.AmbulatorioValor = new System.Windows.Forms.TextBox();
            this.Ambulatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(666, 390);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 20);
            this.Salvar.TabIndex = 0;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(301, 25);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(187, 24);
            this.titulo_label.TabIndex = 25;
            this.titulo_label.Text = "Criar novo medico:";
            // 
            // cpfValor
            // 
            this.cpfValor.Location = new System.Drawing.Point(328, 243);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(223, 20);
            this.cpfValor.TabIndex = 22;
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(227, 250);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(30, 13);
            this.cpf_label.TabIndex = 21;
            this.cpf_label.Text = "CPF:";
            // 
            // cidadeValor
            // 
            this.cidadeValor.Location = new System.Drawing.Point(328, 189);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(223, 20);
            this.cidadeValor.TabIndex = 20;
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(227, 196);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(43, 13);
            this.cidade_label.TabIndex = 19;
            this.cidade_label.Text = "Cidade:";
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(328, 138);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 18;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(234, 145);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(37, 13);
            this.idade_label.TabIndex = 17;
            this.idade_label.Text = "Idade:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(328, 88);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 16;
            this.nomeValor.TextChanged += new System.EventHandler(this.nomeValor_TextChanged);
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(234, 95);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 15;
            this.nome_label.Text = "Nome:";
            // 
            // doenca_label
            // 
            this.doenca_label.AutoSize = true;
            this.doenca_label.Location = new System.Drawing.Point(214, 301);
            this.doenca_label.Name = "doenca_label";
            this.doenca_label.Size = new System.Drawing.Size(76, 13);
            this.doenca_label.TabIndex = 23;
            this.doenca_label.Text = "Especialidade:";
            // 
            // especialidadeValor
            // 
            this.especialidadeValor.Location = new System.Drawing.Point(328, 294);
            this.especialidadeValor.Name = "especialidadeValor";
            this.especialidadeValor.Size = new System.Drawing.Size(223, 20);
            this.especialidadeValor.TabIndex = 24;
            this.especialidadeValor.TextChanged += new System.EventHandler(this.doencaValor_TextChanged);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(12, 12);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(76, 37);
            this.voltar.TabIndex = 26;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // AmbulatorioValor
            // 
            this.AmbulatorioValor.Location = new System.Drawing.Point(328, 342);
            this.AmbulatorioValor.Name = "AmbulatorioValor";
            this.AmbulatorioValor.Size = new System.Drawing.Size(223, 20);
            this.AmbulatorioValor.TabIndex = 27;
            this.AmbulatorioValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ambulatorio
            // 
            this.Ambulatorio.AutoSize = true;
            this.Ambulatorio.Location = new System.Drawing.Point(214, 349);
            this.Ambulatorio.Name = "Ambulatorio";
            this.Ambulatorio.Size = new System.Drawing.Size(65, 13);
            this.Ambulatorio.TabIndex = 28;
            this.Ambulatorio.Text = "Ambulatorio:";
            this.Ambulatorio.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // criarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ambulatorio);
            this.Controls.Add(this.AmbulatorioValor);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.especialidadeValor);
            this.Controls.Add(this.doenca_label);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.Salvar);
            this.Name = "criarMedico";
            this.Text = "Criaçao ";
            this.Load += new System.EventHandler(this.Criaçao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label doenca_label;
        private System.Windows.Forms.TextBox especialidadeValor;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox AmbulatorioValor;
        private System.Windows.Forms.Label Ambulatorio;
    }
}