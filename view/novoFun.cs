using Clinica.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.view
{
    public partial class novoFun : Form
    {
        public novoFun()
        {
            InitializeComponent();
        }

        private void doenca_label_Click(object sender, EventArgs e)
        {

        }

        private void codigo_label_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Funcionarios fun = new Funcionarios();
           
            this.Close();
        }
    }
}
