using AvalicaoPOO1.Telas;
using System;
using System.Windows.Forms;

namespace AvalicaoPOO1
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroProdutos tela = new TelaCadastroProdutos();
            tela.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CadastrarUnidadeDeMedia().Show();
        }

        private void relatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new RelatorioUnidadeDeMedida().Show();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorio().Show();
        }
    }
}
