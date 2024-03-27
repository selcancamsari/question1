using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //karakter seti
    static string charSet = "ACDEFGHKLMNPRTXYZ234579";

    //rastgele 12 seçtim
    static int keyIndex = 12;

    static void Main(string[] args)
    {
        //kodların oluşturulması ve console yazdırma işlemi
        for (int i = 1000; i < 2000; i++)
        {
            Console.WriteLine(CreateCode(i));
        }

        Console.WriteLine("Kampanya Dahilindeki Kodu Giriniz");
        string code = Console.ReadLine();
        //oluşturulan kodlardan 1 tanesini kontrol etme amaçlı
        // CheckCode("PKCFHN4R");
        if (CheckCode(code))
            Console.WriteLine("Kod Geçerli");
        else
            Console.WriteLine("Kod Geçersiz");

    }

    static string CreateCode(int input)
    {
        //kendime göre algoritma bağlantıları oluşturdum
        //ilişkiler
        //0-1
        int rel1 = 2;
        //1-2
        int rel2 = 3;
        //2-3
        int rel3 = 5;
        //3-4
        int rel4 = 7;
        //4-5
        int rel5 = 11;
        //5-6
        int rel6 = 13;
        //6-7
        int rel7 = 17;

        //üretilen kodların uniq olması için kendime göre bir algoritma oluşturdum.
        string code =
            charSet[(keyIndex + input) % 101 % 23].ToString() +
            charSet[(keyIndex + input * rel1) % 103 % 23].ToString() +
            charSet[(keyIndex + input * rel1 * rel2) % 105 % 23].ToString() +
            charSet[(keyIndex + input * rel1 * rel2 * rel3) % 107 % 23].ToString() +
            charSet[(keyIndex + input * rel1 * rel2 * rel3 * rel4) % 109 % 23].ToString() +
            charSet[(keyIndex + input * rel1 * rel2 * rel3 * rel4 * rel5) % 111 % 23].ToString() +
            charSet[(keyIndex + input * rel1 * rel2 * rel3 * rel4 * rel5 * rel6) % 113 % 23].ToString() +
            charSet[(keyIndex + input * rel1 * rel2 * rel3 * rel4 * rel5 * rel6 * rel7) % 115 % 23].ToString();

        return code;
    }

    //kod kontrolü
    static bool CheckCode(string code)
    {
        //Console.WriteLine();

        for (int i = 1000; i < 2000; i++)
        {
            if (CreateCode(i) == code)
            {
                return true;
            }
        }

        return false;

    }
}


