namespace HerançaXComposição
{
    public class Pato : Animal
    {
        private readonly ComportamentoVoo _comportamentoVoo;

        public Pato(ComportamentoVoo comportamentoVoo)
        {
            _comportamentoVoo = comportamentoVoo;
        }
        public void Voar()
        {
            _comportamentoVoo.Voar();
        }
    }
}