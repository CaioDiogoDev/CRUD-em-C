using Clinica.DAO;
using Clinica.model;
using Clinica.view;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.controller
{
    internal class AmbulatorioController
    {
        public void listar()
        {
            AmbulatorioDAO ambulatoriodao = new AmbulatorioDAO();
            ArrayList lista = ambulatoriodao.all();
            FmrAmbulatorio ambulatorio = new FmrAmbulatorio(lista);
            ambulatorio.Show();
        }

        public void criar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            AmbulatorioDAO ambulatoriodao = new AmbulatorioDAO();
            ambulatorio = (Ambulatorio)ambulatoriodao.create(ambulatorio);
            this.listar();



        }
        public void alterar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            edtAmbulatorio edicao = new edtAmbulatorio(ambulatorio);
            edicao.Show();
        }


        public void salvar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;

            AmbulatorioDAO ambulatoriodao = new AmbulatorioDAO();

            ambulatorio = (Ambulatorio)ambulatoriodao.update(ambulatorio);

            ArrayList todos = ambulatoriodao.all();
            FmrAmbulatorio listagem = new FmrAmbulatorio(todos);
            listagem.Show();

        }

        internal void deletar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;

            AmbulatorioDAO ambulatoriodao = new AmbulatorioDAO();
            ambulatoriodao.delete(ambulatorio);

            new FmrAmbulatorio(ambulatoriodao.all()).Show();

        }
    }
}
