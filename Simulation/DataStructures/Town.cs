using Game.Factories;
using Game.Helpers;
using SFML.Graphics;
using SFML.System;

namespace Game.DataStructures
{
    public class Town
    {
        public Town(Vector2f position, Texture texture)
        {
            this.Position = position;

            this.Shape = new RectangleShape(new Vector2f(100, 100))
            {
                Texture = texture,
                Origin = new Vector2f(50, 50),
                Position = position,
            };

            Id = TownHelper.TownId;
        }

        public Vector2f Position { get; set; }

        public RectangleShape Shape { get; set; }

        public int Id { get; set; }

        public void Draw(RenderWindow window)
        {
            window.Draw(Shape);
        }
    }
}
