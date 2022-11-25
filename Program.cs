using System;

namespace Uppgift1 {
    class program {
        public static void Main(string[] args) {
            int morötterStart = 40;

            int morötterÄtnaFörTor = 0;
            int morötterÄtnaFörMor = 0;
            int timmer = 0;

            Console.Write(value: "Hur lång tid tar Tor på sig att äta en morot: ");
            int tidEtt = Convert.ToInt32(value: Console.ReadLine());

            Console.Write(value: "Hur lång tid tar Mor på sig att äta en morot: ");
            int tidTvå = Convert.ToInt32(value: Console.ReadLine());

            while (morötterStart != 0) {
                for (int i = 0; i < tidEtt + 1; i++) {
                    if (i == tidEtt && morötterStart != 0) {
                        Console.WriteLine("CALUCLATING");
                        morötterÄtnaFörTor++;
                        i =- tidEtt + 1;
                        morötterStart--;
                    }
                }
                morötterStart--;
            }

            Console.WriteLine(value: "Tor åt: " + morötterÄtnaFörTor + " morötter");
            Console.WriteLine(value: "Mor åt: " + morötterÄtnaFörMor + " morötter");        
        }   
    }
}