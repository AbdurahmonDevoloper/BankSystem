using System;

namespace BankTizimi.Models
{
    public abstract class BankHisobi
    {
        public string EgasiningIsmi { get; set; }
        public decimal Balans { get; set; }

        public BankHisobi(string egasiningIsmi, decimal boshlangichBalans)
        {
            EgasiningIsmi = egasiningIsmi;
            Balans = boshlangichBalans;
        }

        public abstract void PulYechish(decimal summa);

        public virtual void BalansniKorsat()
        {
            Console.WriteLine($"Balance: {Balans}");
        }

        public void PulSolish(decimal summa)
        {
            Balans += summa;
            Console.WriteLine($"Deposited: {summa}");
        }
    }
}