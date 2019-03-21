using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    class Celula
    {
        double valor;
        int linha, coluna;
        Celula direita, abaixo;

        public Celula(double v, int l, int c, Celula d, Celula a)
        {
            Valor = v;
            linha = l;
            coluna = c;
            Direita = d;
            Abaixo = a;
        }

        public double Valor
        {
            get => valor;
            set => valor = value;       
        }

        public int Linha { get => linha; }

        public int Coluna { get => coluna; }

        public Celula Direita
        {
            get => direita;
            set => direita = value;
        }

        public Celula Abaixo
        {
            get => abaixo;
            set => abaixo = value;
        }

        public int CompareTo(Celula cel)
        {
            if (linha != cel.linha)
                return linha - cel.linha;
            return coluna - cel.coluna;
        }
    }
}