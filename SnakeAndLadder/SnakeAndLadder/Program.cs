using System;

namespace SnakeAndLadder
{
    class Program
    {
        public int RollDie()
        {
            Random random = new Random();
            int Player = random.Next(1, 7);
            return Player;
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
                    break;
                default:
                    Console.WriteLine("No Play");
                    break;
            }
            return Player1;
        }
        static void Main(string[] args)
        {
            int Player1 = 0;
            int dieRollCount = 0;
            while (Player1 < 100)
            {
                Console.WriteLine("--------------");
                dieRollCount++;
                Program obj = new Program();
                int DieValue = obj.RollDie();
                Console.WriteLine("Roll Die value is : " + DieValue);
                int PrePostion = Player1;
                Player1 = obj.Check_Option(DieValue, Player1, PrePostion);

                if (Player1 > 100)
                {
                    Player1 = PrePostion;
                }
                Console.WriteLine("Player 1 Position is : " + Player1);
            }
            Console.WriteLine("The Total number of time die was rolled to win :" + dieRollCount);

        }

    }   
}   
