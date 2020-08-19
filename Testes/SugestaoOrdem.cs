using System;
using System.Collections.Generic;
using System.Text;

namespace AtributosMetodosConstrutores
{
    public class SugestaoOrdem
    {
        public string _atributosPrivados;

        public int PropriedadesAutoImplementadas { get; set; }

        public SugestaoOrdem()
        {
        }

        public string PropriedadesCustomizadas
        {
            get { return _atributosPrivados; }

            set
            {
                if (value != null)
                {
                    _atributosPrivados = value;
                }
            }
        }

        public void Metodos()
        {

        }
    }
}
