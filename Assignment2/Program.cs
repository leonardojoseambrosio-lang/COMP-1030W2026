using System;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program {
    static void Main() {
        /*
        The program generates a random target temperature, and the user tries to match it.
        All user guesses must be stored in an array or list and displayed at the end.You are using
        VSCode for this.
        Requirements
       */
      
        //- Generate a random temperature between 10 and 40.
        Random randomNum = new Random();
        int rnd = randomNum.Next(10, 41);//creates a random number between 10 and 40.
        
        Console.WriteLine(rnd);

        //- Ask the user to guess the temperature.
        Console.WriteLine("### Welcome to the Temperature History Game ###");
        

        int[] guess = new int[10];
        int index = 0;
        while (index < 10)
        {
            string typeYourAnsewer = Console.ReadLine();

            if (Int32.TryParse(typeYourAnsewer, out guess[0]))
            {

                guess[index] = Int32.Parse(typeYourAnsewer);

                if (guess[index] == rnd) {
                    Console.WriteLine("Perfect!");
                    break;
                }
                else if (guess[index] >= rnd - 3 || guess[index] <= rnd + 3){
                    Console.WriteLine("Too warm!");
                    Console.WriteLine("Try again:");
                    
                }

            }
            else
            {
                Console.WriteLine("Your lose a chance.\nType a number:");
            }
            
            //Console.WriteLine(guess[index]);
            //index increment
            index++;
        }
  
        

//- Provide feedback:
//- Too warm
//- Too cold
//- Perfect
//- Store every guess in an array or list.
//- After the game ends, display all guesses.








    }
}