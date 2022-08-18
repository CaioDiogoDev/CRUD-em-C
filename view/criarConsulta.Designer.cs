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
            this.nome_label = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientes_combo = new System.Windows.Forms.ComboBox();
            this.medicos_combo = new System.Windows.Forms.ComboBox();
            this.dataHoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.Voltar = new System.Windows.Forms.Button();
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
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(249, 259);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(0, 13);
            this.nome_label.TabIndex = 15;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(671, 438);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 23;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Medico";
            // 
            // pacientes_combo
            // 
            this.pacientes_combo.FormattingEnabled = true;
            this.pacientes_combo.Location = new System.Drawing.Point(304, 242);
            this.pacientes_combo.Name = "pacientes_combo";
            this.pacientes_combo.Size = new System.Drawing.Size(263, 21);
            this.pacientes_combo.TabIndex = 44;
            // 
            // medicos_combo
            // 
            this.medicos_combo.FormattingEnabled = true;
            this.medicos_combo.Location = new System.Drawing.Point(304, 197);
            this.medicos_combo.Name = "medicos_combo";
            this.medicos_combo.Size = new System.Drawing.Size(263, 21);
            this.medicos_combo.TabIndex = 43;
            this.medicos_combo.SelectedIndexChanged += new System.EventHandler(this.medicos_combo_SelectedIndexChanged);
            // 
            // dataHoraConsulta
            // 
            this.dataHoraConsulta.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dataHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataHoraConsulta.Location = new System.Drawing.Point(304, 283);
            this.dataHoraConsulta.Name = "dataHoraConsulta";
            this.dataHoraConsulta.Size = new System.Drawing.Size(263, 20);
            this.dataHoraConsulta.TabIndex = 42;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 12);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 47;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // criarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pacientes_combo);
            this.Controls.Add(this.medicos_combo);
            this.Controls.Add(this.dataHoraConsulta);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.nome_label);
            this.Name = "criarConsulta";
            this.Text = "Criar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pacientes_combo;
        private System.Windows.Forms.ComboBox medicos_combo;
        private System.Windows.Forms.DateTimePicker dataHoraConsulta;
        private System.Windows.Forms.Button Voltar;
    }
}