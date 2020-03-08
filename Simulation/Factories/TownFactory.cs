using Game.DataStructures;
using Game.Helpers;
using SFML.Graphics;
using System.Collections.Generic;

namespace Game.Factories
{
    public static class TownFactory
    {
        public static List<Town> GetTowns()
        {
            var towns = new List<Town>();

            for(int i = 0; i < TownHelper.TownPositions.Count; i++)
            {
                var townPosition = TownHelper.TownPositions[i];
                towns.Add(new Town(townPosition, new Texture($"../../Resources/Town_{i+1}.png")));
            }

            return towns;
        }
    }
}
