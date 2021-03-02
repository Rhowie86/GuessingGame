using System;

guessPrompt();

int difficultySetting() {

     Console.WriteLine(@"
     
                   /~~~\
            -/     \--\.
          ./           `.
        .-/             |\
       / /                \
    .-/                    \
    `/                     |
   /                      -)
  .                        '.
 /                          \
 |                          |
 |                          /
 /                        ./
|                     . \ |
|                  ) \ .) )
|                | | ). )/
|               |) )/ ///
 .             .)----~~~.
 \             /~        \
 \            /           \
 \           /            '
 |          |              |
 .          |              |
  .         |              |
  \         |              \
  `          \     \.       |
   .         \      \.      |
   \          .      \     |
    .         \       \    |.
    \          .       ~.  /'
     \         \      .-.  |
     |    -    )      ( \ .-.
      .  . |||        . o\(o)
      \  |('          \  )\_/
      \   \)           ~-~| |
      .  |)               \'
       \  |~            .-. \)
       `..             ./0o  \
        \|             (___-  )
        \|                 \~~'
         \         .--\___  )           Select your difficulty Butthead...
         |        /-'-(_(|~T        <       Easy, Medium, or Hard....heh heh...
         `\     |      <'~~                       Don't be a Cheater...wink, wink.
          \     \ ___   \-__.
          |      \__---~~   )
          |    (           /'
          |     ~-'        |
          |           _____'
          |        _-~
          |       /
                 .'
                 /
     
     ");
    string difficulty = Console.ReadLine().ToLower();

    int guesses = 0;

         if (difficulty == "easy"){
             guesses = 8;
         } else if (difficulty == "medium") {
             guesses = 6;
         } else if (difficulty == "hard") {
             guesses = 4;
         } else if (difficulty == "cheater") {
             guesses = 100; 
         } 
    return guesses;

}

void guessPrompt()
 {
    int guesses = difficultySetting();


     Console.WriteLine(@"
     
     
       .------..                            _------__--___.__.
    /            \_                       /            `  `    \
  /                \                     |.                     \
 /                   \                   \                       |
/    .--._    .---.   |                   \                      |
|  /      -__-     \   |                    ~-/--`-`-`-\         |
| |                |  |                     |          \        |
 ||                  ||                     |            |       |
 ||     ,_   _.      ||                     |            |       |
 ||      e   e      ||  Hey Beavis,         |   _--    |       |
  ||     _  |_      ||  Pick a Number!     _| =-.    |.-.    |
 @|     (o\_/o)     |@                       o|/o/       _.   |
   |     _____     |                        /  ~          \ |
    \ ( /uuuuu\ ) /                        (/___@)  ___~    |
     \  `====='  /                           |_===~~~.`    |
      \  -___-  /                         _______.--~     |
       |       |            //             \________       |
       /-_____-\       .  _//_                      \      |
     /           \     \\/////                    __/-___-- -_
   /               \    \   /                    /            __\
  /__|  AC / DC  |__\   / /                      -| Metallica|| |
  | ||           |\ \  / /                       ||          || |
  | ||           | \ \/ /                        ||          || |


     
     ");
     string answer = Console.ReadLine();
     
     int num = new Random().Next(1, 100);
     int chance = 1;
     bool run = true;
    
    while (chance < 4){

     if (num == int.Parse(answer)){
         Console.WriteLine("Good guess! You nailed it! " + answer + " is the secret number!");
         chance = 4;
         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine(@"


                                                                                                           
 _____      _____        _____     ____   ____         _____            ____  _____   ______   
|\    \    /    /|  ____|\    \   |    | |    |       |\    \   _____  |    ||\    \ |\     \  
| \    \  /    / | /     /\    \  |    | |    |       | |    | /    /| |    | \\    \| \     \ 
|  \____\/    /  //     /  \    \ |    | |    |       \/     / |    || |    |  \|    \  \     |
 \ |    /    /  /|     |    |    ||    | |    |       /     /_  \   \/ |    |   |     \  |    |
  \|___/    /  / |     |    |    ||    | |    |      |     // \  \   \ |    |   |      \ |    |
      /    /  /  |\     \  /    /||    | |    |      |    |/   \ |    ||    |   |    |\ \|    |
     /____/  /   | \_____\/____/ ||\___\_|____|      |\ ___/\   \|   /||____|   |____||\_____/|
    |`    | /     \ |    ||    | /| |    |    |      | |   | \______/ ||    |   |    |/ \|   ||
    |_____|/       \|____||____|/  \|____|____|       \|___|/\ |    | ||____|   |____|   |___|/
       )/             \(    )/        \(   )/            \(   \|____|/   \(       \(       )/  
       '               '    '          '   '              '      )/       '        '       '   
                                                                 '                             


            ");
         
     } else if (guesses == 100) {
         
         Console.WriteLine("You guessed " + answer);
         if (num > int.Parse(answer)){
             Console.WriteLine("Thats too low");
         } else {
             Console.WriteLine("Thats too high");
         }
         Console.WriteLine("Keep on going...cheater...");
         answer = Console.ReadLine();

     } 
     
       else {
         guesses--;
         
         Console.WriteLine("You guessed " + answer);
         if (num > int.Parse(answer)){
             Console.WriteLine("Thats too low");
         } else {
             Console.WriteLine("Thats too high");
         }
         Console.WriteLine("Try Again, " + guesses + " chances left.");
         answer = Console.ReadLine();
         
         ++chance;
         
     

         if (chance == 4){
             run = false;
         }
     }}
        if (run == false){
            Console.WriteLine(@"
            
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀
██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼
██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀
██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼
███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼
██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼
██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼
██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼
███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼

            
            ");
        }

       
            

        
     
     }
 



     


 