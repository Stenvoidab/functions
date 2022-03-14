using System;

namespace UsenNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada oma eesnime
            //programm kuvab kasutaja eesnime pikkuse
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime tagurpidi
            //main osas ei tohi olla rohkem kui 3 rida koodi

            Console.WriteLine("Sisesta oma eesnimi.");
            string UserName = Console.ReadLine();
            GetUsernameData(UserName);
        }

        public static void GetUsernameData(string Userimput)
        {
            Console.WriteLine($"Sinu nimi on {Userimput.Length} tähte pikk.");
            Console.WriteLine($"Sinu eesnimi algab {Userimput[0]}");

            for(int i = Userimput.Length - 1; i >= 0; i--) 
            {
                Console.Write(Userimput[i]);
            }
        }
       
    }


}
