namespace DailyRun
{
    static class Helper
    {
        
        public static void start()
        {
            string[] positive = { "Evet", "e", "E", "evet", "tamam", "Tamam", "t", "T", "olur", "Olur" };
            string answ;
            do
            {
                takeInput(out double stepLength, out int stepPerMin, out int Hour, out int Min);
                calculatorRun(stepLength, stepPerMin, Hour, Min);

                Console.Write("Tekrar hesaplama yapmak istiyor musunuz: ");
                answ = Console.ReadLine();
                Console.Clear();
            } while (positive.Contains(answ));
            

        }
        static void takeInput(out double stepLength, out int stepPerMin, out int Hour, out int Min)
        {


            while (true)
            {
                Console.Write("Bir adim uzunlugunuz ortalama kac cm: ");

                var flag1 = double.TryParse(Console.ReadLine(), out stepLength);
                if (flag1) { break; }
                Console.WriteLine("Gecersiz karakter girildi, lutfen bir sayi giriniz.\n");
            }

            while (true)
            {
                Console.Write("\nBir dakikada kac adim kosuyorsunuz: ");
                var flag2 = int.TryParse(Console.ReadLine(), out stepPerMin);
                if (flag2) { break; }
                Console.WriteLine("Gecersiz karakter girildi, lutfen bir sayi giriniz.");
            }


            Console.WriteLine("\nKac saat ve dakika kostugunuzu sira ile giriniz ");
            while (true)
            {
                Console.Write("==> ");
                var flag3 = int.TryParse(Console.ReadLine(), out Hour);
                if (flag3) { break; }
                Console.WriteLine("Gecersiz karakter girildi, lutfen bir sayi giriniz.");
            }

            while (true)
            {
                Console.Write("==> ");
                var flag4 = int.TryParse(Console.ReadLine(), out Min);
                if (flag4) { break; }
                Console.WriteLine("\nGecersiz karakter girildi, lutfen bir sayi giriniz.");
            }


        }

        static void calculatorRun(double stepLength, int stepPerMin, int Hour, int Min)
        {
            var length = (stepLength/100) * stepPerMin * ((Hour * 60) + Min);
            Console.WriteLine($"Harikasiniz! Toplam kostugunuz mesafe {length.ToString("F1")} metre!\n");
        }
    }
}