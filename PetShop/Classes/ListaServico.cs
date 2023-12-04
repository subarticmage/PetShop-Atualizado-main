using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Classes
{
    internal class ListaServico
    {
        public int Id { get; set; }
        public int IdServico { get; set; }
        public string NomeCliente { get; set; }
        public int IdPorte { get; set; }
        public DateTime DataRegistro { get; set; }
        public int IdFunc { get; set; }
        public int Total { get; set; }
        public int Situacao { get; set; }

        public bool EncerrarFicha()
        {
            string comando = "UPDATE lista_servico SET situacao = 0 " +
               "WHERE id = @id AND situacao = 1";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public DataTable ListarServico()
        {
            string comando = "SELECT * FROM view_servico WHERE Situaçao != 'Finalizado' Collate utf8mb4_general_ci";

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
        public DataTable ListarFinalizados()
        {
            string comando = "SELECT * FROM view_servico WHERE Situaçao != 'Aberto' Collate utf8mb4_general_ci";

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
        public bool Cadastrar()
        {
            string comando = "INSERT INTO lista_servico (id_servico,nome_cliente, id_porte, data_registro, id_func, total) " +
                "VALUES (@id_servico, @nome_cliente, @id_porte, @data_registro, @id_func, @total)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_servico", IdServico);
            cmd.Parameters.AddWithValue("@nome_cliente", NomeCliente);
            cmd.Parameters.AddWithValue("@id_porte", IdPorte);
            cmd.Parameters.AddWithValue("@data_registro", DataRegistro);
            cmd.Parameters.AddWithValue("@id_func", IdFunc);
            cmd.Parameters.AddWithValue("@total", Total);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}

