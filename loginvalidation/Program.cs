using System;

namespace loginvalidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on admin ja salasõna on admin1234
            //siis konsoolis kuvatakse teretulemast!
            //muul juhul kuvatakse vale kasutajatunnus või salasõna. Proovi uuesti!
            //kasutajal on 3 katset

            
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("sisestage kasutajatunnus");
                string username = Console.ReadLine();
                Console.WriteLine("sisestage salasõna");
                string userpassword = Console.ReadLine();

                if (username != "admin" || userpassword != "admin1234")
                {
                    Console.WriteLine("vale kasutajatunnus või salasõna. Proovi uuesti");
                    i++;
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

            }

            if (i >= 3)
            {
                Console.WriteLine("katsed otsas! ");
            }
            

        }
    }
}
