namespace TDD
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome{ get; private set; }

        public Usuario(string nome) : this(0, nome)
        {
        }
        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;

            var outro = (Usuario)obj;
            return Nome == outro.Nome && Id == outro.Id;
        }
    }
}