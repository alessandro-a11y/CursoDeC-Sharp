using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class MinhaPartialClass
    {
        public TimeSpan CalculaIdade(DateTime dataNascimento)
        {
            return DateTime.Now - dataNascimento;
        }
        public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2)
        {
            var diferenca = data1.Subtract(data2);
            return diferenca;
        }
    }

}
