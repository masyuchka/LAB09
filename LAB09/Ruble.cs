using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    internal class Ruble : Koupon, Iconvertable
    {
        public string BankName { get; set; } 
        public string Series { get; set; } 
        public double Course { get; set; }     

        public Ruble(int[] denominations, int nominal, DateTime issueDate,
                     string bankName, string series, double course)
            : base(denominations, nominal, issueDate)
        {
            BankName = bankName;
            Series = series;
            Course = course;
        }

        public void ConvertToUSD()
        {
            double usd = Nominal / Course;
            Console.WriteLine($"{Nominal} RUB = {usd:F2} USD");
        }

        public override string ToString()
        {
            return $"Ruble: {Nominal} RUB, Банк: {BankName}, Серия: {Series}, " +
                   $"Дата: {IssueDate.ToShortDateString()}, Курс: {Course}";
        }
    }
}
