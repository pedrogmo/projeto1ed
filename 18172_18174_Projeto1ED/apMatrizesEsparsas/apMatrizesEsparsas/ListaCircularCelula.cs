using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizesEsparsas
{
    class ListaCircularCelula
    {
        Celula cabeca, final;
        int qtasCelulas;

        public ListaCircularCelula()
        {
            cabeca = final = null;
            qtasCelulas = 0;
        }

        public int QtasCelulas { get => qtasCelulas; }
        public Celula Cabeca { get => cabeca; }
        public Celula Final { get => final; }

        public bool EstaVazia { get => cabeca == null; }

        public void InserirDireita(Celula c)
        {
            if (c == null)
                throw new Exception("Célula nula");
            if (EstaVazia)
                cabeca = c;
            final.Direita = c;
            c.Direita = cabeca;
            final = c;
            qtasCelulas++;
        }

        public void InserirAbaixo(Celula c)
        {
            if (c == null)
                throw new Exception("Célula nula");
            if (EstaVazia)
                cabeca = c;
            final.Abaixo = c;
            c.Abaixo = cabeca;
            final = c;
            qtasCelulas++;
        }
    }
}
