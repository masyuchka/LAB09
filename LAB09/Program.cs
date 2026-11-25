using LAB09;

static void Main(string[] args)
{
    int[] poundDenoms = { 5, 10, 20, 50 };
    int[] rubleDenoms = { 100, 500, 1000, 5000 };
    int[] tugrikDenoms = { 100, 500, 1000, 5000, 10000 };

    Wallet wallet1 = new Wallet();
    Wallet wallet2 = new Wallet();


    wallet1.AddToWallet(new Pound(poundDenoms, 20, new DateTime(2020, 5, 1), "Series A", "UK", 0.79));
    wallet1.AddToWallet(new Pound(poundDenoms, 50, new DateTime(2021, 3, 15), "Series B", "UK", 0.79));
    wallet1.AddToWallet(new Ruble(rubleDenoms, 5000, new DateTime(2022, 1, 10), "ЦБ РФ", "2022", 92.5));
    wallet1.AddToWallet(new Ruble(rubleDenoms, 1000, new DateTime(2023, 6, 1), "ЦБ РФ", "2023", 92.5));
    wallet1.AddToWallet(new Tugrik(tugrikDenoms, 10000, new DateTime(2024, 2, 20), "Bank of Mongolia", true));


    wallet2.AddToWallet(new Pound(poundDenoms, 10, new DateTime(2019, 8, 1), "Series A", "UK", 0.79));
    wallet2.AddToWallet(new Ruble(rubleDenoms, 500, new DateTime(2023, 11, 5), "ЦБ РФ", "2023", 92.5));
    wallet2.AddToWallet(new Ruble(rubleDenoms, 5000, new DateTime(2024, 4, 1), "ЦБ РФ", "2024", 92.5));
    wallet2.AddToWallet(new Tugrik(tugrikDenoms, 5000, new DateTime(2025, 1, 15), "Bank of Mongolia", false));
    wallet2.AddToWallet(new Pound(poundDenoms, 20, new DateTime(2022, 7, 20), "Series C", "UK", 0.79));


    Console.WriteLine(wallet1);
    Console.WriteLine(wallet2);

    Console.WriteLine("Конвертация :");
    ((Iconvertable)wallet1.Koupons[0]).ConvertToUSD(); 
    ((Iconvertable)wallet1.Koupons[2]).ConvertToUSD(); 
    ((Iconvertable)wallet1.Koupons[4]).ConvertToUSD();

    Console.WriteLine("Удаляем");
    wallet1.RemoveFromWallet(wallet1.Koupons[0]);
    Console.WriteLine("  После удаления:");
    Console.WriteLine(wallet1);

    Console.WriteLine("Сравнение кошельков");
    Console.WriteLine($"wallet1 == wallet2: {wallet1 == wallet2}");
    Console.WriteLine($"wallet1 != wallet2: {wallet1 != wallet2}");

    wallet1.AddToWallet(new Pound(poundDenoms, 100, new DateTime(2010, 1, 1),"Old", "UK", 0.79));
}