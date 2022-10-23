using AvalicaoPOO1.Funcoes_Auxiliares;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AvalicaoPOO1.Entities
{
    public class Produto 
    {
        public string UnidadeDeMedida { get; private set; }
        public double Price { get; private set; }
        public string Descricao { get; private set; }
        public Produto()
        {

        }
        public Produto(string unidadeDeMedida, double price, string descricao)
        {
            UnidadeDeMedida = unidadeDeMedida;
            Price = price;
            Descricao = descricao;
        }

        public string LerProduto()
        {
            try
            {
                Arquivo.Gravar(@"\Relatorio.txt", Descricao + "," + UnidadeDeMedida.ToString() + "," + Price.ToString() + "/");
                return "Arquivo Gravado com sucesso!";
            }
            catch
            {
                return "ERROR! erro ao gravar o arquivo";
            }
            
        }
    }
}
