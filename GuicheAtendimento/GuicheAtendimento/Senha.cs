using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuicheAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dataEntra, horaEntra, dataAtend, horaAtend;

        public Senha (int id)
        {
            this.id = id;
            this.dataEntra = DateTime.Now.Date;
            this.horaEntra = DateTime.Now;

        }

        public string dadosParciais()
        {
            return (id + " - " + dataEntra.ToShortDateString() + " - " + horaEntra.ToLongTimeString());
        }

        public string dadosCompletos()
        {
            this.dataAtend = DateTime.Now.Date;
            this.dataAtend.ToShortDateString();
            this.horaAtend = DateTime.Now;
            this.horaAtend.ToShortTimeString();
            return (id + " - " + dataEntra.ToShortDateString() + " - " + horaEntra.ToLongTimeString() + " - " + dataAtend.ToShortDateString() + " - " + horaAtend.ToLongTimeString());
        }
    }
}
