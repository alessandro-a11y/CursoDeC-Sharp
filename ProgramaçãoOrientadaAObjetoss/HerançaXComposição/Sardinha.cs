namespace HerançaXComposição
{
    public class Sardinha : Animal
    {
        private readonly ComportamentoNadar _comportamentoNadar;
        public Sardinha(ComportamentoNadar comportamentoNadar)
        {
            this._comportamentoNadar = comportamentoNadar;
        }
        public void Nadar()
        {
            _comportamentoNadar.Nadar();
        }
    }
}