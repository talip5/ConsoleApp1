namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Text girisi yapınız :");
            string text= Console.ReadLine();
            Console.WriteLine("text : " + text);
            Console.WriteLine("");
            Console.WriteLine("Number entering make :");
           int sayi=int.Parse(Console.ReadLine());

            Console.WriteLine("ondalık sayi giriniz :");
            float ondalik = float.Parse(Console.ReadLine());
            Console.WriteLine(ondalik);

        }
    }
}
