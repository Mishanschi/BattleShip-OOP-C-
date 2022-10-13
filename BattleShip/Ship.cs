﻿using BattleShip.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleShip
{
    public class Ship
    {
        public object type;
        public int length;
        public List<Square> PositionOfShip;

        

        public Ship(ShipType shipType)
        {
            PositionOfShip = new();
           /* var values = Enum.GetValues(typeof(ShipType)).Cast<ShipType>().ToList();*/
            /*this.type = values[indexOfEnum];*/
            /*if (values[indexOfEnum] == ShipType.Carrier)
            {
                this.length = 5;
            }
            if (values[indexOfEnum] == ShipType.Battleship)
            {
                this.length = 4;
            }
            if (values[indexOfEnum] == ShipType.Cruiser || values[indexOfEnum] == ShipType.Submarine)
            {
                this.length = 3;
            }
            if (values[indexOfEnum] == ShipType.Destroyer)
            {
                this.length = 2;
            }*/
            this.length = (int)shipType + 1;
            this.type = shipType;

        }
    }
}
