using System.IO;

namespace AvalicaoPOO1.Funcoes_Auxiliares
{
    public static class Arquivo
    {
        static string CaminhoBase = @"Colar Aqui O Caminho Até a Pasta Arquivos!";

        public static bool Gravar(string nomeArquivo, string info)
        {
            try
            {
                File.AppendAllText(CaminhoBase + nomeArquivo, info);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string Ler(string nomeArquivo)
          => File.ReadAllText(CaminhoBase + nomeArquivo).ToString();

        public static bool VerificaSeExiste(string nomeArquivo, string chaveBusca)
          => Ler(nomeArquivo).Contains(chaveBusca);
    }
}
