using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnime
            //programm palub kasutajal sisestada numbri 1-3
            //kui kasutaja sisestab 1 kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2 kuvatakse kasutaja eesnime esimene täht
            //kui kasutaja valib 3 kuvatakse kasutaja eesnime pikkus.

            Console.WriteLine("Sisesta oma eesnimi.");
            string UserName = Console.ReadLine();
            GetUsernameData(UserName);


            Console.WriteLine("Sisesta number ühest kolmeni.");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            switch (UserNumber)
            {
                case '1':
                    Reverse(UserName);
                    break;
                case '2':
                    FirstL(UserName);
                    break;
                case '3':
                    Lenght(UserName);
                    break;


                default:
                    Console.WriteLine("Head päeva!");
                    break;
            }

        }

        

        public static void Reverse(string UserName)
        {



            for (int i = UserName.Length - 1; i >= 0; i--)
            {
                Console.Write(UserName[i]);
            }
        }
        public static void FirstL(string UserName)
        {

            Console.WriteLine($"Sinu eesnimi algab {UserName[0]}");
        }

        public static void Lenght(string UserName)
        {

            Console.WriteLine($"Sinu nimi on {UserName.Length} tähte pikk.");
        }

    }
}
