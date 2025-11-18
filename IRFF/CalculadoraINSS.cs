namespace IRRFCalculator
{
    public class CalculadoraINSS
    {
        public double Calcular(double salarioBruto)
        {
            // Cálculo progressivo correto do INSS
            double descontoINSS = 0.0;
            
            if (salarioBruto <= 1412.00)
            {
                descontoINSS = salarioBruto * 0.075;
            }
            else if (salarioBruto <= 2666.68)
            {
                descontoINSS = (1412.00 * 0.075) + ((salarioBruto - 1412.00) * 0.09);
            }
            else if (salarioBruto <= 4000.03)
            {
                descontoINSS = (1412.00 * 0.075) + 
                              ((2666.68 - 1412.00) * 0.09) + 
                              ((salarioBruto - 2666.68) * 0.12);
            }
            else
            {
                double teto = 7786.02;
                double salarioParaCalculo = Math.Min(salarioBruto, teto);
                
                descontoINSS = (1412.00 * 0.075) + 
                              ((2666.68 - 1412.00) * 0.09) + 
                              ((4000.03 - 2666.68) * 0.12) + 
                              ((salarioParaCalculo - 4000.03) * 0.14);
            }
            
            return Math.Round(descontoINSS, 2);
        }
    }
}