﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{

    public class Battleship
    {
        private Display display;
        private Input input;
        private BoardFactory boardFactory;

        public Battleship()
        {
            display = new();
            input = new();
            boardFactory = new();
        }
        public void Run()
        {
            display.Greetings();
            string placementOption;
            Player player1 = new(input.GetNameForPlayer(display), input.GetHowManyShips(display));
            Player player2 = new(input.GetNameForPlayer(display), input.GetHowManyShips(display));
            Game game = new();

            bool printWithShips = true;
            display.PrintBoard(game.board1, game.board2, printWithShips);

            placementOption = input.GetManualOrRandomPlacement(display, player1);
            if (placementOption.ToUpper() == "M")
            {

                boardFactory.ManualPlacement(0, game, player1, game.board1, input, display);
            }
            else
            {
                boardFactory.RandomPlacement(0, game, player1, game.board1, input, display);

            }
            placementOption = input.GetManualOrRandomPlacement(display, player2);
            if (placementOption.ToUpper() == "M")
            {

                boardFactory.ManualPlacement(0, game, player2, game.board2, input, display);
            }
            else
            {
                boardFactory.RandomPlacement(0, game, player2, game.board2, input, display);

            }
            game.GameBegins(player1, player2, display, input);

        }
    }
}
