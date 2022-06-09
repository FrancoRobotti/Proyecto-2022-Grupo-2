using System;
using System.Collections.Generic;
using System.IO;

namespace NavalBattle
{
    public class Gameboard
    {   
        private int side;

        //private string[,] gameboard;

        private List<Ship> ships;

        private List<Bomb> bombs;

        public Gameboard (int side)
        {
            this.side = side;

            //this.gameboard = new string[side,side];

            this.ships = new List<Ship>();

            //if (Match.Bombs == true) 
            this.bombs = new List<Bomb>();
        }   

        //Los Ship se crean en Gameboard por creator.
        public void addShip(int length, string initialCoord, string direction)
        {
            Ship ship = new Ship(length, initialCoord, direction);
            
            int initialCoordX = (int)Char.GetNumericValue(initialCoord[0]);
            int initialCoordY = (int)Char.GetNumericValue(initialCoord[1]);

            bool validShip = true;

            //El Ship es una lista de coordenadas(string), donde el usuario ingresa la coordenada inicial, largo y direccion del barco. 
            //Con estos datos se checkea si es valida la posicion del barco en el tablero y se agregan al barco el resto de sus coordenadas. 
            if ((direction == "N") && (initialCoordX - length >= -1))
            {
                for (int i = 0; i < length; i++)
                {                                      
                    ship.AddShipCoord(initialCoordX.ToString() + initialCoordY.ToString());
                    initialCoordX--; 
                }
            }  
            else if ((direction == "E") && (initialCoordY + length <= this.side))
            {
                for (int i = 0; i < length; i++)
                {
                    ship.AddShipCoord(initialCoordX.ToString() + initialCoordY.ToString());
                    initialCoordY++;
                }
            }
            else if ((direction == "S") && (initialCoordX + length <= this.side))
            {
                for (int i = 0; i < length; i++)
                {
                    ship.AddShipCoord(initialCoordX.ToString() + initialCoordY.ToString());
                    initialCoordX++;
                }
            }
            else if ((direction == "W") && (initialCoordY - length >= -1))
            {
                for (int i = 0; i < length; i++)
                {
                    ship.AddShipCoord(initialCoordX.ToString() + initialCoordY.ToString());
                    initialCoordY++;
                }
            }
            else
            {
                validShip = false;
                Console.WriteLine("Barco fuera de rango");
            }

            //Si el barco fue creado con exito, tambien tenemos que evaluar que no comparta ninguna de sus coordenadas con otro barco.
            if (validShip)
            {
                int validShipCounter = 0;

                foreach (Ship placedShip in ships)
                {
                    foreach (string coord in ship.Coords)
                    {
                        if (placedShip.Coords.Contains(coord))
                        {
                            validShipCounter += 1;
                        }
                    }
                }

                if (validShipCounter == 0)
                {
                    ships.Add(ship);
                    Console.WriteLine("Barco colocado correctamente");

                }
                else
                {
                    Console.WriteLine("Barcos superpuestos");
                }
            }     
        }
        
        //Las Bomb se crean en Gameboard por creator.
        public void AddBomb()
        {   
            Random rnd = new Random();
            
            int bombCoordX = rnd.Next(0, this.side -1);

            int bombCoordY = rnd.Next(0, this.side - 1);

            Bomb bomb = new Bomb(bombCoordX.ToString() + bombCoordY.ToString());

            bombs.Add(bomb);
        }

        public string[,] GetGameboardToPrint()
        {
            string[,] res = new string[this.side , this.side];

            for (int i = 0; i < this.side; i++)
            {
                for (int j = 0; i < this.side; i++)
                {
                   foreach (Ship ship in ships)
                   {
                       if (ship.Coords.Contains(i.ToString() + j.ToString()))
                       {
                           res[i,j] = "o";
                       }
                       else
                       {
                           res[i,j] = "~";
                       }
                   }
                }
            }
            return res;
        }
    }
}
