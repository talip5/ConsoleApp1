namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            Ogrenci ogr2 = new Ogrenci();

            Ogrenci2 ogrencix = new Ogrenci2();
            Ogrenci2 ogrenciy = new Ogrenci2();

            ogr1.yas =35;
            ogr1.isim ="Ali";

            ogr2.yas =15;
            ogr2.isim ="Ahmet";

            ogr1.yazdır();
            ogr2.yazdır();

            ogrencix.veriGir(25, 55);
            ogrenciy.veriGir(85, 3);

        }
    }
}
