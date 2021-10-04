using System;

namespace Electric_Boogaloo
{
    public class Fighter
    {
        public string name = "";

        public int hp = 150;

        public Random DMG = new Random();

        public int Attack()
        {
            return DMG.Next(0, 50);
        }
    }
}