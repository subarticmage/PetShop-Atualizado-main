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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Instanciar um usuario: 
            Classes.Funcionario usuario = new Classes.Funcionario();
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            // Obter o resultado do SELECT no banco: 
            var resultado = usuario.Logar();

            if (resultado.Rows.Count == 1)
            {
                // Senha correta: Prosseguir
                usuario.Nome = resultado.Rows[0]["nome"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                // Proximo passo: abrir a janela menu:
                Menu janela = new Menu(usuario);
                // Limpar os campos de login:
                txbEmail.Clear();
                txbSenha.Clear();
                // Esconder a janela atual:
                this.Hide();
                // Mostrar o menu:
                janela.ShowDialog();
                // Mostar o login quando o menu fechar:
                this.Show();
            }
            else
            {
                // Senha incorreta:
                MessageBox.Show("Email ou senha incorretos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
