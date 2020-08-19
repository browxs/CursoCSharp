namespace AtributosMetodosConstrutores
{
    public class CampoPropriedade
    {
        private string _encapsulamento;

        public string Campo;
        public string Propriedade { get; set; }

        public string Encapsulamento
        {
            get
            {
                return _encapsulamento;
            }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _encapsulamento = value;
                }
            }

        }
    }
}
