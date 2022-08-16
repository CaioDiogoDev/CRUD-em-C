using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.model
{
    internal class Funcionarios
    {
        public int CodF { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public decimal Salario{ get; set; }
        public string Cpf { get; set; }

        public string Cidade { get; set; }

        public string Cargo { get; set; }


        public override string ToString()
        {
            return

                this.Nome + "\n" +
                this.Idade + "\n" +
                this.Salario + "\n" +
                this.Cpf + "\n" +
                this.Cidade + "\n" +
                this.Cargo + "\n"

                ;
        }

    }
        


}
