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
        static void Main(string[] args)
        {
            int Player1 = 0;
            Console.WriteLine("Player Position is " + Player1);
            Program obj = new Program();
            int DieValue = obj.RollDie();
            Console.WriteLine("Roll Die value is : " + DieValue);
        }
    }
}
