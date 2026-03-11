using System;
namespace HerançaXComposição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComportamentoAndar comportamentoAndar = new ComportamentoAndar();
            ComportamentoNadar comportamentoNadar = new ComportamentoNadar();
            ComportamentoVoo  comportamentoVoo = new ComportamentoVoo();

            Macaco macaco = new Macaco(comportamentoAndar);
            macaco.Andar();
            Homem homem = new Homem(comportamentoAndar);
            homem.Andar();
            Pato pato = new Pato(comportamentoVoo);
            pato.Voar();
            Sardinha sardinha = new Sardinha(comportamentoNadar);
            sardinha.Nadar();

        }
    }
}