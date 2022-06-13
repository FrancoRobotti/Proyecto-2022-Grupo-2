using System;
using System.Collections.Generic;
using System.IO;

namespace NavalBattle
{
    public class Ship
    {
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

        private List<Coords> coords;
    
        public List<Coords> Coords 
        {
            get 
            {
                return coords;
            }
        }
        
        public Ship (int length, string direction)
        {
            this.length = length;
            this.direction = direction;
            shipState = State.Healthy;
            coords = new List<Coords>();
        }

        public void AddShipCoord(string coordString)
        {
            Coords coord = new Coords(coordString);
            coords.Add(coord);
        }
    }
}