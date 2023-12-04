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
    public partial class ListarServicos : Form
    {
        public ListarServicos()
        {
            InitializeComponent();
            Classes.ListaServico servico = new Classes.ListaServico();
            dgvListaServico.DataSource = servico.ListarFinalizados();

            txbVendas.Text = dgvListaServico.RowCount.ToString();
        }
    }
}
