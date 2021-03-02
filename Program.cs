using System;

guessPrompt();

// function getRandomInt(min, max) {
//     min = Math.ceil(min);
//     max = Math.floor(max);
//     return Math.floor(Math.random() * (max - min + 1)) + min;
// }

void guessPrompt()
 {
     Console.WriteLine("Guess a number");
     string answer = Console.ReadLine();
     
     int num = 42;
     int chance = 1;
     bool run = true;
    
    while (chance < 4){

     if (num == int.Parse(answer)){
         Console.WriteLine("Good guess!");
         chance = 4;
         run = false;
     } else {
         Console.WriteLine("Nope! Too bad...");
         Console.WriteLine("Try Again");
         Console.ReadLine();
         
         ++chance;

         if (chance == 4){
             run = false;
         }
     }}
        if (run == false){
            Console.WriteLine("Game Over Man!");
        }
     
     }
 



     


 