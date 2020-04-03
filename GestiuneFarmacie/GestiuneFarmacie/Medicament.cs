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
        public NumeMedicamente Numem { get; set; }

        public Medicament()
        {
            nume = "inexistent";
            raft = 0;
            rand = 0;
            forma = "inexistent";
            categorie = "inexistent";
            eliberare = "inexistent";
            pret = 0;

        }
        public Medicament(string _nume, int _raft, int _rand, string _forma, string _categorie, string _eliberare, int _pret,NumeMedicamente numem)
        {
            nume = _nume;
            raft = _raft;
            rand = _rand;
            forma = _forma;
            categorie = _categorie;
            eliberare = _eliberare;
            pret = _pret;
            Numem = numem;
        }


        public string ConversieLaSir()
        {
            string s = string.Format("Nume medicament: {0}\nNumar raft: {1}\nNumar rand: {2}\nForma medicament: {3}\nCategoria medicamentului: {4}\nEliberare: {5}\nPret: {6}\n {7}",nume ,raft ,rand ,forma ,categorie ,eliberare ,pret,Numem);
            return s;
        }
        
    }

}
