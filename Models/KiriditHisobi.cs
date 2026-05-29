using System;

namespace BankTizimi.Models
{
    public class KreditHisobi : BankHisobi
    {
        public KreditHisobi(string egasiningIsmi, decimal boshlangichBalans) 
            : base(egasiningIsmi, boshlangichBalans)
        {
        }

        public override void PulYechish(decimal summa)
        {
            if (Balans - summa < -5000)
            {
                Console.WriteLine("Credit limit exceeded");
            }
            else
            {
                Balans -= summa;
                Console.WriteLine($"Withdraw: {summa}");
            }
        }
    }
}