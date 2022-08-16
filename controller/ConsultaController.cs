using Clinica.DAO;
using Clinica.model;
using Clinica.view;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class ConsultaController : IController
    {
        public void alterar(object objeto)
        {
            throw new NotImplementedException();
        }
        public void preparaCriacao()
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            MedicosDAO medicoDAO = new MedicosDAO();
            ArrayList pacientes, medicos;
            medicos = medicoDAO.all();
            pacientes = pacienteDAO.all();
            criarConsulta tela = new criarConsulta(medicos, pacientes);
            tela.Show();
        }
        public void preparaEdicao(object objeto)
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            MedicosDAO medicoDAO = new MedicosDAO();
            ArrayList pacientes, medicos;
            medicos = medicoDAO.all();
            pacientes = pacienteDAO.all();
            Consulta c = (Consulta)objeto;
            c.medicos = (Medicos)medicoDAO.read(c.medicos);
            c.paciente = (Paciente)pacienteDAO.read(c.paciente);
            edtConsulta tela = new edtConsulta(medicos, pacientes, objeto);
            tela.Show();
        }
        public void criar(object objeto)
        {
            Consulta consulta = (Consulta) objeto;
            ConsultaDAO consultaDAO = new ConsultaDAO();
            consultaDAO.create(consulta);

            ArrayList lista = consultaDAO.all();

            FmrConsulta tela = new FmrConsulta(lista);
            tela.Show();
        }

        public void deletar(object objeto)
        {
            throw new NotImplementedException();
        }

        public void listar()
        {
            ConsultaDAO dao = new ConsultaDAO();
            ArrayList lista = dao.all();
            FmrConsulta tela = new FmrConsulta(lista);
            tela.Show();
            
        }

        public void salvar(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
