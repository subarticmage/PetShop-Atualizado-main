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

namespace PetShop.Views
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
            Classes.ListaServico servico = new Classes.ListaServico();
            dgvServico.DataSource = servico.ListarServico();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obter a linha clicada:
            int linhaSelecionada = dgvServico.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
            var linha = dgvServico.Rows[linhaSelecionada];

            lblValor.Text =$"R$ " + linha.Cells[5].Value.ToString();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {

            var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                
                Classes.ListaServico lista = new Classes.ListaServico();
               

                // Obter a linha clicada:
                int linhaSelecionada = dgvServico.CurrentCell.RowIndex;

                // Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
                var linha = dgvServico.Rows[linhaSelecionada];

                lista.Id = int.Parse(linha.Cells[0].Value.ToString());
                if (lista.EncerrarFicha() == true)
                {
                    MessageBox.Show("Ficha encarreda!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Atualizar o dgv:
                dgvServico.DataSource = lista.ListarServico();
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbPagamento.Checked;
        }

        private void dgvServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
