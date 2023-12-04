using PetShop.Classes;
using PetShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Menu : Form
    {
        // Objetos globais:
        Classes.Funcionario usuario = new Classes.Funcionario();
        public Menu(Classes.Funcionario usuario)
        {
            InitializeComponent();

            // Atribuir o usuário local no global:
            this.usuario = usuario; 
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            Servicos janela = new Servicos(usuario);
            janela.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Caixa janela = new Caixa();
            janela.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ListarServicos janela = new ListarServicos();
            janela.Show();
        }
    }
}
