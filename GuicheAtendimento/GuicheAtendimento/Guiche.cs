using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuicheAtendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        internal Queue<Senha> ListaAtendimentos
        {
            get{return atendimentos;}
        }

        public Guiche()
        {
            atendimentos = new Queue<Senha>();
            id = 0;
        }

        public Guiche(int id)
        {
            atendimentos = new Queue<Senha>();
            this.id = id;
        }

        public bool chamar (Queue<Senha> filaSenhas)
        {
            try
            {
                atendimentos.Enqueue(filaSenhas.Dequeue());
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
            return true;
        }
    }
}
