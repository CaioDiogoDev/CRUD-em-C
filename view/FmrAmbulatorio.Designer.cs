namespace Clinica.view
{
    partial class FmrAmbulatorio
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
            this.Voltar = new System.Windows.Forms.Button();
            this.Criar = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Andar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 22);
            this.Voltar.TabIndex = 1;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Criar
            // 
            this.Criar.Location = new System.Drawing.Point(429, 252);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(75, 23);
            this.Criar.TabIndex = 29;
            this.Criar.Text = "Novo";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(294, 252);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 28;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(163, 252);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 27;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Andar,
            this.Capacidade});
            this.listagem.Location = new System.Drawing.Point(163, 68);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(341, 150);
            this.listagem.TabIndex = 24;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Andar
            // 
            this.Andar.HeaderText = "Andar";
            this.Andar.Name = "Andar";
            // 
            // Capacidade
            // 
            this.Capacidade.HeaderText = "Capacidade";
            this.Capacidade.Name = "Capacidade";
            // 
            // FmrAmbulatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 367);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.Voltar);
            this.Name = "FmrAmbulatorio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Andar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidade;
    }
}