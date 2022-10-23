using AvalicaoPOO1.Entities;
using AvalicaoPOO1.Funcoes_Auxiliares;
using System;
using System.Collections;
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
    public partial class RelatorioUnidadeDeMedida : Form
    {
        public RelatorioUnidadeDeMedida()
        {
            InitializeComponent();
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            string[] x = Arquivo.Ler(@"\MedidaARQ.txt").Split(",");
            foreach (string s in x)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void bbtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
