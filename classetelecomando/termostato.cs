using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classetelecomando
{
    public class Termostato
    {
        //attributi
        private string modello;
        private string produttore;
        private int ndiserie;
        private Caldaia caldaia;

        //costruttori
        public Termostato(string Modello, string Produttore, int NumDiSerie, Caldaia caldaia1)
        {
            modello = Modello;
            produttore = Produttore;
            ndiserie = NumDiSerie;
            caldaia = caldaia1;
        }

        //metodi
        public void accendi()
        {
            caldaia.setStato(true);
        }
        public void spegni()
        {
            caldaia.setStato(false);
        }
        public void setTemperatura()
        {
            //prendere il valore ...
            caldaia.setTemperatura(3);
        }
        public string getModello()
        {
            return modello;
        }
        public string getProduttore()
        {
            return produttore;
        }
        public int getNdiserie()
        {
            return ndiserie;
        }
    }
}
