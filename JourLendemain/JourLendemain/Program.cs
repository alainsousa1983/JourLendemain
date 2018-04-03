using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourLendemain
{
    class Program
    {
        static void Main(string[] args)
        {
            float jour, mois, annee; 

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("TP1 - (1695882 - Mota de Sousa, Alan Wagner)");
            Console.Write("\t\t\n      (1596129 - Silva, Jose Alexandre)");
            Console.ResetColor();

            Console.Write("\n\nEntrez le jour (1-31)\t: ");
            Console.ForegroundColor = ConsoleColor.Red;
            jour = Convert.ToSingle(Console.ReadLine());
            Console.ResetColor();
            
            Console.Write("Entrez le mois (1-12)\t: ");
            Console.ForegroundColor = ConsoleColor.Red;
            mois = Convert.ToSingle(Console.ReadLine());
            Console.ResetColor();
            
            Console.Write("Entrez l'année\t\t: ");
            Console.ForegroundColor = ConsoleColor.Red;
            annee = Convert.ToSingle(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("La date entrée\t\t: {0,2}/ {1,2}/{2,2}", jour, mois, annee);

            // mois de 30 et 31 jour
            if (jour == 31 && (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10))
            {
                Console.WriteLine("La date du lendemain \t: {0,2}/ {1,2}/{2,2}", 1, mois + 1, annee);
            }
            else if (jour == 30 && (mois == 4 || mois == 6 || mois == 9 || mois == 11))
                Console.WriteLine("La date du lendemain \t: {0,2}/ {1,2}/{2,2}", 1, mois + 1, annee);
            else if (jour == 31 && (mois == 12))
                Console.WriteLine("La date du lendemain \t: {0,2}/ {1,2}/{2,2}", 1, 1, annee + 1);

            // l'année bissextile et le jour 29 de févier
            else if (jour == 29 && (mois == 2))
                Console.WriteLine("La date du lendemain \t: {0,2}/ {1,2}/{2,2}", 1, mois + 1, annee);
            else if (mois == 2 && (jour == 28 && (annee % 400 == 0) || (annee % 4 == 0 && annee % 100 != 0)))
                Console.WriteLine("La date du lendemain \t: {0,2}/ {1,2}/{2,2}", jour + 1, mois, annee);
            else if (mois == 2 && (jour == 28 && (annee % 400 != 0) || (annee % 4 != 0 && annee % 100 != 0)))
                Console.WriteLine("La date du lendemain \t: {0,2}/ {1,2}/{2,2}", 1, mois + 1, annee);
                else
                Console.WriteLine("La date du lendemain \t: {0,2}/ {1,2}/{2,2}", jour + 1, mois, annee);

            Console.ReadKey();
                    
        }
    }
}
