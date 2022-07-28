using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class OSTHRController
    {
        public String descricaoServico;
        public String tipoServico;
        public String dataHoraGeraca;
        public String usuarioSolicitacao;
        public String statusOP;
        public String ASE;
        public String DataIdeal;
        public String Prioridade;
        public String usuarioPrioridade;
        public String dataHoraPrioridade;
        public String numeroRequisicao;
        public String nomeAutorizador;
        public String dataHoraAutorizacao;
        public String msg;

        public String numeroOSTHR;
        public String Andamento;
        public String dataHoraApontament;
        public String usuarioApontamento;
        public String dataHoraAlteracao;
        public String usuarioAlteracao;
        public String observacao;

        public String codigoPeca;
        public String descricaoPeca;
        public String QTD;
        public String unidade;
        public String nomeSolicitante;
        public String dataHoraSolicitacao;
        public String statusSolicitacao;

        public String statusRequisicao;

        public DataTable dt = new DataTable();

        public String emAberto;
        public String manIni;
        public String osINC;
        public String AutPeca;
        public String manFin;
        public String manINC;
        public String osFin;



        public String numeroStatus;

        DAO.OsTHRDAO dao = new DAO.OsTHRDAO();

        private void insertOS()
        {
            dao = new DAO.OsTHRDAO();
            dao.descricaoServico = this.descricaoServico;
            dao.tipoServico = this.tipoServico;
            dao.dataHoraGeraca = this.dataHoraGeraca;
            dao.usuarioSolicitacao = this.usuarioSolicitacao;
            dao.statusOP = this.statusOP;
            dao.insertOrdemServico(descricaoServico, tipoServico, dataHoraGeraca, usuarioSolicitacao,ASE,DataIdeal,statusOP);

            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void insertOrdemServico(String descricaoServico, String tipoServico, String dataHoraGeraca, String usuarioSolicitacao,String ASE, String DataIdeal, String statusOP)
        {
            this.descricaoServico = descricaoServico;
            this.tipoServico = tipoServico;
            this.dataHoraGeraca = dataHoraGeraca;
            this.usuarioSolicitacao = usuarioSolicitacao;
            this.ASE = ASE;
            this.DataIdeal = DataIdeal;
            this.statusOP = statusOP;
            insertOS();
        }

        public String numeroOP;
        private void selectOS()
        {

            dao.selectOrdemServico();
            this.numeroOP = dao.numeroOP;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectOrdemServico()
        {
            selectOS();
        }

        private void insertSTatusOP()
        {
            dao = new DAO.OsTHRDAO();
            dao.insertStatusOS(numeroOSTHR, Andamento, dataHoraApontament,  usuarioApontamento, dataHoraAlteracao, usuarioAlteracao, observacao);
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void insertStatusOS(String numeroOSTHR, String Andamento, String dataHoraApontament,  String usuarioApontamento, String dataHoraAlteracao, String usuarioAlteracao, String observacao)
        {
            this.numeroOSTHR = numeroOSTHR;
            this.Andamento = Andamento;
            this.dataHoraApontament = dataHoraApontament;
            this.usuarioApontamento = usuarioApontamento;
            this.dataHoraAlteracao = dataHoraAlteracao;
            this.usuarioAlteracao = usuarioAlteracao;
            this.observacao = observacao;
            insertSTatusOP();
        }

        private void SelectOSAberto()
        {
            dao = new DAO.OsTHRDAO();
            dao.selecOSAber();
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
            this.dt = dao.dt;
        }

        public void selecOSAber()
        {
            SelectOSAberto();
        }

        private void selectOSPainel()
        {
            dao = new DAO.OsTHRDAO();
            dao.selectOSTHRemAberto();
            this.dt = dao.dt;
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectOSTHRemAberto()
        {
            selectOSPainel();
        }

        private void selecStatus()
        {
            dao = new DAO.OsTHRDAO();
            dao.SelecStatusOS(numeroOSTHR);
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
            this.dt = dao.dt;
        }

        public void SelecStatusOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            selecStatus();

        }

        private void updateStatusOS()
        {
            dao = new DAO.OsTHRDAO();
            dao.dataHoraApontament = this.dataHoraApontament;
            dao.usuarioApontamento = this.usuarioApontamento;
            dao.dataHoraAlteracao = this.dataHoraAlteracao;
            dao.usuarioAlteracao = this.usuarioAlteracao;
            dao.observacao = this.observacao;
            dao.updateStatus(numeroStatus);
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }
        public void updateStatus(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            updateStatusOS();
        }

        private void selectObservacao()
        {
            dao = new DAO.OsTHRDAO();
            dao.selectOBS(numeroStatus);
            this.observacao = dao.observacao;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectOBS(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            selectObservacao();
        }

        private void loadInfoOS()
        {
            dao = new DAO.OsTHRDAO();
            dao.loadINFO(numeroOSTHR);
            this.Prioridade = dao.Prioridade;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void loadINFO(String numeroOSTHR)
        {
            dao = new DAO.OsTHRDAO();
            this.numeroOSTHR = numeroOSTHR;
            loadInfoOS();
        }

        private void selectRequisicaoPecas()
        {
            dao = new DAO.OsTHRDAO();
            dao.numeroOSTHR = this.numeroOSTHR;
            dao.selectRequisicao();
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
            else
            {
                this.usuarioApontamento = dao.usuarioApontamento;
                this.numeroStatus = dao.numeroStatus;
            }
            
        }

        public void selectRequisicao()
        {
            selectRequisicaoPecas();
        }

        private void updateRequisicaoPeca()
        {
            dao = new DAO.OsTHRDAO();
            dao.dataHoraAlteracao = this.dataHoraAlteracao;
            dao.usuarioAlteracao = this.usuarioAlteracao;
            dao.observacao = this.observacao;
            dao.numeroStatus = this.numeroStatus;

            dao.updateRequisicao();

            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void updateRequisicao()
        {
            updateRequisicaoPeca();
        }
        

        private void desfazerApontamento() 
        {
            dao = new DAO.OsTHRDAO();
            dao.dataHoraApontament = this.dataHoraApontament;
            dao.usuarioApontamento = this.usuarioApontamento;
            dao.dataHoraAlteracao = this.dataHoraAlteracao;
            dao.usuarioAlteracao = this.usuarioAlteracao;
            dao.numeroStatus = this.numeroStatus;

            dao.desfazerApont();

            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }

        }

        public void desfazerApont()
        {
            desfazerApontamento();
        }


        private void verificarPrioridade()
        {
            dao = new DAO.OsTHRDAO();
            dao.VerificarPriori(numeroOSTHR);
            this.Prioridade = dao.Prioridade;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }

        }

        public void VerificarPriori(String NumeroOSTHR)
        {
            this.numeroOSTHR = NumeroOSTHR;
            verificarPrioridade();

        }

        private void UpdatePrioridade()
        {
            dao = new DAO.OsTHRDAO();
            dao.Prioridade = this.Prioridade;
            dao.usuarioPrioridade = this.usuarioPrioridade;
            dao.dataHoraPrioridade = this.dataHoraPrioridade;
            dao.UpdatePriori(numeroOSTHR);
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }

        }

        public void UpdatePriori(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            UpdatePrioridade();
        }

        private void UpdateStatusOS()
        {
            dao = new DAO.OsTHRDAO();
            dao.status = statusOP;
            dao.UpdateStaOS(numeroOSTHR);
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void UpdateStaOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            UpdateStatusOS();
        }


        private void insertRequisicaoPeca()
        {
            dao = new DAO.OsTHRDAO();
            dao.numeroOSTHR = numeroOSTHR;
            dao.codigoPeca = codigoPeca;
            dao.descricaoPeca = descricaoPeca;
            dao.QTD = QTD;
            dao.unidade = unidade;
            dao.nomeSolicitante = nomeSolicitante;
            dao.dataHoraSolicitacao = dataHoraSolicitacao;
            dao.statusSolicitacao = statusSolicitacao;
            dao.insertRequisicaoPecas();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void insertRequisicaoPecas()
        {
            insertRequisicaoPeca();
        }

        private void selectRequisicaoPeca()
        {
            dao = new DAO.OsTHRDAO();
            dao.numeroOSTHR = numeroOSTHR;
            dao.selectPecas();
            this.dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }

        }

        public void selectPecas()
        {
            selectRequisicaoPeca();
        }

        private void SelectInfoRequisicao()
        {
            dao = new DAO.OsTHRDAO();
            dao.numeroRequisicao = numeroRequisicao;
            dao.selectInfoRequi();
            codigoPeca = dao.codigoPeca;
            descricaoPeca = dao.descricaoPeca;
            QTD = dao.QTD;
            unidade = dao.unidade;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectInfoRequi()
        {
            SelectInfoRequisicao();

        }
        private void autRequisicao()
        {
            dao = new DAO.OsTHRDAO();
            dao.numeroRequisicao = numeroRequisicao;
            dao.nomeAutorizador = nomeAutorizador;
            dao.dataHoraAutorizacao = dataHoraAutorizacao;
            dao.statusRequisicao = statusRequisicao;
            dao.autorizarRequisicao();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void autorizarRequisicao()
        {
            autRequisicao();
        }

        private void selectImpOS()
        {
            dao = new DAO.OsTHRDAO();
            dao.numeroOSTHR = numeroOSTHR;
            dao.selectImpOrdemServico();
            dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectImpOrdemServico()
        {
            selectImpOS();
        }

        private void deleteRequisicaoPeca()
        {
            dao = new DAO.OsTHRDAO();
            dao.numeroRequisicao = this.numeroRequisicao;
            dao.deleteRequisicao();

            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void deleteRequisicao()
        {
            deleteRequisicaoPeca();
        }

        public String ManIn;
        public String OSINC;
        public String AguardandoPeca;
        public String ManFIN;
        public String ManNC;
        public String OSFIN;

        private void fiterStatusOS()
        {
            dao = new DAO.OsTHRDAO();
            dao.emAberto = this.emAberto;
            dao.ManIn = this.ManIn;
            dao.OSINC = this.OSINC;
            dao.AguardandoPeca = this.AguardandoPeca;
            dao.ManFIN = this.ManFIN;
            dao.ManNC = this.ManNC;
            dao.OSINC = this.OSINC;
            dao.OSFIN = this.OSFIN;

            dao.filtrarstatusOS();

            this.dt = dao.dt;

            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void filtrarstatusOS()
        {
            fiterStatusOS();
        }

    }
}
