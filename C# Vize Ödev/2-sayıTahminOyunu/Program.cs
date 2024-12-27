class Program
{
    static void Main()
    {
        // Rastgele bir sayı oluştur
        Random random = new Random();
        int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında bir sayı
        int tahmin = 0;
        int denemeSayisi = 0;

        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım bulabilecek misiniz?");

        // Tahmin döngüsü
        while (tahmin != rastgeleSayi)
        {
            Console.Write("Tahmininizi girin: ");
            string? kullanıcıTahmini = Console.ReadLine();

            // Geçerli bir sayı girildi mi kontrol et
            if (int.TryParse(kullanıcıTahmini, out tahmin))
            {
                denemeSayisi++;

                if (tahmin < rastgeleSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin!");
                }
                else if (tahmin > rastgeleSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin!");
                }
                else
                {
                    Console.WriteLine($"Tebrikler! {denemeSayisi} denemede doğru tahmini yaptınız!");
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin!");
            }
        }
    }
}
