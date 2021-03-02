using System;

guessPrompt();



void guessPrompt()
 {
     Console.WriteLine("Guess a number");
     string answer = Console.ReadLine();
     
     int num = new Random().Next(1, 100);
     Console.WriteLine(num);
     int chance = 1;
     bool run = true;
    
    while (chance < 5){

     if (num == int.Parse(answer)){
         Console.WriteLine("Good guess! You nailed it! " + answer + " is the secret number!");
         chance = 5;
         run = false;
     } else {
         Console.WriteLine("You guessed " + answer + ", Nope! Too bad...");
        //  Console.WriteLine("Try Again");
         answer = Console.ReadLine();
         
         ++chance;

         if (chance == 5){
             run = false;
         }
     }}
        if (run == false){
            Console.WriteLine("Game Over Man!");
        }
     
     }
 



     


 