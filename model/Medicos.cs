using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.model
{
    internal class Medicos
    {
       
        public int CodM { get;  set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Especialidade { get; set; }
        public string Cpf { get; set; }

        public string Cidade { get; set; }

        public int NroA { get; set; }
        

        public override string ToString()
        {
            return

                this.Nome + "\n" +
                this.Idade + "\n" +
                this.Especialidade + "\n" +
                this.Cpf + "\n"+
                this.Cidade+"\n"+
                this.NroA+"\n"
                ;
        }
    }
}
