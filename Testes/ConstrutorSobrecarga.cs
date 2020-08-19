namespace AtributosMetodosConstrutores
{
    public class ConstrutorSobrecarga
    {
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public ConstrutorSobrecarga()
        {
            Quantidade = 0;
        }

        public ConstrutorSobrecarga(string categoria) : this()
        {
            Categoria = categoria;
        }

        public ConstrutorSobrecarga(string categoria, string nome) : this(categoria)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Categoria: {Categoria}, Nome: {Nome}, Quantidade: {Quantidade}";
        }
    }
}
