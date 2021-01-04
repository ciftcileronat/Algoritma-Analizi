using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmaAnalizi_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "ak", "al", "alı", "alıs", "alısma", "alısmak", "alısmakta", "alısmaktan",
            "alma", "almaz", "almazlar", "an", "anla", "anlar", "ayan", "az", "azla", "azlar", "bir","cal",
            "calı", "calıs", "calısma", "calısmak","calısmakta", "calısmaktan", "de", "def", "dik", "dikler",
            "dikleri", "ede", "ek", "eki", "er", "eri", "eris", "erisme", "erismek", "ev", "fi", "hedef",
            "hedefi", "is", "iste", "istedi", "istedik", "istedikleri", "is", "kal", "kalma", "kalmaz", "kalmazlar",
            "kist", "kiste", "maya", "ol", "olma", "olmaya", "olmayan", "olmayanla", "olmayanlar", "ta", "tan",
            "ya", "yan", "zevk"};

            string input = "erismekistedikleribirhedefiolmayanlarcalısmaktanzevkalmazlar";

            Console.WriteLine("**********201613171909****Uğur Onat ÇİFTÇİLER**********\n");
            Console.WriteLine("**********201613171906**********Mert ÇIRPANLI**********\n");

            Console.WriteLine("Örnek Birleşik Cümle : " + input + "\n");
            Console.WriteLine("Output : \n");
            KelimeSec(kelimeler, input, "");
            Console.WriteLine("");
            Console.WriteLine("********************************************************************************\n");


            Random rnd = new Random();
            string randomInput = "";

            for (int i = 0; i < 8; i++)
            {
                int rndsec = rnd.Next(0, 67);
                randomInput += kelimeler[rndsec];
            }

            Console.WriteLine("Random Input : " + randomInput);
            Console.WriteLine("Output : \n");
            KelimeSec(kelimeler, randomInput, "");

            Console.ReadLine();
        }

         static void KelimeSec(string[] dizi, string input, string output)
         {
            if(input.Length == 0)
            {
                Console.WriteLine(output);
                return;
            }
            for (int i = 1; i <= input.Length; i++)
            {
                String bolara = input.Substring(0, i);
                if(dizi.Contains(bolara))
                {
                    KelimeSec(dizi, input.Substring(i), output + " " + bolara);
                }
            }    

         }
    }
}
