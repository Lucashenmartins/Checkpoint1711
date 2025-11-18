namespace IRRFCalculator
{
    public class CalculadoraIRRF
    {
        private TabelaIRRF tabela;
        private CalculadoraINSS calculadoraINSS;
        
        public CalculadoraIRRF()
        {
            tabela = new TabelaIRRF();
            calculadoraINSS = new CalculadoraINSS();
        }
        
        public ResultadoCalculo CalcularIRRFCompleto(double salarioBruto)
        {
            // Calcula INSS automaticamente
            double descontoINSS = calculadoraINSS.Calcular(salarioBruto);
            double salarioBase = salarioBruto - descontoINSS;
            
            // Encontra a faixa do IRRF
            FaixaIRRF faixa = tabela.EncontrarFaixa(salarioBase);
            
            // Calcula o IRRF
            double calculoParcial = salarioBase * faixa.Aliquota;
            double irrf = Math.Max(0.0, calculoParcial - faixa.Deducao);
            
            return new ResultadoCalculo
            {
                SalarioBruto = salarioBruto,
                DescontoINSS = descontoINSS,
                SalarioBase = salarioBase,
                FaixaIRRF = faixa,
                CalculoParcial = calculoParcial,
                IRRF = Math.Round(irrf, 2),
                SalarioLiquido = salarioBruto - descontoINSS - Math.Round(irrf, 2)
            };
        }
    }

    public class ResultadoCalculo
    {
        public double SalarioBruto { get; set; }
        public double DescontoINSS { get; set; }
        public double SalarioBase { get; set; }
        public FaixaIRRF FaixaIRRF { get; set; }
        public double CalculoParcial { get; set; }
        public double IRRF { get; set; }
        public double SalarioLiquido { get; set; }
        
        public void ImprimirDetalhes()
        {
            Console.WriteLine("\n=== CÁLCULO COMPLETO ===");
            Console.WriteLine($"Salário Bruto: R$ {SalarioBruto:F2}");
            Console.WriteLine($"Desconto INSS: R$ {DescontoINSS:F2}");
            Console.WriteLine($"Salário Base (IRRF): R$ {SalarioBase:F2}");
            Console.WriteLine($"Faixa IRRF: {FaixaIRRF.Aliquota * 100}%");
            Console.WriteLine($"Cálculo Parcial: R$ {CalculoParcial:F2}");
            Console.WriteLine($"Dedução IRRF: R$ {FaixaIRRF.Deducao:F2}");
            Console.WriteLine($"IRRF a recolher: R$ {IRRF:F2}");
            Console.WriteLine($"SALÁRIO LÍQUIDO: R$ {SalarioLiquido:F2}");
        }
    }
}