using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaControleVendasSacoles
{
    class Usuario
    {
        private int nCodigo;
        private String nNome;
        private String nSenha;

        public int Codigo
        {
            get { return nCodigo; }
            set { nCodigo = value; }
        }
        public string Nome
        {
            get { return nNome; }
            set { nNome = value; }
        }
        public string Senha
        {
            get { return nSenha; }
            set { nSenha = value; }
        }
    }
}