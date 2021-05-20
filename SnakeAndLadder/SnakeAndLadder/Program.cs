using System;

namespace SnakeAndLadder
{
    class Program
    {
        static int flag = 0;
        public int RollDie()
        {
            Random random = new Random();
            int DieValue = random.Next(1, 7);
            return DieValue;
        }
        public void Change_Player()
        {
            if (flag == 1)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
            }
        }
        public int Check_Option(int DieValue, int Player1, int PrePosition)
        {
            Random random = new Random();
            int Option = random.Next(0, 3);

            switch (Option)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    Player1 = Player1 + DieValue;
                    break;
                case 2:
                    Console.WriteLine("Snake");
                    Player1 = Player1 - DieValue;
                    if (Player1 < 0)
                    {
                        Player1 = 0;
                    }
                    Change_Player();
                    break;
                default:
                    Console.WriteLine("No Play");
                    Change_Player();
                    break;
            }
            return Player1;
        }
        static void Main(string[] args)
        {
            int Player1 = 0;
            int Player2 = 0;
            int Player1Count = 0;
            int Player2Count = 0;
            int DieValue;
            while (Player1 < 100 && Player2 < 100)
            {
                Console.WriteLine("--------------");

                Program obj = new Program();
                if (flag == 0)
                {

                    Console.WriteLine("#Player One Played the game#");
                    DieValue = obj.RollDie();
                    Console.WriteLine("Roll Dice value is : " + DieValue);
                    Player1Count = Player1Count + 1;
                    int Player1_Previous_Postion = Player1;
                    Player1 = obj.Check_Option(DieValue, Player1, Player1_Previous_Postion);
                    if (Player1 > 100)
                    {
                        Player1 = Player1_Previous_Postion;
                    }

                }

                else
                {
                    Console.WriteLine("#Player Two Played the game#");
                    DieValue = obj.RollDie();
                    Console.WriteLine("Roll Dice value is : " + DieValue);
                    Player2Count = Player2Count + 1;
                    int Player2_Previous_Postion = Player2;
                    Player2 = obj.Check_Option(DieValue, Player2, Player2_Previous_Postion);
                    if (Player2 > 100)
                    {
                        Player2 = Player2_Previous_Postion;
                    }

                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Player1 Position is : " + Player1);
                Console.WriteLine("Player2 Position is : " + Player2);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("No of times dice roll for player 1: " + Player1Count);
            Console.WriteLine("No of times dice roll for player 2: " + Player2Count);
            if (Player1 == 100)
            {
                Console.WriteLine("Player 1 Won the game");
            }
            else
            {
                Console.WriteLine("Player 2 Won the game");
            }

        }
    }
}
