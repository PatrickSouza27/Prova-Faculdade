using AvalicaoPOO1.Entities;
using AvalicaoPOO1.Funcoes_Auxiliares;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AvalicaoPOO1.Telas
{
    public partial class TelaCadastroProdutos : Form
    {
        public TelaCadastroProdutos()
        {
            InitializeComponent();
            CarregarComboUnidadeMedida();
        }

        private void CarregarComboUnidadeMedida()
        {
            cbbUnidadeMedida.Items.Add("--SELECIONE--");
            string[] x = Arquivo.Ler(@"\MedidaARQ.txt").Split(",");
            foreach (string str in x)
            {
                cbbUnidadeMedida.Items.Add(str);
            }
            cbbUnidadeMedida.SelectedItem = "--SELECIONE--";
            cbbUnidadeMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            //Não esqueça de chamar o comboBox na inicialização da sua tela!
        }

        private void LimparTela()
        {
            ttbDescricao.Clear();
            ttbValorUnitario.Clear();
            cbbUnidadeMedida.SelectedItem = "--SELECIONE--";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
            => LimparTela();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> error = new List<string>();
            if (string.IsNullOrEmpty(ttbDescricao.Text)){
                error.Add("Vazio Descrição!");
            }
            if (string.IsNullOrEmpty(ttbValorUnitario.Text)){
                error.Add("Vazio Valor!");
            }
            if(double.TryParse(ttbValorUnitario.Text, out double valor) && valor > 0)
            {

            }
            else
            {
                error.Add("Valor Invalido!");
            }
            if(cbbUnidadeMedida.Text == "--SELECIONE--")
            {
                error.Add("Selecione Opção!");
            }
            if (error.Count > 0)
            {
                string TotErros = " ";
                foreach (var errors in error)
                {
                    TotErros += errors + "\n";
                }
                MessageBox.Show(TotErros);
            }
            else
            {
                Produto produto = new Produto(cbbUnidadeMedida.Text, valor, ttbDescricao.Text);
                MessageBox.Show(produto.LerProduto());
                LimparTela();
            }           
        }

        private void bbtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
