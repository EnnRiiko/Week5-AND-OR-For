using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisetada kasutajatunnus ja salasõna
            //kui isestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!".
            //muul juhul kuvatakse konsooli "Vale kasutajatunnus või salasõna. Proovige uuesti."

            //OR (või) || (pipes)

            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("vale kasutajatunnus või parool. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //"admin1" != "admin" || "admin1234" != "admin1234" --> true || false --> true
            //"admin" != "admin" || "admin123" != "admin1234" --> false || true --> true
            //"admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
            //"admin" != "admin" || "admin1234" != "admin1234" --> false || false --> false


        }
    }
}
