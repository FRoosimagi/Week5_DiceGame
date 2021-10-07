using System;

namespace ORopperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on admin ja salasõna on admin1234
            //siis konsoolis kuvatakse teretulemast!
            //muul juhul kuvatakse vale kasutajatunnus või salasõna. Proovi uuesti!

            Console.WriteLine("sisestage kasutajatunnus");
            string username = Console.ReadLine();
            Console.WriteLine("sisestage salasõna");
            string userpassword = Console.ReadLine();

            if(username != "admin" || userpassword != "admin1234")
            {
                Console.WriteLine("vale kasutajatunnus või salasõna. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
