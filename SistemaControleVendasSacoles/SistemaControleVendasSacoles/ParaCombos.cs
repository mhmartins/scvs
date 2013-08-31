using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaControleVendasSacoles
{
    class ParaCombos
    {
        public ParaCombos(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        string _nome;
        string _valor;

        public String Codigo
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
