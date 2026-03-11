namespace HerançaXComposição
{
    public class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Homem(ComportamentoAndar comportamentoAndar)
        {
            this._comportamentoAndar = comportamentoAndar;
        }
        public void Andar()
        {
            _comportamentoAndar.Andar();
        }
    }
}