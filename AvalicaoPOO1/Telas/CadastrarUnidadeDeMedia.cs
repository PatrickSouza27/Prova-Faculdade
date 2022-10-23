using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvalicaoPOO1.Telas;
using AvalicaoPOO1.Funcoes_Auxiliares;
using AvalicaoPOO1.Entities;

namespace AvalicaoPOO1.Telas
{
    public partial class CadastrarUnidadeDeMedia : Form
    {
        public CadastrarUnidadeDeMedia()
        {
            InitializeComponent();
        }

        private void bbtCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ttbDescricaoMedida.Text))
            {
                Medida medida = new Medida(ttbDescricaoMedida.Text);
                MessageBox.Show(medida.LerMedida());
                ttbDescricaoMedida.Clear();              
            }
            else
            {
                MessageBox.Show("O campo não pode ser vazio!");
            }
            
        }

        private void bbtLimpar_Click(object sender, EventArgs e)
        {
            ttbDescricaoMedida.Clear();
        }

        private void bbtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
