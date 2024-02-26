namespace ApiCrud.Estudantes
{
    public class Estudante
    {
        public Guid Id { get; init; }
        public String Nome { get; private set; }
        public bool Ativo{ get; private set; }


        public Estudante(String nome)
        {
            Nome = nome;
            Id = Guid.NewGuid();
            Ativo = true;
        }
    }
}
