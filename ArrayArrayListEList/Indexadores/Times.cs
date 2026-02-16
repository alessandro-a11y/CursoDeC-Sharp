namespace Indexadores
{
    public class Times
    {
        string[] valor = new string[10];

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < valor.Length)
                {
                    return valor[i];
                }
                return "error";
            }
            set
            {
                if (i >= 0 && i < valor.Length)
                {
                    valor[i] = value;
                }
               
            }
        }
    }
}
