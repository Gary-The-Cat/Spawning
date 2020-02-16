using Game.DataStructures;
using Game.Helpers;
using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Factories
{
    public static class TownFactory
    {
        public static List<Town> GetTowns()
        {
            var towns = new List<Town>();

            var texture = new Texture("../../Resources/Town_1.png");

            foreach (var townPositoin in TownHelper.TownPositions)
            {
                towns.Add(new Town(townPositoin, texture));
            }

            return towns;
        }
    }
}
