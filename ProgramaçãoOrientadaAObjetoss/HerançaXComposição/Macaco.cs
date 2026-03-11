namespace HerançaXComposição
{
    public class Macaco : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Macaco(ComportamentoAndar comportamentoAndar)
        {
            this._comportamentoAndar = comportamentoAndar;
        }
        public void Andar()
        {
            _comportamentoAndar.Andar();
        }
    }
}