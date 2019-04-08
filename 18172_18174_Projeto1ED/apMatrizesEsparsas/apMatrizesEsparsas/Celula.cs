using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizesEsparsas
{
    class Celula
    {
        double valor; //valor real armazenado internamente
        int linha, coluna; //coordenadas de linha e coluna dentro da matriz
        Celula direita, abaixo; //ponteiros de células que estão à direita e abaixo da atual

        public Celula(double v, int l, int c, Celula d, Celula a)
            //construtor chama propriedades setters da classe com os valores passados por parâmetro
        {
            Valor = v;
            linha = l;
            coluna = c;
            Direita = d;
            Abaixo = a;
        }

        public double Valor
            //propriedade de valor
        {
            get => valor;
            set => valor = value;       
        }

        //propriedades de Linha e Coluna, sem setters
        public int Linha { get => linha; }

        public int Coluna { get => coluna; }

        //propriedades Direita e Esquerda com getters e setters
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

        //método ToString() da classe, que retorna atributos no formato '[valor];[linha];[coluna]'
        public override string ToString()
        {
            return $"{valor};{linha};{coluna}";
        }
    }
}