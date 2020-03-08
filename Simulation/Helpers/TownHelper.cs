using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using Game.ExtensionMethods;

namespace Game.Helpers
{
    public static class TownHelper
    {
        private const int Linethickness = 4;
        private const int PathOffsetFromTown = 180;

        public static List<ConvexShape> GetTownSequencePath(List<int> townSequence)
        {
            var paths = new List<ConvexShape>();

            for(int i = 1; i < townSequence.Count; i++)
            {
                var fromTown = TownPositions[townSequence[i - 1]];
                var toTown = TownPositions[townSequence[i]];

                var directionVector = (toTown - fromTown).Normalize();

                var startingPoint = fromTown + (directionVector * PathOffsetFromTown);
                var endingPoint = toTown - (directionVector * PathOffsetFromTown);

                var lumination = Convert.ToByte((20) * (i - 1));

                paths.Add(SFMLGraphicsHelper.GetLine(startingPoint, endingPoint, Linethickness, new Color(lumination, lumination, lumination)));
            }

            return paths;
        }

        private static int townId { get; set; }

        public static int TownId
        {
            get
            {
                return townId++;
            }
        }

        public static List<Vector2f> TownPositions = new List<Vector2f>()
        {
            new Vector2f(3060, 1300), 
            new Vector2f(1050, 450),
            new Vector2f(450, 750),
            new Vector2f(690, 1890),
            new Vector2f(1410, 1830),
            new Vector2f(2070, 1560),
            new Vector2f(1725, 1080),
            new Vector2f(3360, 810),
            new Vector2f(3450, 1770),
            new Vector2f(2460, 240),
        };
    }
}
