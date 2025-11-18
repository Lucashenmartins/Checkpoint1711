namespace IRRFCalculator
{
    public class FaixaINSS
    {
        public double LimiteInferior { get; set; }
        public double LimiteSuperior { get; set; }
        public double Aliquota { get; set; }
        
        public FaixaINSS(double limiteInferior, double limiteSuperior, double aliquota)
        {
            LimiteInferior = limiteInferior;
            LimiteSuperior = limiteSuperior;
            Aliquota = aliquota;
        }
    }

    public class TabelaINSS
    {
        private List<FaixaINSS> faixas;
        
        public TabelaINSS()
        {
            // Tabela INSS 2024
            faixas = new List<FaixaINSS>
            {
                new FaixaINSS(0, 1412.00, 0.075),
                new FaixaINSS(1412.01, 2666.68, 0.09),
                new FaixaINSS(2666.69, 4000.03, 0.12),
                new FaixaINSS(4000.04, 7786.02, 0.14)
            };
        }
        
        public List<FaixaINSS> ObterFaixas()
        {
            return faixas;
        }
    }
}