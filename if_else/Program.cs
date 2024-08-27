namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            sayi=true ? 123 : 456;
            Console.WriteLine("Sayı degeri : {0} oldu.",sayi);

            sayi=false ? 123 : 456;
            Console.WriteLine("\nSayı degeri : {0} oldu.", sayi);

            int sayi1 = 7;

            for (int i = 0; i < sayi1; i++)
            {

                if (i%2 == 1)
                {
                    continue;

                    Console.WriteLine("{0} Sayısı 2 ye bölündü ve kalan 1 oldu", i);
                }
                else
                {
                    Console.WriteLine("{0} Sayısı 2 ye bölündü ve kalan 0 oldu", i);
                }
            }
        }
    }
}
