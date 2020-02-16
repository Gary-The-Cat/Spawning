using Game.Factories;
using Game.Helpers;
using Game.SFML_Text;
using SFML.Graphics;
using System.Collections.Generic;

namespace Game.Screens
{
    public class SimulationScreen : Screen
    {
        private FontText TotalDistance;

        private List<RectangleShape> townVisuals;


        public SimulationScreen(
            RenderWindow window,
            FloatRect configuration)
            : base(window, configuration)
        {
            this.townVisuals = new List<RectangleShape>();
            this.pathLines = new List<Vertex[]>();

            var towns = TownFactory.GetTowns();

            foreach(var town in towns)
            {
                this.townVisuals.Add(town.Shape);
            }
        }

        List<Vertex[]> pathLines;

        public void Update(List<int> sequence)
        {
            pathLines = TownHelper.GetTownSequencePath(sequence);
        }
        
        /// <summary>
        /// Draw - Here we don't update any of the components, only draw them in their current state to the screen.
        /// </summary>
        public void Draw()
        {
            foreach (var town in townVisuals)
            {
                window.Draw(town);
            }

            foreach (var pathLine in pathLines)
            {
                window.Draw(pathLine, 0, 2, PrimitiveType.LineStrip);
            }
        }
    }
}