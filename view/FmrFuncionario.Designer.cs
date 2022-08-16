namespace Clinica.view
{
    partial class FmrFuncionarios
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Listagem = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(619, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.listBox1.Location = new System.Drawing.Point(45, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Listagem
            // 
            this.Listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.idade,
            this.cidade,
            this.CPF,
            this.Salario,
            this.Cargo});
            this.Listagem.Location = new System.Drawing.Point(12, 88);
            this.Listagem.Name = "Listagem";
            this.Listagem.Size = new System.Drawing.Size(745, 251);
            this.Listagem.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // FmrFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 411);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Listagem);
            this.Name = "FmrFuncionarios";
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.Listagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Listagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}