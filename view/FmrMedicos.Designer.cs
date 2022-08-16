namespace Clinica
{
    partial class FmrMedicos
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
            this.listagem = new System.Windows.Forms.DataGridView();
            this.CodM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.deletar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodM,
            this.Nome,
            this.Idade,
            this.Cpf,
            this.Especialidade,
            this.nroa});
            this.listagem.Location = new System.Drawing.Point(12, 55);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(681, 273);
            this.listagem.TabIndex = 4;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CodM
            // 
            this.CodM.HeaderText = "Codigo";
            this.CodM.Name = "CodM";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            // 
            // Especialidade
            // 
            this.Especialidade.HeaderText = "Especialidade";
            this.Especialidade.Name = "Especialidade";
            // 
            // nroa
            // 
            this.nroa.HeaderText = "Ambulatorio";
            this.nroa.Name = "nroa";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.listBox1.Location = new System.Drawing.Point(33, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(291, 364);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(75, 23);
            this.deletar.TabIndex = 13;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FmrMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 399);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listagem);
            this.Name = "FmrMedicos";
            this.Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroa;
    }
}