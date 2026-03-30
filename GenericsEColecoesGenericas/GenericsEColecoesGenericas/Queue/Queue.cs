namespace Queue
{
    public class Queue<T>
    {
        private LinkedList<T> elementos = new LinkedList<T>();
        public void Enfileirar(T item)
        {
            elementos.AddLast(item);
        }
        public T Desenfileirar()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("A fila está vazia.");
            T primeiroItem = elementos.First.Value;
            elementos.RemoveFirst();
            return primeiroItem;
        }
        public T Primeiro()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("A fila está vazia.");
            return elementos.First.Value;
        }
        public int Tamanho()
        {
            return elementos.Count;
        }
    }
}