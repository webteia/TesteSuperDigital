using SuperApplication;
using SuperApplication.Interfaces;
using System;
using Xunit;

namespace SuperTest
{
    public class WordSwitchTest
    {
        private IWordSwitchApplication _wordSwitchApplication;

        public WordSwitchTest()
        {
            _wordSwitchApplication = new WordSwitchApplication();
        }
                
        [Fact]
        public void Quantos_Movimentos_Para_Mudar_Gato_Em_Rato()
        {
            var primeiraPalavra = "gato";
            var segundaPalavra = "rato";
            var totalMovimentos = 0;

            totalMovimentos = _wordSwitchApplication.TotalMovimentosTransmutacao(primeiraPalavra, segundaPalavra);

            Assert.Equal(1, totalMovimentos);
        }

        [Fact]
        public void Quantos_Movimentos_Para_Mudar_Cavalo_Em_Pato()
        {
            var primeiraPalavra = "cavalo";
            var segundaPalavra = "pato";
            var totalMovimentos = 0;

            totalMovimentos = _wordSwitchApplication.TotalMovimentosTransmutacao(primeiraPalavra, segundaPalavra);

            Assert.Equal(4, totalMovimentos);
        }

        [Fact]
        public void Quantos_Movimentos_Para_Mudar_Camaleao_Em_Leal_Considerando_Palavras_Sem_Acento()
        {
            var primeiraPalavra = "camaleao";
            var segundaPalavra = "leal";
            var totalMovimentos = 0;

            totalMovimentos = _wordSwitchApplication.TotalMovimentosTransmutacao(primeiraPalavra, segundaPalavra);

            Assert.Equal(5, totalMovimentos);
        }

        [Fact]
        public void Quantos_Movimentos_Para_Mudar_Camaleao_Em_Leal_Considerando_Palavras_Com_Acento()
        {
            var primeiraPalavra = "camaleão";
            var segundaPalavra = "leal";
            var totalMovimentos = 0;

            totalMovimentos = _wordSwitchApplication.TotalMovimentosTransmutacao(primeiraPalavra, segundaPalavra);

            Assert.Equal(6, totalMovimentos);
        }

        //[Fact]
        //public void Quando_Palavras_Nao_Tiverem_Mesma_Raiz_Um_Negativo_Sera_O_Esperado()
        //{
        //    var primeiraPalavra = "casa";
        //    var segundaPalavra = "pernambuco";
        //    var totalMovimentos = 0;

        //    totalMovimentos = _wordSwitchApplication.TotalMovimentosTransmutacao(primeiraPalavra, segundaPalavra);

        //    Assert.Equal(-1, totalMovimentos);
        //}

        //[Fact]
        //public void Quando_Palavras_Nao_Tiverem_Como_Ser_Transformadas_Um_Negativo_Sera_Esperado()
        //{
        //    var primeiraPalavra = "Manoel";
        //    var segundaPalavra = "Janaina";
        //    var totalMovimentos = 0;

        //    totalMovimentos = _wordSwitchApplication.TotalMovimentosTransmutacao(primeiraPalavra, segundaPalavra);

        //    Assert.Equal(-1, totalMovimentos);
        //}
    }
}
