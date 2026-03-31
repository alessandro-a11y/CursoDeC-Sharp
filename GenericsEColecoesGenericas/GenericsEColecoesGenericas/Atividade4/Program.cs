using System;
using System.Collections.Generic;
using System.Threading;

namespace Atividade4
{
    internal class Program
    {
        // Substituir o campo 'object random' por um Random inicializado para poder chamar Next()
        private static Random random = new Random();

        static void Main(string[] args)
        {
            //  variável do tipo Queue<string> para representar a fila de impressão. 
            Queue<string> filaImpressao = new Queue<string>();


            // Adicionar alguns documentos à fila
            filaImpressao.Enqueue("Documento1.pdf");
            filaImpressao.Enqueue("Relatorio.xlsx");
            filaImpressao.Enqueue("Apresentacao.pptx");
            filaImpressao.Enqueue("Contrato.docx");
            filaImpressao.Enqueue("Imagem.png");
            filaImpressao.Enqueue("Planilha.csv");

            // loop que irá executar até que a fila de impressão esteja vazia. 
            while (filaImpressao.Count > 0)
            {
                string documentoAtual = filaImpressao.Dequeue();

                Console.WriteLine($"Imprimindo: {documentoAtual}");

                int tempo = random.Next(1000, 5001);
                Thread.Sleep(tempo);

                Console.WriteLine($"Finalizado: {documentoAtual}\n");
            }

            Console.WriteLine("A fila de impressão está vazia.");
        }
    }
}