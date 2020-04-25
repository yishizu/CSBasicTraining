using System;

namespace TicTac
{
    class Program
    {
        //Create the playfield
        static char[,] playfield =
        {
            {'1','2','3' },
            { '4','5','6'},
            { '7','8','9'}
        };

        

        static int turns;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;
            
            //Console.WriteLine("Hello World!");
            

            do
            {
                
                
                if (player == 2)
                {
                    player = 1;   
                }
                else if (player == 1) {
                    player = 2;
                }
                EnterXorO(player, input);
                Setfield();

                char[] playerChars = { 'x', 'o' };
                foreach (char pc in playerChars){
                    if(((playfield[0, 0] == pc) && (playfield[0, 1] == pc) && (playfield[0, 2] == pc))
                        || ((playfield[1, 0] == pc) && (playfield[1, 1] == pc) && (playfield[1, 2] == pc))
                        || ((playfield[2, 0] == pc) && (playfield[2, 1] == pc) && (playfield[2, 2] == pc))
                        || ((playfield[0, 0] == pc) && (playfield[1, 0] == pc) && (playfield[2,0] == pc))
                        || ((playfield[0, 1] == pc) && (playfield[1, 1] == pc) && (playfield[2, 1] == pc))
                        || ((playfield[0, 2] == pc) && (playfield[1, 2] == pc) && (playfield[2, 2] == pc))
                        || ((playfield[0, 0] == pc) && (playfield[1, 1] == pc) && (playfield[2, 2] == pc))
                        || ((playfield[2, 1] == pc) && (playfield[1, 1] == pc) && (playfield[0, 2] == pc)))
                    {
                        Console.WriteLine("We have a winner!! {0}", pc);
                        Console.WriteLine("Please reset by press any key");
                        Console.ReadKey();
                        Resetfield();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("Draw!!");
                        Console.WriteLine("Please reset by press any key");
                        Console.ReadKey();
                        Resetfield();
                        break;
                    }
                }

                do
                {
                    Console.WriteLine("Player {0}: Chose our field!",player);
                    try
                    {
                        string inputStr = Console.ReadLine();
                        input = int.Parse(inputStr);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter the number");
                    }
                    if ((input == 1) && (playfield[0, 0] =='1')){
                        inputCorrect = true;
                    }else if ((input == 2) && (playfield[0, 1] == '2')){
                        inputCorrect = true;
                    }else if ((input == 3) && (playfield[0, 2] == '3')){
                        inputCorrect = true;
                    }else if ((input == 4) && (playfield[1, 0] == '4')){
                        inputCorrect = true;
                    }else if ((input == 5) && (playfield[1, 1] == '5')){
                        inputCorrect = true;
                    }else if ((input == 6) && (playfield[1, 2] == '6')){
                        inputCorrect = true;
                    }else if ((input == 7) && (playfield[2, 0] == '7')){
                        inputCorrect = true;
                    }else if ((input == 8) && (playfield[2, 1] == '8')){
                        inputCorrect = true;
                    }else if ((input == 9) && (playfield[2, 2] == '9')){
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Please chose empty number!");
                        inputCorrect = false;
                    }
                    

                } while (!inputCorrect);
                
                


            } while (true);
        }

         
        public static void Setfield()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[0,0], playfield[0,1], playfield[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("     |     |     ");
           
        }

        public static void Resetfield()
        {
            char[,] playfieldInitial =
                {
                    {'1','2','3' },
                    { '4','5','6'},
                    { '7','8','9'}
                };
            playfield = playfieldInitial;
            Setfield();
        }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'x';
            else if (player == 2)
                playerSign = 'o';
            switch (input)
            {
                case 1:
                    playfield[0, 0] = playerSign;
                    break;
                case 2:
                    playfield[0, 1] = playerSign;
                    break;
                case 3:
                    playfield[0, 2] = playerSign;
                    break;
                case 4:
                    playfield[1, 0] = playerSign;
                    break;
                case 5:
                    playfield[1, 1] = playerSign;
                    break;
                case 6:
                    playfield[1, 2] = playerSign;
                    break;
                case 7:
                    playfield[2, 0] = playerSign;
                    break;
                case 8:
                    playfield[2, 1] = playerSign;
                    break;
                case 9:
                    playfield[2, 2] = playerSign;
                    break;

            }
        }
    }
}
