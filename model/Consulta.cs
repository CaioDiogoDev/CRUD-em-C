using Clinica.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Consulta
    {
 
        public Paciente paciente { get; set; }
        public Medicos medicos { get; set; }
        public DateTime dataHora { get; set; }
    }
}
