using System;

namespace Uppgift1 {
    class program {
        public static void Main(string[] args) {
            int morötterStart = 40;
            
            int tidEtt;
            int tidTvå;

            int morötterÄtna = 0;
            int timmer = 0;

            Console.Write(value: "Hur lång tid tar Tor på sig att äta en morot: ");
            tidEtt = Convert.ToInt32(value: Console.ReadLine());

            Console.Write(value: "Hur lång tid tar Mor på sig att äta en morot: ");
            tidTvå = Convert.ToInt32(value: Console.ReadLine());

            while (morötterStart > 0) {
                morötterStart--;
                for (int i = 0; i < tidEtt; i++) {
                    timmer++;
                    morötterÄtna++;
                    morötterStart =- tidEtt;
                }
            }

            Console.WriteLine(value: "Tor åt: " + morötterÄtna + " morötter");        
        }   
    }
}