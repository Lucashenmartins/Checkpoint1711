namespace IRRFCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA COMPLETA INSS + IRRF ===\n");
            
            var calculadoraIRRF = new CalculadoraIRRF();
            
            double salarioBruto = 3000.00;
            
            var resultado = calculadoraIRRF.CalcularIRRFCompleto(salarioBruto);
            resultado.ImprimirDetalhes();
            
            Console.WriteLine("\n=== TESTES ADICIONAIS ===");
            Console.WriteLine("Salário Bruto | INSS      | Base IRRF  | IRRF      | Líquido");
            Console.WriteLine("--------------|-----------|------------|-----------|-----------");
            
            double[] salariosTeste = { 2000.00, 3000.00, 3500.00, 5000.00, 8000.00, 10000.00 };
            
            foreach (var salario in salariosTeste)
            {
                var result = calculadoraIRRF.CalcularIRRFCompleto(salario);
                Console.WriteLine($"R$ {salario,8:F2}   | R$ {result.DescontoINSS,6:F2} | R$ {result.SalarioBase,7:F2} | R$ {result.IRRF,6:F2} | R$ {result.SalarioLiquido,7:F2}");
            }
        }
    }
}