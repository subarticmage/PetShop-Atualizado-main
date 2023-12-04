using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PetShop.Classes
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public DataTable Logar()
        {
            string comando = "SELECT id, nome, email, senha" +
                " FROM funcionario WHERE email = @email AND senha = @senha";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            // Substituir os 'coringas' por valores:
            cmd.Parameters.AddWithValue("@email", Email);
            // Obter o hash da senha:
            var hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
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
