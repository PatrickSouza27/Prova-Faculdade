using AvalicaoPOO1.Funcoes_Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvalicaoPOO1.Telas
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            SetupDataGrid();
        }

        private void bbtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupDataGrid()
        {          
           string[] x = Arquivo.Ler(@"\Relatorio.txt").Split("/");
           foreach (string s in x)
           {
                string[] z = s.Split(",");
                dataGridView1.Rows.Add(z);
           }           
        }
    }
}
