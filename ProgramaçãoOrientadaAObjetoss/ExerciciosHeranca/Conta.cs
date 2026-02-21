namespace ExerciciosHeranca
{
    class Conta
    {
        private int numero { get; set; }
        private string? NomeCliente { get; set; }
        protected decimal saldo { get; set; }

        public virtual void DepositarValor(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Saldo impossivel para depósito");
            }
            else
            {
                Console.WriteLine($"{valor} adicionado a conta!");

                saldo = saldo + valor;


            }
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Inválido!");
            }
            else if (saldo < valor)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            else
            {
                Console.WriteLine($"Saque realizado com sucesso!");
                saldo = saldo - valor;
                Console.WriteLine($"Saldo atual: {saldo}");

            }
        }
        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Valor atual: {saldo}");
        }
    }
}