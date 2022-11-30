﻿using System.Drawing;

namespace TryOut.AbstractFactory.RefactoredCode
{
    public class Game
    {
        public Game() 
        {
            var player = new Player
            {
                Race = RaceType.Protos
            };

            var infantry = player.CreateInfantry();
            infantry.Point = new Point(1, 1);

            var infantry1 = player.CreateInfantry();
            infantry1.Point = new Point(2, 3);

            infantry.Draw();
            infantry1.Draw();
        }
    }
}
