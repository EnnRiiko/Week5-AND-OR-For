using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisetada kasutajatunnus ja salasõna
            //kui isestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!".
            //muul juhul kuvatakse konsooli "Vale kasutajatunnus või salasõna. Proovige uuesti."
            //kasutajal on kolm katset.

            

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine($"vale kasutajatunnus või parool. {3 - i} katset on jäänud.");
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
            }



        }
    }
}
