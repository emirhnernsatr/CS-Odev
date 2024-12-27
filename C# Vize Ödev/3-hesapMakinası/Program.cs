class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan iki sayı al
        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        // Kullanıcıdan işlem türünü al
        Console.Write("İşlem türünü seçiniz (+, -, *, /): ");
        char islem = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // İşlemi gerçekleştir
        if (islem == '+')
            Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
        else if (islem == '-')
            Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
        else if (islem == '*')
            Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
        else if (islem == '/')
            if (sayi2 == 0)
                Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
            else
                Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
        else
            Console.WriteLine("Geçersiz işlem türü!");
    }
}
