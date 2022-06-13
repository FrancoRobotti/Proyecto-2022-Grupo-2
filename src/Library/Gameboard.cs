using System;
using System.Collections.Generic;
using System.IO;

namespace NavalBattle
{
    public class Gameboard : IGameboardContent
    {   
        private int side;

        private string[,] gameboard;

        private List<Ship> ships;

        private List<Bomb> bombs;

        public Gameboard (int side)
        {
            this.side = side;

            this.gameboard = new string[side,side];

            this.ships = new List<Ship>();

            //if (Match.Bombs == true) 
            this.bombs = new List<Bomb>();
        }   

        //Los Ship se crean en Gameboard por creator.
        public void addShip(int length, string initialCoord, string direction)
        {
            Ship ship = new Ship(length, direction);
            
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
                    initialCoordY--;
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

                    foreach (string coord in ship.Coords)
                    {
                        int shipCoordX = (int)Char.GetNumericValue(coord[0]);
                        int shipCoordY = (int)Char.GetNumericValue(coord[1]);

                        this.gameboard[shipCoordX, shipCoordY] = "o";
                    }
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
            return this.gameboard;
        }

        public void RecieveAttack(string coord)
        {   
            int woundedShipChecker = 0;

            foreach (Ship placedShip in ships)
            {
                if (placedShip.Coords.Contains(coord))
                {
                    woundedShipChecker += 1;
                }
            }
            if (woundedShipChecker == 1)
            {
                int attackCoordX = (int)Char.GetNumericValue(coord[0]);
                int attackCoordY = (int)Char.GetNumericValue(coord[1]);

                this.gameboard[attackCoordX, attackCoordY] = "x";
            }
        }
    }
}
