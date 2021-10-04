using System;

namespace Electric_Boogaloo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter player = new Fighter();
            Fighter opponent = new Fighter();

            player.name = "";
            opponent.name = "";

            bool opponentWin = false;
            bool playerWin = false;
            bool Draw = false;


            while (player.name == "")
            {
                Console.WriteLine("Whats your name?");
                player.name = Console.ReadLine();
                Console.WriteLine($"Ok so, you are {player.name}? Alright");
            }

            while (opponent.name == "")
            {
                Console.WriteLine("Who would you like to fight?");
                opponent.name = Console.ReadLine();
                Console.WriteLine($"So you'd like to face off against {opponent.name}, huh?");
                Console.WriteLine("Alright.");
                Console.ReadLine();
                Console.WriteLine("Let the battle begin");
                Console.WriteLine($"{player.name}'s hp: {player.hp}");
                Console.WriteLine($"{opponent.name}'s hp: {opponent.hp}");
                Console.ReadLine();
            }

            while (player.hp > 0 && opponent.hp > 0)
            {
                int playerdmg = player.Attack();
                int opponentdmg = opponent.Attack();
                opponent.hp -= playerdmg;
                player.hp -= opponentdmg;
                Console.WriteLine($"{opponent.name} took {playerdmg} amount of damedge, they have {opponent.hp} hp left");
                Console.WriteLine($"You took {opponentdmg} amount of damedge, you have {player.hp} hp left");


                if (player.hp <= 0)
                {
                    player.hp = 0;
                }
                if (opponent.hp <= 0)
                {
                    opponent.hp = 0;
                }
                if (player.hp == 0 && player.hp < opponent.hp)
                {
                    opponentWin = true;
                }
                if (opponent.hp == 0 && opponent.hp < player.hp)
                {
                    playerWin = true;
                }
                Console.ReadLine();
                if (player.hp == 0 && opponent.hp == 0)
                {
                    Draw = true;
                }
            }

            if (playerWin == true)
            {
                Console.WriteLine($"{player.name} is victorious!!!");
                Console.ReadLine();
            }
            if (opponentWin == true)
            {
                Console.WriteLine($"{opponent.name} is victorious!!!");
                Console.ReadLine();
            }
            if (Draw == true)
            {
                Console.WriteLine("It is a draw!!!");
                Console.ReadLine();
            }
        }
    }
}
