using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    internal class Pound : Koupon, Iconvertable
    {
        public string Series { get; set; } 
        public string Country { get; set; }  
        public double Course { get; set; }    

        public Pound(int[] denominations, int nominal, DateTime issueDate,
                     string series, string country, double course)
            : base(denominations, nominal, issueDate)
        {
            Series = series;
            Country = country;
            Course = course;
        }

        public void ConvertToUSD()
        {
            double usd = Nominal / Course;
            Console.WriteLine($"{Nominal} GBP = {usd:F2} USD");
        }

        public override string ToString()
        {
            return $"Pound: {Nominal} GBP, Серия: {Series}, Страна: {Country}, " +
                   $"Дата: {IssueDate.ToShortDateString()}, Курс: {Course}";
        }
    }
}
