using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classetelecomando
{
    internal class telecomando
    {
        //attributi
        private string produttore;
        private string modello;
        private int canale;
        private int volume;
        private bool stato;
        private string modalita;
        //costruttori
        public telecomando(string prod, string mod, string funz)
        {
            produttore = prod;
            modello = mod;
            modalita = funz;
        }

        //metodi
        public void accendi()
        {
            stato = true;
        }
        public void spegni()
        {
            stato = false;
        }
        public void aumentaVolume()
        {
            volume += 1;
        }
        public void diminuisciVolume()
        {
            volume -= 1;
        }
        public void aumentacanale()
        {
            canale += 1;
        }
        public void diminuiscicanale()
        {
            canale -= 1;
        }
        public bool getStato()
        {
            return stato;
        }
        public int getVolume()
        {
            return volume;
        }
        public int getCanale()
        {
            return canale;
        }

    }
}
