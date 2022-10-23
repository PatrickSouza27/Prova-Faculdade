using AvalicaoPOO1.Funcoes_Auxiliares;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace AvalicaoPOO1.Entities
{
    public class Medida
    {
        public string UnidadeDeMedida { get; private set; }
        public Medida()
        {

        }
        public Medida(string unidadeDeMedida)
        {
            UnidadeDeMedida = unidadeDeMedida;
        }   

        public string LerMedida()
        {
            if (Arquivo.VerificaSeExiste(@"\MedidaARQ.txt", UnidadeDeMedida.ToString()) == true)
            {
                return "ERROR!, Arquivo já existe!";
            }
            else
            {
                Arquivo.Gravar(@"\MedidaARQ.txt", UnidadeDeMedida.ToString() + ",");
                return "Arquivo Gravado com sucesso!";
            }
        }

        
    }
}
