namespace Clinica.view
{
    partial class criarConsulta
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
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(324, 145);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(189, 24);
            this.titulo_label.TabIndex = 21;
            this.titulo_label.Text = "Criar nova consulta";
            this.titulo_label.Click += new System.EventHandler(this.titulo_label_Click);
            // 
            // cidadeValor
            // 
            this.cidadeValor.Location = new System.Drawing.Point(328, 338);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(223, 20);
            this.cidadeValor.TabIndex = 20;
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(249, 345);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(33, 13);
            this.cidade_label.TabIndex = 19;
            this.cidade_label.Text = "Hora:";
            this.cidade_label.Click += new System.EventHandler(this.cidade_label_Click);
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(328, 296);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 18;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(249, 303);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(33, 13);
            this.idade_label.TabIndex = 17;
            this.idade_label.Text = "Data:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(328, 252);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 16;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(249, 259);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(0, 13);
            this.nome_label.TabIndex = 15;
            // 
            // codigoValor
            // 
            this.codigoValor.Location = new System.Drawing.Point(328, 211);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 20);
            this.codigoValor.TabIndex = 14;
            this.codigoValor.TextChanged += new System.EventHandler(this.codigoValor_TextChanged);
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(230, 218);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(80, 13);
            this.codigo_label.TabIndex = 13;
            this.codigo_label.Text = "Codigo medico:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.codigo_label.Click += new System.EventHandler(this.codigo_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo Pasciente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // criarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Name = "criarConsulta";
            this.Text = "Criar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}