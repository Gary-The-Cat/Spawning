using SFML.Graphics;
using static SFML.Window.Keyboard;

namespace Game
{
    public static class Configuration
    { 
        public static float Scale = 1f;

        public static uint Height = (uint)(720 * Scale);

        public static uint Width = (uint)(1280 * Scale);

        public static Color Background => new Color(0x23, 0x23, 0x23);

        public static bool AllowCameraMovement => true;

        public static Key PanLeft => Key.A;

        public static Key PanRight => Key.D;

        public static Key PanUp => Key.W;

        public static Key PanDown => Key.S;

        public static Key ZoomIn => Key.Z;

        public static Key ZoomOut => Key.X;

        public static Key RotateRight => Key.Num1;

        public static Key RotateLeft => Key.Num2;

        public static FloatRect SinglePlayer => new FloatRect(0, 0, 1, 1);

        public static FloatRect TwoPlayerLeft => new FloatRect(0, 0, 0.5f, 1);

        public static FloatRect TwoPlayerRight => new FloatRect(0.5f, 0, 0.5f, 1);

        public static FloatRect FourPlayerTopLeft => new FloatRect(0, 0, 0.5f, 0.5f);

        public static FloatRect FourPlayerTopRight => new FloatRect(0.5f, 0, 0.5f, 0.5f);

        public static FloatRect FourPlayerBottomLeft => new FloatRect(0, 0.5f, 0.5f, 0.5f);

        public static FloatRect FourPlayerBottomRight => new FloatRect(0.5f, 0.5f, 0.5f, 0.5f);
    }
}