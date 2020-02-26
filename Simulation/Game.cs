using Game.GeneticAlgorithm;
using Game.Screens;
using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace Game
{
    public class Game
    {
        SimulationScreen screen;
        RenderWindow window;
        World world;
        
        public Game()
        {
            // Create the main window
            window = new RenderWindow(new VideoMode(Configuration.Width, Configuration.Height), "Simulation");
            window.SetFramerateLimit(1);

            // Handle window events
            window.Closed += OnClose;

            // Create a simulation screen. Note that screens can be stacked on top of one another
            // in the screen manager that has been omitted from this specific repository.
            screen = new SimulationScreen(window, Configuration.SinglePlayer);

            // Create our world
            world = new World();
        }

        public void Run()
        {
            world.Spawn();

            while (window.IsOpen)
            {
                // Clear the previous frame
                window.Clear(Configuration.Background);
                
                // Process events
                window.DispatchEvents();

                // Draw the paths of the current best individual
                screen.UpdateSequence(new List<int>());
                screen.Draw();

                // Update the window
                window.Display();

                // Breed the next generation
                //world.DoGeneration();
            }
        }

        private static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
    }
}