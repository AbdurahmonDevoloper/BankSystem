using System;
using BankTizimi.Models;

namespace BankTizimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jamg'arma Hisobi Test
            JamgarmaHisobi savings = new JamgarmaHisobi("Sardor", 1000);
            savings.BalansniKorsat(); 

            savings.PulSolish(500);  
            savings.BalansniKorsat(); 

            savings.PulYechish(300); 
            savings.BalansniKorsat(); 

            savings.PulYechish(2000); 
            Console.WriteLine();

            // Kredit Hisobi Test
            KreditHisobi credit = new KreditHisobi("Sardor", 0);
            credit.PulYechish(6000); // Limit -5000 bo'lgani uchun yetmaydi
            
            Console.ReadKey();
        }
    }
}