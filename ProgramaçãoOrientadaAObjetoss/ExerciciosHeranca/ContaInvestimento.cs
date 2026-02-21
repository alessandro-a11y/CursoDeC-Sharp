namespace ExerciciosHeranca
{
    class ContaInvestimento : Conta
    {
        public override void DepositarValor(decimal valor)
        {
            base.DepositarValor(valor);
            if (valor > 0)
            {
                decimal rendimento = valor * 0.009m;
                saldo += rendimento;
                Console.WriteLine($"Seu rendimento: {rendimento}");
            }

        }
        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido para saque.");
            }
            else
            {
                decimal imposto = valor * 0.001m;
                var total = valor + imposto;

                if (saldo < total)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                else
                {
                    saldo -= total;
                    Console.WriteLine($"Imposto atual: {imposto}");
                    Console.WriteLine($"Saldo final: {saldo}");
                }
            }
        }
    }
}