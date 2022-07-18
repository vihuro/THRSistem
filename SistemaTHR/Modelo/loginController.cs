using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR
{
    internal class loginController
    {
        public bool tem;
        public string menssagem;
        public String usuario;
        public String Empilhadeiras = "Não";
        public String EmpNivel = "0";
        public String Recebimento = "Não";
        public String RecebNivel = "0";
        public String Expedicao = "Não";
        public String ExpNivel = "0";
        public String Adm = "Não";
        public String AdmNivel = "0";
        public String nomeUsuario;
        public String manutencao;
        public String manutencaoNivel;
        public String senha;

        public bool aceesar(String nome, String senha)
        {
            DAO.LoginDao loginDao = new DAO.LoginDao();
            tem = loginDao.verificar(nome, senha);

            if (!loginDao.menssagem.Equals(""))
            {
                this.menssagem = loginDao.menssagem;
            }
            return tem;
        }

        private void verificarNivel()
        {
            DAO.LoginDao loginDao = new DAO.LoginDao();
            loginDao.verificarNivel(usuario);
            this.usuario = loginDao.usuario;
            this.Empilhadeiras = loginDao.Empilhadeiras;
            this.EmpNivel = loginDao.EmpNivel;
            this.Recebimento = loginDao.Recebimento;
            this.RecebNivel = loginDao.RecebNivel;
            this.Expedicao = loginDao.Expedicao;
            this.ExpNivel = loginDao.ExpNivel;
            this.Adm = loginDao.Adm;
            this.AdmNivel = loginDao.AdmNivel;
            this.manutencao = loginDao.manutencao;
            this.manutencaoNivel = loginDao.manutencaoNivel;

        }
        public void verificarNivel(String usuario)
        {
            this.usuario = usuario;
            verificarNivel();
        }

        public DataTable dt = new DataTable();

        private void loadUsuario()
        {
            DAO.LoginDao login = new DAO.LoginDao();
            login.loadUser();
            this.dt = login.dt;

        }
        public void loadUser()
        {
            loadUsuario();

        }

        private void loadInformacoes()
        {
            DAO.LoginDao loginDao = new DAO.LoginDao();
            loginDao.loadInfo(usuario);

            this.Empilhadeiras = loginDao.Empilhadeiras;
            this.EmpNivel = loginDao.EmpNivel;
            this.Recebimento = loginDao.Recebimento;
            this.RecebNivel = loginDao.RecebNivel;
            this.Expedicao = loginDao.Expedicao;
            this.ExpNivel = loginDao.ExpNivel;
            this.Adm = loginDao.Adm;
            this.AdmNivel = loginDao.AdmNivel;

            


        }

        public void loadInfo(String usuario)
        {
            this.usuario = usuario;
            loadInformacoes();

        }

        private void SelectNome()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.SelecNomeUsuario(usuario);
            this.nomeUsuario = dao.nomeUsuario;

        }

        public void SelecNomeUsuario(String usuario)
        {
            this.usuario = usuario;
            SelectNome();
        }

        private void selectNome()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.usuario = usuario;
            dao.selectNomeUsuario();
            this.nomeUsuario = dao.nomeUsuario;
            this.senha = dao.senha;

        }

        public void selectNomeUsuario()
        {
            selectNome();
        }

        private void updateUsuario()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.nomeUsuario = nomeUsuario;
            dao.usuario = usuario;
            dao.updateUser();
        }

        public void updateUser()
        {
            updateUsuario();
        }

        private void updateModulosUser()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.usuario = usuario;
            dao.nomeUsuario = nomeUsuario;
            dao.Empilhadeiras = Empilhadeiras;
            dao.EmpNivel = EmpNivel;
            dao.Recebimento = Recebimento;
            dao.RecebNivel = RecebNivel;
            dao.Expedicao = Expedicao;
            dao.ExpNivel = ExpNivel;
            dao.Adm = Adm;
            dao.AdmNivel = AdmNivel;
            dao.manutencao = manutencao;
            dao.manutencaoNivel = manutencaoNivel;
            dao.uptadeModulosUsuario();
        }

        public void uptadeModulosUsuario()
        {
            updateModulosUser();
        }

        private void verificarUser()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.usuario = usuario;
            dao.verificarUsuario();
            tem = dao.tem;
        }

        public void verificarUsuario()
        {
            verificarUser();
        }

        private void insertUser()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.usuario = usuario;
            dao.nomeUsuario = nomeUsuario;
            dao.senha = senha;
            dao.inserUsuario();
        }

        public void inserUsuario()
        {
            insertUser();
        }

        private void insertModulos()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.usuario = usuario;
            dao.Empilhadeiras = Empilhadeiras;
            dao.EmpNivel = EmpNivel;
            dao.Recebimento = Recebimento;
            dao.RecebNivel = RecebNivel;
            dao.Expedicao = Expedicao;
            dao.ExpNivel = ExpNivel;
            dao.Adm = Adm;
            dao.AdmNivel = AdmNivel;
            dao.manutencao = manutencao;
            dao.manutencaoNivel = manutencaoNivel;
            dao.insertMod();

        }

        public void insertMod()
        {
            insertModulos();
        }
    }
}
