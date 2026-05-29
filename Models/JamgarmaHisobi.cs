using System;

namespace BankTizimi.Models
{
    public class JamgarmaHisobi : BankHisobi
    {
        public JamgarmaHisobi(string egasiningIsmi, decimal boshlangichBalans) 
            : base(egasiningIsmi, boshlangichBalans)
        {
        }

        public override void PulYechish(decimal summa)
        {
            if (summa > Balans)
            {
                Console.WriteLine("Not enough balance");
            }
            else
            {
                Balans -= summa;
                Console.WriteLine($"Withdraw: {summa}");
            }
        }
    }
}