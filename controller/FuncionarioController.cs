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
    internal class FuncionarioController
    {

        public void listar()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            ArrayList lista = funcionarioDAO.all();
            FmrFuncionarios medicos = new FmrFuncionarios(lista);
            medicos.Show();
        }

        public void criar(object objeto)
        {
            Funcionarios fun = (Funcionarios)objeto;
            FuncionarioDAO funDao = new FuncionarioDAO();
            fun = (Funcionarios)funDao.create(fun);

            this.listar();



        }
        public void alterar(object objeto)
        {
            Funcionarios fun = (Funcionarios)objeto;
            edtFuncionarios edicao = new edtFuncionarios(fun);
            edicao.Show();
        }


        public void salvar(object objeto)
        {
            Funcionarios fun = (Funcionarios)objeto;

            FuncionarioDAO funDao = new FuncionarioDAO();

            fun = (Funcionarios)funDao.update(fun);

            ArrayList todos = funDao.all();
            FmrFuncionarios listagem = new FmrFuncionarios(todos);
            listagem.Show();

        }

        internal void deletar(object objeto)
        {

            Funcionarios fun = (Funcionarios)objeto;
            FuncionarioDAO funDao = new FuncionarioDAO();

            funDao.delete(fun);

            new FmrFuncionarios(funDao.all()).Show();

        }
    }
}
