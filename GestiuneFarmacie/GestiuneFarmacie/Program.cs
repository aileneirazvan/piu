using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneFarmacie
    /*
      Aplicație de gestiune a unei farmacii. Opțiuni disponibile:
        • adăugare medicament;
        • editare/ștergere medicament;
        • afișare lista medicamente;
        • căutare medicament.
    */
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string nume=string.Empty, categorie;
            string cautare_medicament;
            int raft, rand, pret, nr_medicamente=3;
            Medicament[] medicamente = new Medicament[10];
            string optiune;
            string linie = string.Empty;
            medicamente[0] = new Medicament("Parasinus", 1, 2, NumeForma.Comprimate, "analgezic", TipEliberare.Fara_Prescriptie, 14);
            medicamente[1] = new Medicament("Xanax", 1, 4, NumeForma.Capsula, "calmant", TipEliberare.Prescriptie, 40);
            medicamente[2] = new Medicament("Metoclopramid", 1, 3, NumeForma.Drajeuri, "analgezic", TipEliberare.Fara_Prescriptie, 10);
            do
            {
                
                Console.WriteLine("A. Adaugare medicament.");
                Console.WriteLine("B. Editare medicament.");
                Console.WriteLine("C. Stergere medicament.");
                Console.WriteLine("D. Afisare lista medicamente in fisier.");
                Console.WriteLine("E. Cautare medicament.");
                Console.WriteLine("F. Citire din fisier.");
                Console.WriteLine("X. Iesire program.");
                Console.WriteLine("Alegeti o optiune: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        //adaugare medicament
                        Console.WriteLine("\nNumele medicamentului: ");
                        nume = Console.ReadLine();
                        int index3 = 0;
                        foreach (string forme in Enum.GetNames(typeof(NumeForma)))
                        {

                            Console.WriteLine(index3 + "." + forme);
                            index3++;
                        }
                        Console.WriteLine("Ce forma de medicament doriti? ");
                        int count = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nCategorie: ");
                        categorie = Console.ReadLine();
                        int index4 = 0;
                        foreach (string tipeliberare in Enum.GetNames(typeof(TipEliberare)))
                        {
                            if (tipeliberare != "None")
                                Console.WriteLine(index4 + "." + tipeliberare);
                            index4++;
                        }
                        Console.WriteLine("\nTip eliberare a medicamentului: ");
                        int count1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nRaftul: ");
                        raft = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nRandul: ");
                        rand = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nPretul in RON: ");
                        pret = Int32.Parse(Console.ReadLine());
                        
                        medicamente[nr_medicamente] = new Medicament(nume, raft, rand, (NumeForma)count, categorie,(TipEliberare)count1, pret);
                        nr_medicamente++;
                        break;

                    case "B":
                        // editare medicament
                        string optiune2;
                        int index = -1;
                        Console.WriteLine("\nNume medicament: ");
                        cautare_medicament = Console.ReadLine();
                        for (int i = 0; i < nr_medicamente; i++)
                        {
                            if (cautare_medicament == medicamente[i].nume)
                            {
                                Console.WriteLine("\nMedicament gasit !\n");
                                Console.WriteLine(medicamente[i].ConversieLaSir());
                                index = i;
                                break;
                            }
                        }
                        if(index == -1)
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Medicamentul nu a fost gasit!");
                            Console.WriteLine("\n\n");
                            break;
                        }
                        Console.WriteLine("\nEditare medicament. \n");
                        Console.WriteLine("1 Nume \n");
                        Console.WriteLine("2 Forma \n");
                        Console.WriteLine("3 Categorie \n");
                        Console.WriteLine("4 Eliberare \n");
                        Console.WriteLine("5 Raft \n");
                        Console.WriteLine("6 Rand \n");
                        Console.WriteLine("7 Pret \n");
                        Console.WriteLine("Introduceti o optiune:  \n");
                        optiune2 = Console.ReadLine();
                        switch(optiune2)
                        {
                            case "1":
                                medicamente[index].nume = Console.ReadLine();
                                break;

                            case "2":
                                Console.WriteLine("\n");
                                int index5 = 0;
                                foreach (string forme in Enum.GetNames(typeof(NumeForma)))
                                {

                                    Console.WriteLine(index5 + "." + forme);
                                    index5++;
                                }
                                Console.WriteLine("Ce forma de medicament doriti? ");
                                int ceva = Int32.Parse(Console.ReadLine());
                                medicamente[index].Numef =(NumeForma)ceva;
                                break;

                            case "3":
                                medicamente[index].categorie = Console.ReadLine();
                                break;

                            case "4":
                                int index6 = 0;
                                foreach (string tipeliberare in Enum.GetNames(typeof(TipEliberare)))
                                {
                                    if (tipeliberare != "None")
                                        Console.WriteLine(index6 + "." + tipeliberare);
                                    index6++;
                                }
                                Console.WriteLine("\nTip eliberare a medicamentului: ");
                                int ceva1 =Int32.Parse(Console.ReadLine());
                                medicamente[index].Eliberare =(TipEliberare)ceva1;
                                break;
                            case "5":
                                medicamente[index].raft =Int32.Parse( Console.ReadLine());
                                break;
                            case "6":
                                medicamente[index].rand =Int32.Parse( Console.ReadLine());
                                break;
                            case "7":
                                medicamente[index].pret =Int32.Parse( Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Optiune inexistenta");
                                break;
                        }
                        break;

                    case "C":
                        // stergere medicament
                        int index1 = -1;
                        Console.WriteLine("\nNume medicament: ");
                        cautare_medicament = Console.ReadLine();
                        for (int i = 0; i < nr_medicamente; i++)
                        {
                            if (cautare_medicament == medicamente[i].nume)
                            {
                                Console.WriteLine("\nMedicament gasit !\n");
                                Console.WriteLine(medicamente[i].ConversieLaSir());
                                index1 = i;
                                break;
                            }
                        }
                        if (index1 == -1)
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Medicamentul nu a fost gasit!");
                            Console.WriteLine("\n\n");
                            break;
                        }
                        for (int i = index1; i < nr_medicamente - 1; i++)
                        {
                            medicamente[i] = medicamente[i + 1];
                        }
                        nr_medicamente--;
                        break;

                    case "D":
                        //afisare lista medicamente
                        StreamWriter sw = new StreamWriter("C:/Users/ailen/Desktop/Tema PIU/GestiuneFarmacie/GestiuneFarmacie/TextFile/Test.txt");
                        
                        for (int i=0;i<nr_medicamente;i++)
                        {
                            sw.WriteLine(medicamente[i].ConversieLaSir());
                            
                        }
                       sw.Close();
                        break;

                    case "E":
                        //cautare medicament
                        string cautare_medicament2;
                        cautare_medicament2 = Console.ReadLine();
                        for(int i=0;i<nr_medicamente;i++)
                        {
                            if(medicamente[i].cautare(cautare_medicament2))
                            {
                                Console.WriteLine("\n\n");
                                Console.WriteLine("Medicament gasit !\n");
                                Console.WriteLine(medicamente[i].ConversieLaSir());
                                Console.WriteLine("\n\n");
                            }
                        }
                        break;

                    case "F":
                        // Citire din fisier si afisare in consola
                        StreamReader sr = new StreamReader("C:/Users/ailen/Desktop/Tema PIU/GestiuneFarmacie/GestiuneFarmacie/TextFile/Test.txt");
                        while (linie != null)
                        {
                            nume = string.Empty;
                            for (int i = 0; i < 7; i++)
                            {
                                 linie = sr.ReadLine();
                                string[] elems = linie.Split(' ');

                                if (i == 0)
                                {
                                    foreach (string elem in elems.Skip(2).Take(elems.Length - 1))
                                    {
                                        nume = nume + ' ' + elem;
                                    }
                                }
                                else
                                {
                                    foreach (string elem in elems.Skip(1).Take(1))
                                    {
                                        nume = nume + ' ' + elem;
                                    }
                                }
                                

                            }
                            Console.WriteLine("\n");
                            Console.WriteLine(nume);
                            Console.WriteLine("\n");
                            linie = sr.ReadLine();
                            if (linie == null)
                            {
                                break;
                            }
                            
                        }  
                        
                        sr.Close();
                        break;

                    case "X":
                        // iesire din program
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");
            
            Console.ReadKey();
        }
    }
}
