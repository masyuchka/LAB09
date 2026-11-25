using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    internal class Tugrik : Koupon, Iconvertable
    {
        public string Issuer { get; set; }     
        public bool IsNewSeries { get; set; } 
        public double Course { get; set; } 

        public Tugrik(int[] denominations, int nominal, DateTime issueDate,
                      string issuer, bool isNewSeries)
            : base(denominations, nominal, issueDate)
        {
            Issuer = issuer;
            IsNewSeries = isNewSeries;
            Course = 0;
        }

        public void ConvertToUSD()
        {
            Console.WriteLine("Конвертация тугрика в доллары невозможна (Course = 0)");
        }

        public override string ToString()
        {
            return $"Tugrik: {Nominal} MNT, эмитент: {Issuer}, " +
                   $"Новая серия: {IsNewSeries}, дата: {IssueDate.ToShortDateString()}";
        }
    }
}
