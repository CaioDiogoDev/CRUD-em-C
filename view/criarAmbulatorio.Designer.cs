namespace Clinica.view
{
    partial class criarAmbulatorio
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
            this.titulo_label = new System.Windows.Forms.Label();
            this.capacidadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.andarValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 61;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(277, 37);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(271, 24);
            this.titulo_label.TabIndex = 60;
            this.titulo_label.Text = "Cadastrar novo  ambulatorio";
            // 
            // capacidadeValor
            // 
            this.capacidadeValor.Location = new System.Drawing.Point(281, 234);
            this.capacidadeValor.Name = "capacidadeValor";
            this.capacidadeValor.Size = new System.Drawing.Size(223, 20);
            this.capacidadeValor.TabIndex = 59;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(185, 241);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(67, 13);
            this.idade_label.TabIndex = 58;
            this.idade_label.Text = "Capacidade:";
            // 
            // andarValor
            // 
            this.andarValor.Location = new System.Drawing.Point(281, 119);
            this.andarValor.Name = "andarValor";
            this.andarValor.Size = new System.Drawing.Size(223, 20);
            this.andarValor.TabIndex = 57;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(185, 126);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 56;
            this.nome_label.Text = "Andar:";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(605, 367);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 55;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // criarAmbulatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 418);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.capacidadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.andarValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.Salvar);
            this.Name = "criarAmbulatorio";
            this.Text = "criarAmbulatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox capacidadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox andarValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button Salvar;
    }
}