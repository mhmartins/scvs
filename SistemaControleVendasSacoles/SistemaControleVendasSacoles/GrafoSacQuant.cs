using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaControleVendasSacoles
{
    class GrafoSacQuant
    {
        private int nCodigo;
        private String nSabor;
        private int nTipo;
        private int nData;
        private int nQuant;

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
        public int Data
        {
            get { return nData; }
            set { nData = value; }
        }
        public int Quant
        {
            get { return nQuant; }
            set { nQuant = value; }
        }
    }
}
