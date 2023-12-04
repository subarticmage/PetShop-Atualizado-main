using EasyEncryption;
using MySqlConnector;
using PetShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PetShop
{
    public partial class Servicos : Form
    {
        Classes.Funcionario usuario = new Classes.Funcionario();

        int custoporte = 0;
        int custoservico = 0;
        int custototal = 0;

        // Adicione variáveis para armazenar informações necessárias
        int idServicoSelecionado = 0;
        int idPorteSelecionado = 0;
        DateTime dataRegistro = DateTime.Now; // Altere conforme necessário

        public Servicos(Classes.Funcionario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Classes.Porte porte = new Classes.Porte();
            dgvPorte.DataSource = porte.ListarPorte();

            Classes.Servico servico = new Classes.Servico();
            dgvServico.DataSource = servico.ListarServico();
        }

        private void dgvPorte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaselecionada = dgvPorte.CurrentCell.RowIndex;
            var linha = dgvPorte.Rows[linhaselecionada];
            custoporte = int.Parse(linha.Cells[2].Value.ToString());

            // Obter informações necessárias para o cadastro
            idPorteSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaselecionada = dgvServico.CurrentCell.RowIndex;
            var linha = dgvServico.Rows[linhaselecionada];
            custoservico += int.Parse(linha.Cells[2].Value.ToString());

            // Obter informações necessárias para o cadastro
            idServicoSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnFiinalizar_Click(object sender, EventArgs e)
        {
            Classes.ListaServico lista = new Classes.ListaServico();

            // Zera os valores antes de calcular
            custoporte = 0;
            custoservico = 0;
            custototal = 0;

            // Atualiza os valores com base nas seleções
            custoporte = int.Parse(dgvPorte.Rows[dgvPorte.CurrentCell.RowIndex].Cells[2].Value.ToString());
            custoservico += int.Parse(dgvServico.Rows[dgvServico.CurrentCell.RowIndex].Cells[2].Value.ToString());

            // Calcula o total
            custototal = custoservico + custoporte;

            // Exibe o resultado na label
            lblValoor.Text = custototal.ToString();

            // Informa o usuário sobre o resultado
            MessageBox.Show($"Serviço efetuado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lista.Total = custototal;
            lista.DataRegistro = DateTime.Now;
            lista.IdFunc = usuario.Id;
            lista.IdPorte = int.Parse(dgvPorte.Rows[dgvPorte.CurrentCell.RowIndex].Cells[0].Value.ToString());
            lista.IdServico = int.Parse(dgvServico.Rows[dgvServico.CurrentCell.RowIndex].Cells[0].Value.ToString());
            lista.NomeCliente = txbNomeCliente.Text;

            // Chama o método Cadastrar com as informações necessárias
            lista.Cadastrar();
            
        }
    }
}



