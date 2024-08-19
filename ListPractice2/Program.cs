using System;
namespace ListPractice2
{
    class Program
    {
        static void Main(string[] args) 
        {
            List <string> coffee = new List <string> (); // Listenin içerisinde string değişkenlerin olduğu boş liste oluşturuyoruz.

            Console.WriteLine("Sevdiğiniz Kahveleri Giriniz.");

            for (int i = 0; i < 5; i++) // 5 kez dönen for döngüsü 
            {
                Console.Write($"Kahve {i+1}: "); 
                string cof = Console.ReadLine() ?? ""; // Kullanıcıdan kahve için string değer alıyoruz
                coffee.Add(cof); // Aldığımız değerleri listeye ekliyoruz.
            }

            Console.WriteLine("\nGirilen Kahve İsimleri:");

            foreach (string item  in coffee) // Listedeki elemanları foreach ile ekrana yazdırıyoruz.
            {
                Console.WriteLine(item);
            }
        }
    }
}