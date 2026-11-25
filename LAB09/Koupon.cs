using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    internal class Koupon
    {
        public int[] Denominations { get; set; }
        public int Nominal { get; set; }
        public DateTime IssueDate { get; set; } 

        public Koupon(int[] denominations, int nominal, DateTime issueDate)
        {
            Denominations = denominations;
            Nominal = nominal;
            IssueDate = issueDate;
        }

        public override string ToString()
        {
            return $"Номинал: {Nominal}, Дата выпуска: {IssueDate.ToShortDateString()}";
        }
    }
}
