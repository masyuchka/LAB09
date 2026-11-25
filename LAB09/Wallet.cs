using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    internal class Wallet
    {
        public List<Koupon> Koupons { get; set; } = new List<Koupon>();

        public void AddToWallet(Koupon k)
        {
            int ageYears = DateTime.Now.Year - k.IssueDate.Year;
            if (ageYears > 10)
            {
                Console.WriteLine($"Купюра номиналом {k.Nominal} слишком старая " +
                                  $"({ageYears} лет). Добавление отменено.");
                return;
            }
            Koupons.Add(k);
            Console.WriteLine($"Добавлена купюра: {k}");
        }
        public void RemoveFromWallet(Koupon k)
        {
            if (Koupons.Contains(k))
            {
                Koupons.Remove(k);
                Console.WriteLine($"Удалена купюра: {k}");
            }
            else
            {
                Console.WriteLine("Такой купюры в кошельке нет.");
            }
        }

        public double SumInUSD()
        {
            double total = 0;
            foreach (var k in Koupons)
            {
                if (k is Iconvertable convertible && convertible.Course != 0)
                {
                    total += k.Nominal / convertible.Course;
                }
            }
            return total;
        }

        public override string ToString()
        {
            string result = "Кошелёк  \n";
            foreach (var k in Koupons)
            {
                result += k.ToString() + "\n";
            }
            result += $"Всего в долларах: {SumInUSD():F2} USD\n";
            return result;
        }

        public static bool operator ==(Wallet w1, Wallet w2)
        {
            if (w1 is null && w2 is null) return true;
            if (w1 is null || w2 is null) return false;
            return Math.Abs(w1.SumInUSD() - w2.SumInUSD()) < 0.01;
        }

        public static bool operator !=(Wallet w1, Wallet w2)
        {
            return !(w1 == w2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Wallet other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return SumInUSD().GetHashCode();
        }
    }
}
