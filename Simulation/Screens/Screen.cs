using Game.ViewTools;
using SFML.Graphics;

namespace Game.Screens
{
    public class Screen
    {
        public Camera Camera { get; set; }

        public bool IsUpdate { get; set; }

        public bool IsDraw { get; set; }

        internal RenderWindow window;

        public Screen (RenderWindow window, FloatRect configuration)
        {
            this.window = window;

            Camera = new Camera(configuration);

            IsUpdate = true;
            IsDraw = true;
        }

        public virtual void Update(float deltaT)
        {
        }

        public virtual void Draw(float deltaT)
        {
        }

        public virtual void InitializeScreen()
        {

        }

        public void SetInactive()
        {
            IsUpdate = false;
            IsDraw = false;
        }

        public void SetActive()
        {
            IsUpdate = true;
            IsDraw = true;
        }

        public void SetUpdateInactive()
        {
            IsUpdate = false;
        }

        public void SetDrawInactive()
        {
            IsDraw = false;
        }

        public void SetUpdateActive()
        {
            IsUpdate = true;
        }

        public void SetDrawActive()
        {
            IsDraw = true;
        }

        internal void Initialize()
        {
        }
    }
}
