using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Bir Sayı Giriniz");

        string number = Console.ReadLine();

        int.TryParse(number, out int sayi);


        if (sayi > 10)
        {
            Console.WriteLine("Sayı 10 dan büyüktür");
        }
        else
        {
            if (sayi < 10)
            {
                Console.WriteLine("Sayı 10 dan küçüktür");
            }
            else
            {
                Console.WriteLine(" Sayı 10 a eşittir ");
            }
        }
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Sayı çift sayıdır");
        }
        else
        {
            Console.WriteLine("Sayı tek Sayıdır");
        }
    }

    
}
