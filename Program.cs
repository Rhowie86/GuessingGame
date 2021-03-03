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
    
    while (chance < guesses){

     if (num == int.Parse(answer)){
         Console.WriteLine("Good guess! You nailed it! " + answer + " is the secret number!");
         chance++;
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
         
        //  ++chance;
         
     

         if (guesses == 1){
            //  run = false;
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












qqppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppppppppppppqqpppqqpppqqpppppppppppppppppppppppppppppppppppppppqppppppppppppqqppppppppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppppppppppppppppqqpqppppqpqqppppppppppppppppppppppppppppppppppqqqppppqpppwppppppppppppppppppppppppppppppppppppppppppppppq
qqpppppppppppppppppppppppppppppppppqppqqqpppu-__++++_}LqwqpppppppppppppppppppppppppppqppqqppJ}+__++_-upqpqppqqppppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppppppppqqqppX_+__________-__Oqpqpppppppppppppppppppppppppqqpc__++__________xqppppqpppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppppppppppqc++-___________+____Oqppppppppppppppppppppppppqp/++___________+__++)qppppppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppppqqpqqw~__++__+~_}1-+__++_____ppqqppppppppppppppppqqqwX+_++__++_-_-?++______~Cqqqqppqppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppqqqppqf__++____[pdppqqL++______+zppqppppppppppppppqppq-++___++_-dpppdq/__+_+-__]qppqqqppppppppppppppppppppppppppppppppq
qqpppppppppppppppppppppppppppppppqq?++__+__-Jpwqppqqpq______-__)qppppppppppppppppdd______++_Qdppqqppqq_____+__+dppppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppqppp-_____+__0mqppppqppwq{_+__+__+]wdpqqpppppqqqqppL~+_______mpqqpppppqqp__-____++wpqpppppppppppppppppppppppppppppppppq
qqpppppppppppppppppppppppppppppqp__+______Upqqppppqqpppp]___+__++-qdpqppppppqqdpX-+_____+_Zppqqpppppqqpp_______++wppppppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppppqq---______|pqqpppppppqqqpw_+__++__~?qqqppppppqpqY__-__+__+Jpqpppqpppppqpq0___+__+++wqqqqpqpppppppppppppppppppppppppppq
qqpppppppppppppppppppppppppqppp]________-qpqqqpppppppppppZ_+_____++}pppppppqppO_________}qqpppppppppqqqqq{+++_+__+-dpppqqpppppppppppppppppppppppppppq
qqppppppppppppppppppppppppppqq/_+____++_Opqppqppppppppppqp/______+_+npqppppqpp_+______+_dpqpppppppppqqpppq-~__+__+__wppqppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppqqqL________~[pppppppppppppppqppd_+____+__+0pqqppqq_++_______Jpqppppppppppppppppz+________tpqpqpppppppppppppppppppppppppppq
qqpppppppppppppppppppppppqppq+_____+__+pqppppppppppppppppqpr________+_qppppq1-_+_____+_qpqqpppppppppppppppq_+_+_____+Zppppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppqp]________+]qppppppppppppppppqppp_++___+__+{qdqqC_+__+____+Lpqqqppppppppppppppqpu+_+______?qpqpppppppppppppppppppppppppppq
qqppppppppppppppppppppppppdL_-______+_qqpppppppppppppppppppp|_-++_____+mwpp_++____+++-qpqqpppppppppppppppqpp+-+_____+_rdppppppppppppppppppppppppppppq
qqppppppppppppppppppppppppp_________+-dpppppppppppppppppppppp__________+pp|_________-cqpqpppppppppppppppppqq|++______+_qppppppppppppppppppppppppppppq
qqpppppppppppppppppppppppq/+________+Jppppppppppppppppppppppp__________+vm________+_-pqqppqppppppppppppppqqpm+________+}qpppppppppppppppppppppppppppq
qqpppppppppppppppppppppppp_+________+qqqpppppppppppppppppppppC_________-_[++________)qpppppppppppppppppppqppq_+________-wpppqpppppppppppppppppppppppq
qqppppppppppppppppppppppq(__+______+)qpqpppppppppppppppppppppw-_________+++________-Oppppppppppppppppppppppqqj________+_-qppqqppppppppppppppppppppppq
qqpppppppppppppppppppqqpq__________+Qpppqpppppppppppppppppppqq[+______+_____________pppppppppppppppppppppqqqpp+__________ddppqppppppppppppppppppppppq
qqpppppppppppppppppppqpp/___________pqppqppppppppppppppppppppqU++_______________+_+)qppppppppppppppppppppqppqp___________]ppppppppppppppppppppppppppq
qqpppppppppppppppppppqpp___________{pqppppppppppppppppppppppppq_________________+_+Odqpppppppppppppppppppppqqq)__________~ppqpppppppppppppppppppppppq
qqppppppppppppppppppqqpz+_________+Xqqppppppppppppppppppppppqqd-+_________________+ppqpppppppppppppppppppppppqZ+_+_+_____+fqpqppppppppppppppppppppppq
qqppppppppppppppppppqqp_________+-_qqqqqqppppppppppppppppppppqp/+_______________+_-qqqppppppppppppppppppppppppq-__________-pqpppppppppppppppppppppppq
qqppppppppppppppppppqqw___________-pqqqppppppppppppppppppppppppJ_________________+vpqpppppppppppppppppppppppppq-_________+_0pqppppppppppppppppppppppq
qqpppppppppppppppppppp1___________1pppppppppppppppppppppppppqpqq_________________-qppqppppppppppppppppppppppppp/+_________+)qpppppppppppppppppppppppq
qqppppppppppppppppppqp+___________zpppppppppppppppppppppppppqpqp__________________ppqpppppppppppppppppppppppppqL+_+_________pqppppppppppppppppppppppq
qqpppppppppppppppppppZ+_______+___qpppppppppppppppppppppppppqpqq[+_______________-qqqppppppppppppppppppppppppppq__+________+0pppppppppppppppppppppppq
qqppppppppppppppppppq1+__________+ppppppppppppppppppppppppppqpqpf_______________+/qqqppppppppppppppppppppppppppp+_+________+/pppppppppppppppppppppppq
qqppppppppppppppppppq-~___________ppppppppppppppppppppppppppqpqpJ_______________+Uqpqpppppppppppppppppppppppppqp?_+_________-qppppppppppppppppppppppq
qqppppppppppppppppppq+__________+)ppppppppppppppppppppppppppqqppw________________mwpqqpppppppppppppppppppppppppq/+_________+_qppppppppppppppppppppppq
qqppppppppppppppppppc____________Yqppppppppppppppppppppppppppqpqd_______________+qqpqppppppppppppppppppppppppppqc__________+_Uppppppppppppppppppppppq
qqppppppppppppppppqq[+-+______+__qppppppppppppppppppppppppppqqqqd-++_____________pqpqppppppppppppppppppppppppppq0__+____+_+__1qqppppppppppppppppppppq
qqpppppppppppppqpqpd+____________dqqpppppppppppppppppppppppppqppq?++_______+____[qqqqpppppppppppppppppppppppppppw_+___________qpqqppppppppppppppppppq
qqpppppppppppppppppw_++_______+_+qpqpppppppppppppppppppppppppqpqq}++_______+____|qpqqppppppppppppppppppppppppppqp_____________qppqppppppppppppppppppq
qqppppppppppppppqpqJ_++_______+__wqqppppppppppppppppppppppppppqpp|_+_______+__++upqqqpppppppppppppppppppppppppppp-____________wqpqppppppppppppppppppq
qqpppppppppppppppqpt____________]qqppppppppppppppppppppppppppppppv_+____________Jpppppppppppppppppppppppppppppppp?____________zpqpqpppppppppppppppppq
qqpppppppppppppqpqq}____________tpppppppppppppppppppppppppppppppqJ____________+_0pppppppppppppppppppppppppppppqpp{___________+)pqpqpppppppppppppppppq
qqppppppppppppppppq_____________Uqqppppppppppppppppppppppppppppppm+-____________mppppppppppppppppppppppppppppppqqt+____________qqqppppppppppppppppppq
qqpppppppppppppppqp+__________-+Oqqqpppppppppppppppppppppppppppppp~____________+ppppppppppppppppppppppppppppppqqqu____________+pqqppppppppppppppppppq
qqppppppppppppppqqm_____________wpqqpppppppppppppppppppppppppppppd+__________+_+ppppppppppppppppppppppppppppppqqpX+____________dqqppppppppppppppppppq
qqppppppppppppppqpC_____________dqpppppppppppppppppppppppppppppppd__+________+_+ppppppppppppppppppppppppppppppqqpL_+___________pqpqpppppppppppppppppq
qqpppppppppppppqqpv____________+pppppppppppppppppppppppppppppppppd__+________+__ppppppppppppppppppppppppppppppqqqO++__________+wqpqpppppppppppppppppq
qqppppppppppppppppf+___________+ppqppppppppppppppppppppppppppppppd+_+_______+___ppppppppppppppppppppppppppppppqqpm___________++Qqpqpppppppppppppppppq
qqpppppppppppppqpp{_____________ppqppppppppppppppppppppppppppppppd+__+_______+_?ppppppppppppppppppppppppppppppqqqq+____________zqqppppppppppppppppppq
qqpppppppppppppppq?_____________ppqppppppppppppppppppppppppppppppd+__+_______+_]ppppppppppppppppppppppppppppppqqqp+___________-rqqppppppppppppppppppq
qqpppppppppppppppp______________ppqppppppppppppppppppppppppppppppp__++_________}qppppppppppppppppppppppppppppppqpp_____________(pqppppppppppppppppppq
qqpppppppppppppppp_____________-pppppppppppppppppppppppppppppppppq__++++++++__+}qppppppppppppppppppppppppppppppqpp+____________{qqqpppppppppppppppppq
qqpppppppppppppppq_____________?pppppppppppppppppppppppppppppppppqppqqqqqqqqpqqwqppppppppppppppppppppppppppppppqpp_____________}qqqqqpppppppppppppppq
qqppppppppppppppqq_+___________[qpppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppqqpp_____________[qpucCtwpppppppppppppq
qqppppppppppppppqq_+__________+]qpppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppqqqp+___________+]pqjnttqqppppppppppppq
qqpppppppppppppqqpZmmmmmmZZZZZZZwpqqpppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppqpd)())11111{{{{)pqqpppqpppppppppppppq
qqppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppq
");
        }
         }
     }}
     

       
            

        
     
     
 



     


 