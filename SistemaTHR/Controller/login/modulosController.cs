using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.Login
{
    public class modulosController
    {
        private String msg;
        private String usuario;
        private String empilhadeiras = "Não";
        private String empNivel;
        private String recebimento = "Não";
        private String recebNivel;
        private String expedicao = "Não";
        private String expNivel;
        private String adm = "Não";
        private String admNivel;
        private String manutencao = "Não";
        private String manutencaoNivel;
        private String producao = "Não";
        private String producaoNivel;
        private String almoxarifado = "Não";
        private String almoxarifadoNivel;
        private String estoque = "Não";
        private String estoqueNivel;
        private String compras = "Não";
        private String comprasNivel;
        private DataTable dt;

        public String Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public String Empilhadeiras
        {
            get { return empilhadeiras; }
            set { empilhadeiras = value; }
        }
        public String EmpNivel
        {
            get { return empNivel; }
            set { empNivel = value; }
        }
        public String Recebimento
        {
            get { return recebimento; }
            set { recebimento = value; }
        }
        public String RecebNivel
        {
            get { return recebNivel; }
            set { recebNivel = value; }
        }
        public String Expedicao
        {
            get { return expedicao; }
            set
            {
                expedicao = value;
            }
        }
        public String ExpNivel
        {
            get { return expNivel; }
            set { expNivel = value; }
        }
        public String Adm
        {
            get { return adm; }
            set { adm = value; }
        }
        public String AdmNivel
        {
            get { return admNivel; }
            set
            {
                admNivel = value;
            }
        }
        public String Manutencao
        {
            get { return manutencao; }
            set
            {
                manutencao = value;
            }
        }
        public String ManutencaoNivel
        {
            get { return manutencaoNivel; }
            set
            {
                manutencaoNivel = value;
            }
        }
        public String Producao
        {
            get { return producao; }
            set { producao = value; }
        }
        public String ProducaoNivel
        {
            get { return producaoNivel; }
            set { producaoNivel = value; }
        }
        public String Almoxarifado
        {
            get { return almoxarifado; }
            set { almoxarifado = value; }
        }
        public String AlmoxarifadoNivel
        {
            get { return almoxarifadoNivel; }
            set { almoxarifadoNivel = value;}
        }
        public String Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        public String EstoqueNivel
        {
            get { return estoqueNivel; }
            set { estoqueNivel = value; }
        }
        public DataTable Dt
        {

            get { return dt; }
            set { dt = value; }
        }

        public string Compras { get => compras; set => compras = value; }
        public string ComprasNivel { get => comprasNivel; set => comprasNivel = value; }
    }
}

