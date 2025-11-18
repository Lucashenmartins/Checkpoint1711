namespace IRRFCalculator
{
    public class TabelaIRRF
    {
        private List<FaixaIRRF> faixas;
        
        public TabelaIRRF()
        {
            faixas = new List<FaixaIRRF>
            {
                new FaixaIRRF(2428.80, 0.0, 0.0),
                new FaixaIRRF(2826.65, 0.075, 169.44),
                new FaixaIRRF(3751.05, 0.15, 394.16),
                new FaixaIRRF(4664.68, 0.225, 675.49),
                new FaixaIRRF(double.MaxValue, 0.275, 908.73)
            };
        }
        
        public FaixaIRRF EncontrarFaixa(double salarioBase)
        {
            foreach (var faixa in faixas)
            {
                if (salarioBase <= faixa.Limite)
                    return faixa;
            }
            return faixas[faixas.Count - 1];
        }
    }
}