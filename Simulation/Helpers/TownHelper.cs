using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using Game.ExtensionMethods;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Helpers
{
    public static class TownHelper
    {
        public static List<Vertex[]> GetTownSequencePath(List<int> townSequence)
        {
            var paths = new List<Vertex[]>();

            for(int i = 1; i < townSequence.Count; i++)
            {
                var fromTown = TownPositions[townSequence[i - 1]];
                var toTown = TownPositions[townSequence[i]];

                var directionVector = (toTown - fromTown).Normalize();

                var startingPoint = fromTown + (directionVector * 75);
                var endingPoint = toTown - (directionVector * 75);

                paths.Add(new Vertex[2]
                {
                new Vertex(startingPoint),
                new Vertex(endingPoint)
                });
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
            new Vector2f(1020, 450),
            new Vector2f(350, 150),
            new Vector2f(150, 250),
            new Vector2f(340, 330),
            new Vector2f(470, 480),
            new Vector2f(690, 520),
            new Vector2f(575, 360),
            new Vector2f(1020, 270),
            new Vector2f(950, 500),
            new Vector2f(820, 150),
        };
    }
}
