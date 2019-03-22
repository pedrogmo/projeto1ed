using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizesEsparsas
{
    class ListaCircularCelula
    {
        bool tipo; //0 é linha, 1 é coluna
        Celula cabeca, final;
        int qtasCelulas;

        public ListaCircularCelula(bool t)
        {
            cabeca = final = null;
            qtasCelulas = 0;
            tipo = t;
        }

        public int QtasCelulas { get => qtasCelulas; }
        public Celula Cabeca { get => cabeca; }
        public Celula Final { get => final; }

        public bool EstaVazia { get => cabeca == null; }

        public bool Tipo { get => tipo; }

        public void Inserir(Celula c)
        {
            if (c == null)
                throw new Exception("Célula nula");
            if (tipo)
                InserirDireita(c);
            else
                InserirAbaixo(c);
        }
        private void InserirDireita(Celula c)
        {            
            if (EstaVazia)
                cabeca = c;
            final.Direita = c;
            c.Direita = cabeca;
            final = c;
            qtasCelulas++;
        }

        private void InserirAbaixo(Celula c)
        {
            if (EstaVazia)
                cabeca = c;
            final.Abaixo = c;
            c.Abaixo = cabeca;
            final = c;
            qtasCelulas++;
        }
    }
}
