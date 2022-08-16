namespace Clinica.view
{
    partial class FmrConsulta
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.Criar = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.filtroValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Codigo"});
            this.listBox1.Location = new System.Drawing.Point(169, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 23;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 22;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Criar
            // 
            this.Criar.Location = new System.Drawing.Point(473, 309);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(75, 23);
            this.Criar.TabIndex = 21;
            this.Criar.Text = "Novo";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(315, 309);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 20;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(169, 309);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 19;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // filtroValor
            // 
            this.filtroValor.Location = new System.Drawing.Point(352, 62);
            this.filtroValor.Name = "filtroValor";
            this.filtroValor.Size = new System.Drawing.Size(100, 20);
            this.filtroValor.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medico,
            this.Paciente,
            this.dataHora,
            this.codm,
            this.codp});
            this.listagem.Location = new System.Drawing.Point(169, 127);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(379, 150);
            this.listagem.TabIndex = 16;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listagem_CellContentClick_1);
            // 
            // Medico
            // 
            this.Medico.HeaderText = "Médico";
            this.Medico.Name = "Medico";
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            // 
            // dataHora
            // 
            this.dataHora.FillWeight = 160F;
            this.dataHora.HeaderText = "Data/Hora";
            this.dataHora.Name = "dataHora";
            // 
            // codm
            // 
            this.codm.HeaderText = "CodM";
            this.codm.Name = "codm";
            this.codm.Visible = false;
            // 
            // codp
            // 
            this.codp.HeaderText = "CodP";
            this.codp.Name = "codp";
            this.codp.Visible = false;
            // 
            // FmrConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 388);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.filtroValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listagem);
            this.Name = "FmrConsulta";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.TextBox filtroValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn codm;
        private System.Windows.Forms.DataGridViewTextBoxColumn codp;
    }
}