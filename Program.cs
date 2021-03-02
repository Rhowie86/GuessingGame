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
         |        /-'-(_(|~T        <       Easy, Medium, or Hard....heh heh
         `\     |      <'~~               
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
         run = false;
     } else {
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
 



     


 