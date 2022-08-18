using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.model
{
    internal class Ambulatorio
    {
        public int Nroa { get; set; }
        public int Andar { get; set; }
        public int Capacidade { get; set; }



        public override string ToString()
        {
            return

                this.Nroa + "\n" +
                this.Andar + "\n" +
                this.Capacidade + "\n" ;
        }
    }
}
