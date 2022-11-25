using System;

namespace Uppgift1 {
    class program {
        public static void Main(string[] args) {
            int morötterStart = 40;
            int time = 1000;

            int timerOne = 0;
            int timerTwo = 0;

            int timerReset = 0;

            int morötterÄtnaFörTor = 0;
            int morötterÄtnaFörMor = 0;

            Console.Write(value: "Hur lång tid tar Tor på sig att äta en morot: ");
            int tidEtt = Convert.ToInt32(value: Console.ReadLine());

            Console.Write(value: "Hur lång tid tar Mor på sig att äta en morot: ");
            int tidTvå = Convert.ToInt32(value: Console.ReadLine());

           
                for (int i = 0; i < time; i++) {
                    if (timerOne == tidEtt && morötterStart != 0) {

                        morötterÄtnaFörTor++;
                        morötterStart--;
                        timerOne = timerReset;

                    } else if (timerTwo == tidTvå  && morötterStart != 0) {

                        morötterÄtnaFörMor++;
                        morötterStart--;
                        timerTwo = timerReset;

                    } else {

                        timerOne++; 
                        timerTwo++; 

                    }
                }
                

            Console.WriteLine(value: "Tor åt: " + morötterÄtnaFörTor + " morötter");
            Console.WriteLine(value: "Mor åt: " + morötterÄtnaFörMor + " morötter");        
        }   
    }
}