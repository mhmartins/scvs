using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaControleVendasSacoles
{
    class Vendacs
    {
        private int nCodigo;
        private String nSabor;
        private int nTipo;
        private int nQuant;
        private int nQuantMin;
        private String nValor;

        public int Codigo
        {
            get { return nCodigo; }
            set { nCodigo = value; }
        }
        public String Sabor
        {
            get { return nSabor; }
            set { nSabor = value; }
        }
        public int Tipo
        {
            get { return nTipo; }
            set { nTipo = value; }
        }
        public int Quant
        {
            get { return nQuant; }
            set { nQuant = value; }
        }
        public int QuantMin
        {
            get { return nQuantMin; }
            set { nQuantMin = value; }
        }
        public String Valor
        {
            get { return nValor; }
            set { nValor = value; }
        }
    }
}
