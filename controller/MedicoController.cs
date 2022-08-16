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
    public class MedicoController
    {
        public void listar()
        {
            MedicosDAO medicosdao = new MedicosDAO();
            ArrayList lista = medicosdao.all();
            FmrMedicos medicos = new FmrMedicos(lista);
            medicos.Show();
        }

        public void criar(object objeto)
        {
            Medicos frMed = (Medicos)objeto;
            MedicosDAO medicosdao = new MedicosDAO();
            frMed = (Medicos)medicosdao.create(frMed);
            this.listar();
            
           

        }
        public void alterar(object objeto)
        {
            Medicos medico = (Medicos)objeto;
            edtMedico edicao = new edtMedico (medico);
            edicao.Show();
        }


        public void salvar(object objeto)
        {
             Medicos medicos = (Medicos)objeto;

             MedicosDAO medicosdao = new MedicosDAO();

             medicos = (Medicos)medicosdao.update(medicos);

             ArrayList todos = medicosdao.all();
             FmrMedicos listagem = new FmrMedicos(todos);
             listagem.Show();

        }

        internal void deletar(object objeto)
        {
                Medicos medicos = (Medicos)objeto;

            
                MedicosDAO medicosdao = new MedicosDAO();
                medicosdao.delete(medicos);

                new FmrMedicos(medicosdao.all()).Show();

        }
    }
}


