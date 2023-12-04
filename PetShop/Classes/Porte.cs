using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Classes
{
    internal class Porte
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public DataTable ListarPorte()
        {
            string comando = "SELECT * FROM porte";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}
