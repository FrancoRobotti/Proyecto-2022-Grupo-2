using System;
using System.Collections.Generic;
using System.IO;

namespace NavalBattle
{
    public class Ship
    {
        //private string initialCoord;

        private string direction;

        private int length;

        private bool sunk;

        private List<string> coords;

        public List<string> Coords 
        {
            get
            {
                return coords;
            }
        }
        
        public Ship (int length, string direction)
        {
            this.length = length;
            //this.initialCoord = initialCoord;
            this.direction = direction;
            this.sunk = false;
            this.coords = new List<string>();
        }


        public void AddShipCoord(string coord)
        {
            this.coords.Add(coord);
        }
    }
}