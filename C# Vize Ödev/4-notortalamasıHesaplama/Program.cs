class Program
{
    static void Main()
    {
        Console.WriteLine("Vize notunu giriniz (0-100 arası):");
        double vize = double.Parse(Console.ReadLine());

        Console.WriteLine("Final notunu giriniz (0-100 arası):");
        double final = double.Parse(Console.ReadLine());

        double ortalama = (vize * 0.4) + (final * 0.6);
        Console.WriteLine($"Not ortalamanız: {ortalama:F2}");

        string harfNotu = HarfNotuHesapla(ortalama);
        Console.WriteLine($"Harf notunuz: {harfNotu}");

        Console.WriteLine(ortalama >= 60 ? "Dersi geçtiniz." : "Dersten kaldınız.");
    }
    static string HarfNotuHesapla(double puan)
    {
        if (puan >= 90)
        {
            return "AA";
        }
        else if (puan >= 85)
        {
            return "BA";
        }
        else if (puan >= 75)
        {
            return "BB";
        }
        else if (puan >= 70)
        {
            return "CB";
        }
        else if (puan >= 60)
        {
            return "CC";
        }
        else if (puan >= 55)
        {
            return "DC";
        }
        else if (puan >= 45)
        {
            return "DD";
        }
        else if (puan >= 40)
        {
            return "FD";
        }
        else
        {
            return "FF";
        }
    }
}