namespace IRRFCalculator
{
    public class FaixaIRRF
    {
        public double Limite { get; set; }
        public double Aliquota { get; set; }
        public double Deducao { get; set; }
        
        public FaixaIRRF(double limite, double aliquota, double deducao)
        {
            Limite = limite;
            Aliquota = aliquota;
            Deducao = deducao;
        }
    }
}