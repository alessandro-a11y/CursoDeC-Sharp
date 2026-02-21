namespace ExerciciosHeranca
{
    class ContaPoupaca : Conta
    {
        public override void DepositarValor(decimal valor)
        {
            base.DepositarValor(valor);

            if (valor > 0)
            {
                decimal rendimento = valor * 0.005m;
                saldo += rendimento;

                Console.WriteLine($"Seu rendimento: {rendimento}");
            }
        }
    }
}