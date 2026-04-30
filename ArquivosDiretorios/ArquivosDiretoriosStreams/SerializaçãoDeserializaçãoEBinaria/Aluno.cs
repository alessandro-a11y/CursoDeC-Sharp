namespace SerializacaoBinaria
{
    [Serializable]
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        [NonSerialized]
        public int Idade;


        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}