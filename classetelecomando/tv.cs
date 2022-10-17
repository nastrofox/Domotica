using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classetelecomando
{
    internal class tv
    {
        public class TV
        {
            private string produttore;
            private string modello;
            private string[] connettori;
            private bool stato;
            private int canale;

            //costruttore

            public TV()
            {
                produttore = "";
                modello = "";
            }

            public TV(int ilcanale)
            {
                canale = ilcanale;
            }

            public TV(string ilmodello)
            {
                modello = ilmodello;
            }

            public TV(string ilproduttore, string ilmodello)
            {
                produttore = ilproduttore;
                modello = ilmodello;
            }

            public bool getStato()
            {
                return stato;
            }
            public string[] getConnettori()
            {
                return connettori;
            }

            public void setCanale(int nuovoCanale)
            {
                canale = nuovoCanale;
            }
            public void accendi()
            {
                setStato(true);
            }
            public void spegni()
            {
                setStato(false);
            }

            private void setStato(bool nuovoStato)
            {
                stato = nuovoStato;
            }
        }
    }
}

