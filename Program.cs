using System.Text;
using System.Collections.Generic;
using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> attemptsCount = new List<string> ();
            string userChosenLevel = "";
            Console.WriteLine("Welcome to the guessing game, choose A level: easy, medium, hard ");
            userChosenLevel = Console.ReadLine();

            if(userChosenLevel == "easy"){
                easy();
            }

            else if(userChosenLevel == "medium"){
                medium();
            }

            else if(userChosenLevel == "hard"){
                hard();
            }

             else{
                 Console.Write("please enter a valid difficulty level, restart the game");
             }
        
        }

        

        // easy][0y] level method
         static void easy(){
             Random rnd = new Random();
            int month  = rnd.Next(1, 10);
            // Console.WriteLine(month);
             int userNumber = 0;
             Console.WriteLine("guess the correct number between 1 and 10. You get 6 guesses");
             Console.WriteLine();
             for(int i = 5; i >= 0; i--){
                  Console.WriteLine("guess the number:");
             userNumber = int.Parse(Console.ReadLine());
             if(month == userNumber){
                 Console.WriteLine("correct you got it, restart the game");
                 return; 
             }
              else if(month != userNumber){
                  Console.WriteLine("wrong you have " + i + " chance(s) left");
              }
                
             }
                Console.WriteLine();
             Console.WriteLine("Game over,You have exhausted your chances, restart the game");  
            
         }


        // medium level method
         static void medium(){
             Random rnd = new Random();
            int month  = rnd.Next(1, 20);
            // Console.WriteLine(month);
             int userNumber = 0;
             Console.WriteLine("guess the correct number between 1 and 20. You get 4 guesses");
             Console.WriteLine();
             for(int i = 3; i >= 0; i--){
                  Console.WriteLine("guess the number:");
             userNumber = int.Parse(Console.ReadLine());
             if(month == userNumber){
                 Console.WriteLine("correct you got it, restart the game");
                 return; 
             }
              else if(month != userNumber){
                  Console.WriteLine("wrong you have " + i + " chance(s) left");
              }
                
             }
                Console.WriteLine();
             Console.WriteLine("Game over, chose a lesser difficulty level, restart the game");  
            
         }


        // hard level method
         static void hard(){
             Random rnd = new Random();
            int month  = rnd.Next(1, 50);
            // Console.WriteLine(month);
             int userNumber = 0;
             Console.WriteLine("guess the correct number between 1 and 50. You get 3 guesses");
             Console.WriteLine();
             for(int i = 2; i >= 0; i--){
                  Console.WriteLine("guess the number:");
             userNumber = int.Parse(Console.ReadLine());
             if(month == userNumber){
                 Console.WriteLine("correct you got it, restart the game");
                 return; 
             }
              else if(month != userNumber){
                  Console.WriteLine("wrong you have " + i + " chance(s) left");
              }
                
             }
                Console.WriteLine();
             Console.WriteLine("Game over, chose a lesser difficulty level, restart the game");  
            
         }
          

    }
}
