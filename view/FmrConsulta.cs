using Clinica.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.view
{
    public partial class FmrConsulta : Form
    {
        public FmrConsulta()
        {
            InitializeComponent();
        }

        public FmrConsulta(ArrayList lista)
        {
            InitializeComponent();
            int x = 0;
            foreach (Consulta c in lista)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = "Dr(a) " + c.medicos.Nome;
                this.listagem.Rows[x].Cells[1].Value = c.paciente.Nome;
                this.listagem.Rows[x].Cells[2].Value = c.dataHora.ToString("yyyy-MM-dd HH:mm:ss");
                this.listagem.Rows[x].Cells[3].Value = c.medicos.CodM;
                this.listagem.Rows[x].Cells[4].Value = c.paciente.CodP;
                x++;
            }

        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void listagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();
            controller.preparaCriacao();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;
            String dataHora = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            string codm = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            string codp = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            DateTime dataHoraFormata = DateTime.ParseExact(dataHora, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Paciente p = new Paciente();
            Medicos m = new Medicos();
            p.CodP = int.Parse(codp);
            m.CodM = int.Parse(codm);

            Consulta c = new Consulta();
            c.medicos = m;
            c.paciente = p;
            c.dataHora = dataHoraFormata;

            ConsultaController controller = new ConsultaController();
            controller.preparaEdicao(c);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;
            String dataHora = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            string codm = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            string codp = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            DateTime dataHoraFormata = DateTime.ParseExact(dataHora, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Paciente p = new Paciente();
            Medicos m = new Medicos();
            p.CodP = int.Parse(codp);
            m.CodM = int.Parse(codm);

            Consulta c = new Consulta();
            c.medicos = m;
            c.paciente = p;
            c.dataHora = dataHoraFormata;

            ConsultaController controller = new ConsultaController();
            controller.deletar(c);
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ConsultaController consultacontroller = new ConsultaController();
            consultacontroller.preparaCriacao();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listagem_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
            this.Close();
        }
    }
}
