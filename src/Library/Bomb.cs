using System;

namespace NavalBattle
{
    public class Bomb
    {
        private Coords coord;

        public Coords Coords
        {
            get
            {
                return this.coord;
            }
        }

        public Bomb (Coords coord)
        {
            this.coord = coord;
        }
    }
}