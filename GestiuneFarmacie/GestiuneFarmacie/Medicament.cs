using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneFarmacie
{
    class Medicament
    {
        public string nume { get; set; }
        public int raft { get; set; }
        public int rand { get; set; }
        public string forma { get; set; }
        public string categorie { get; set; }
        public string eliberare { get; set; }
        public int pret { get; set; }
        public NumeForma Numef { get; set; }
        public TipEliberare Eliberare { get; set; }

        public Medicament()
        {
            nume = "inexistent";
            raft = 0;
            rand = 0;
            Numef = NumeForma.None;
            categorie = "inexistent";
           Eliberare= TipEliberare.None;
            pret = 0;

        }
        public Medicament(string _nume, int _raft, int _rand, NumeForma numef, string _categorie, TipEliberare eliberare, int _pret)
        {
            nume = _nume;
            raft = _raft;
            rand = _rand;
            Numef = numef;
            categorie = _categorie;
            Eliberare = eliberare;
            pret = _pret;
            
        }


        public string ConversieLaSir()
        {
            string s = string.Format("Nume medicament: {0}\nForma: {1}\nCategorie: {2}\nEliberare: {3}\nRaft: {4}\nRand: {5}\nPret: {6}\n", nume, Numef, categorie, Eliberare, raft, rand, pret);
            return s;
        }
        public bool cautare(string search)
        {
            return nume == search;
        }
        
    }

}
