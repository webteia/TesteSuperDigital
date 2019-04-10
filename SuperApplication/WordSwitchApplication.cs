using SuperApplication.Interfaces;
using System;

namespace SuperApplication
{
    public class WordSwitchApplication : IWordSwitchApplication
    {
        public int TotalMovimentosTransmutacao(string primeiraPalavra, string segundaPalavra)
        {
            //if (!VerificaSeExisteSemelhancaEntreAsPalavras(primeiraPalavra, segundaPalavra))
            //    return -1;

            var totalDeCaracteresDaPrimeiraPalavra = primeiraPalavra.Length;
            var totalDeCaracteresDaSegundaPalavra = segundaPalavra.Length;

            int[,] vetorComOsCaracteresDasPalavras = new int[totalDeCaracteresDaPrimeiraPalavra + 1, totalDeCaracteresDaSegundaPalavra + 1];
            int i, j;

            for (i = 0; i <= totalDeCaracteresDaPrimeiraPalavra; i++)
            {
                for (j = 0; j <= totalDeCaracteresDaSegundaPalavra; j++)
                {
                    if (i == 0 || j == 0)
                        vetorComOsCaracteresDasPalavras[i, j] = 0;

                    else if (primeiraPalavra[i - 1] == segundaPalavra[j - 1])
                        vetorComOsCaracteresDasPalavras[i, j] = vetorComOsCaracteresDasPalavras[i - 1, j - 1] + 1;

                    else
                        vetorComOsCaracteresDasPalavras[i, j] = Math.Max(vetorComOsCaracteresDasPalavras[i - 1, j],
                                           vetorComOsCaracteresDasPalavras[i, j - 1]);
                }
            }
                        
            if (totalDeCaracteresDaSegundaPalavra >= totalDeCaracteresDaPrimeiraPalavra)
                return totalDeCaracteresDaSegundaPalavra - vetorComOsCaracteresDasPalavras[totalDeCaracteresDaPrimeiraPalavra, totalDeCaracteresDaSegundaPalavra];
            else
                return totalDeCaracteresDaPrimeiraPalavra - vetorComOsCaracteresDasPalavras[totalDeCaracteresDaPrimeiraPalavra, totalDeCaracteresDaSegundaPalavra];
        }

        public bool VerificaSeExisteSemelhancaEntreAsPalavras(string primeiraPalavra, string segundaPalavra)
        {            
            char[] char1 = primeiraPalavra.ToLower().ToCharArray();
            char[] char2 = segundaPalavra.ToLower().ToCharArray();
                        
            Array.Sort(char1);
            Array.Sort(char2);
                        
            string novaPrimeiraPalavra = new string(char1);
            string novaSegundaPalavra = new string(char2);

            return novaPrimeiraPalavra == novaSegundaPalavra;
        }
    }

}
