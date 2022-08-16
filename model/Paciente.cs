using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Paciente
    {
        public int CodP {  get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Especialidade { get; set; }
        public string Doenca { get; set; }

        public override string ToString()
        {
            return 
                this.CodP + "\n" +
                this.Nome + "\n" +
                this.Idade + "\n" +
                this.Cpf + "\n" +
                this.Doenca + "\n"
                ;
        }
    }
    
}
