﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Npgsql;

namespace SistemaTHR.DAO
{
    public class Connection

    {
        //NpgsqlConnection connPostGres = new Npgsql.NpgsqlConnection();
        OleDbConnection conn = new OleDbConnection();
        String conexao;

        public Connection()
        {
            //conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=//192.168.2.137/expedicao/Aqui/bd-Sistem.accdb;";


            //conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=//192.168.2.137/expedicao/Aqui/bd-Sistem.accdb;";

            //conexao = "Server=localhost ;Port=5432;Database=SistemaTHR;Uid=postgres;Pwd=POSTGRES;";

            conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\thr\\source\\repos\\SistemaTHR\\bd-Sistem.accdb;";

            // conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vitor_2\\source\\repos\\thrSistem\\bd-Sistem.accdb;";

            conn.ConnectionString = conexao;
        }

        public OleDbConnection conectar()
        {
            conn.Open();
            return conn;
        }

        public void desconectar()
        {
            conn.Close();
        }

        /*public NpgsqlConnection conPost()
        {
            connPostGres.Open();
            return connPostGres;
        }*/
    }
}
