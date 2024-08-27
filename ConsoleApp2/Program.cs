namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("İnteger sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("integer sayi :" + sayi);

            Console.WriteLine("Ondalik sayi giriniz :");
            float ondalik = float.Parse(Console.ReadLine());
            Console.WriteLine(ondalik);

            Console.WriteLine();
            sayi = (int)ondalik;
            Console.WriteLine("Ondalık sayının tam sayı gösterimi");
            Console.WriteLine(sayi);
            */

            float tekondalik = 13.25f;
            float tekondalik1 = (float)123.46;

            Console.WriteLine("\nTekondalık degeri {0}yapar \n",tekondalik);
            Console.WriteLine("Tekondalık degeri {0,10}yapar \n", tekondalik);
            Console.WriteLine("Tekondalık degeri {0,-10}yapar \n", tekondalik);


        }

        
    }
}
