using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayi Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayiniz :" + sayi);

            }
            catch (Exception ex)
            {

               Console.WriteLine("Hataniz:" + ex.Message.ToString());
            }
            //finally 
            //{ 
            //    Console.WriteLine("islem taalanidi");
            //}
            try
            {
                //int a = int.Parse(null);
                //int a =int.Parse("test");
                int a = int.Parse("-20000000000000000");
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Bos Deger Girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Format Uygun Degil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {

                Console.WriteLine("Cok Kucuk veya Cok Buyuk Bir Deger Girdiniz.");
                Console.WriteLine(ex);
            }




            Console.ReadLine();
        }
    }
}
