﻿namespace Clinica.view
{
    partial class edtConsulta
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
            this.button2 = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientes_combo = new System.Windows.Forms.ComboBox();
            this.medicos_combo = new System.Windows.Forms.ComboBox();
            this.dataHoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(510, 328);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 43;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Editar Consulta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Medico";
            // 
            // pacientes_combo
            // 
            this.pacientes_combo.FormattingEnabled = true;
            this.pacientes_combo.Location = new System.Drawing.Point(287, 229);
            this.pacientes_combo.Name = "pacientes_combo";
            this.pacientes_combo.Size = new System.Drawing.Size(263, 21);
            this.pacientes_combo.TabIndex = 39;
            // 
            // medicos_combo
            // 
            this.medicos_combo.FormattingEnabled = true;
            this.medicos_combo.Location = new System.Drawing.Point(287, 184);
            this.medicos_combo.Name = "medicos_combo";
            this.medicos_combo.Size = new System.Drawing.Size(263, 21);
            this.medicos_combo.TabIndex = 38;
            this.medicos_combo.SelectedIndexChanged += new System.EventHandler(this.Medicos_combo_SelectedIndexChanged);
            // 
            // dataHoraConsulta
            // 
            this.dataHoraConsulta.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dataHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataHoraConsulta.Location = new System.Drawing.Point(287, 270);
            this.dataHoraConsulta.Name = "dataHoraConsulta";
            this.dataHoraConsulta.Size = new System.Drawing.Size(263, 20);
            this.dataHoraConsulta.TabIndex = 37;
            // 
            // edtConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 458);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pacientes_combo);
            this.Controls.Add(this.medicos_combo);
            this.Controls.Add(this.dataHoraConsulta);
            this.Controls.Add(this.button2);
            this.Name = "edtConsulta";
            this.Text = "Editar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pacientes_combo;
        private System.Windows.Forms.ComboBox medicos_combo;
        private System.Windows.Forms.DateTimePicker dataHoraConsulta;
    }
}