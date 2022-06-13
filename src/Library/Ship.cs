using System;
using System.Collections.Generic;
using System.IO;

namespace NavalBattle
{
    public class Ship
    {
        private string initialCoord;

        private string direction;

        private int length;

        public enum State
        {
            Healthy, Damaged, Sunk
        }

        private State shipState;

        public State ShipState
        {
            get
            {
                return this.shipState;
            }

            set
            {
                this.shipState = ShipState;
            }
        }

        private List<string> coords;
    
        public List<string> Coords 
        {
            get 
            {
                return coords;
            }
        }
        
        public Ship (int length, string initialCoord, string direction)
        {
            this.length = length;
            this.initialCoord = initialCoord;
            this.direction = direction;
            shipState = State.Healthy;
            coords = new List<string>();
        }

        public void AddShipCoord(string coord)
        {
            coords.Add(coord);
        }
    }
}