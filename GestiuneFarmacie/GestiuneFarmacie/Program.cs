using System;
using System.Collections.Generic;
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

            string nume, forma, categorie,eliberare;
            int raft, rand, pret, nr_medicamente=0;
            Medicament[] medicamente = new Medicament[10];
            string temp;


            string optiune;
            do
            {
                Console.WriteLine("A. Adaugare medicament.");
                Console.WriteLine("B. Editare medicament.");
                Console.WriteLine("C. Stergere medicament.");
                Console.WriteLine("D. Afisare lista medicamente.");
                Console.WriteLine("E. Cautare medicament");
                Console.WriteLine("X. Iesire program");
                Console.WriteLine("Alegeti o optiune: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        //adaugare medicament
                        Console.WriteLine("\nNumele medicamentului: ");
                        nume = Console.ReadLine();
                        Console.WriteLine("\nForma medicamentului: ");
                        forma = Console.ReadLine();
                        Console.WriteLine("\nCategoria medicamentului: ");
                        categorie = Console.ReadLine();
                        Console.WriteLine("\nEliberare: ");
                        eliberare = Console.ReadLine();
                        Console.WriteLine("\nRaftul: ");
                        raft = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nRandul: ");
                        rand = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nPretul medicamentului: ");
                        pret = Int32.Parse(Console.ReadLine());
                        int index3 = 0;
                        foreach(string limbaje in Enum.GetNames(typeof(NumeMedicamente)))
                        {
                            
                                Console.WriteLine(index3 + "." + limbaje);
                            index3++;
                        }
                        Console.WriteLine("Ce medicament doriti? ");
                        int count = Int32.Parse(Console.ReadLine());
                        medicamente[nr_medicamente] = new Medicament(nume, raft, rand, forma, categorie, eliberare, pret, (NumeMedicamente)count);
                        nr_medicamente++;
                        break;
                    case "B":
                        // editare medicament
                        string cautare_medicament;
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
                                medicamente[index].forma = Console.ReadLine();
                                break;
                            case "3":
                                medicamente[index].categorie = Console.ReadLine();
                                break;
                            case "4":
                                medicamente[index].eliberare = Console.ReadLine();
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
                        // i=id;i<nr_medicamente-1;i++   medicamente de i = medicamente de i+1
                        string cautare_medicament3;
                        string optiune3;
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
                        Console.WriteLine("\n\n");
                        for (int i=0;i<nr_medicamente;i++)
                        {
                            Console.WriteLine(medicamente[i].ConversieLaSir());
                            Console.WriteLine("\n\n");
                        }
                       
                        break;
                    case "E":
                        //cautare medicament
                        string cautare_medicament2;
                        cautare_medicament2 = Console.ReadLine();
                        for(int i=0;i<nr_medicamente;i++)
                        {
                            if(cautare_medicament2==medicamente[i].nume)
                            {
                                Console.WriteLine("\n\n");
                                Console.WriteLine("Medicament gasit !\n");
                                Console.WriteLine(medicamente[i].ConversieLaSir());
                                Console.WriteLine("\n\n");
                            }
                        }
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
