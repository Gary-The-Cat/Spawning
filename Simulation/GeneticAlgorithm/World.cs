using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.GeneticAlgorithm
{
    public class World
    {
        public int PopulationCount = 100;

        public List<Neighbour> Neighbours { get; set; }

        public Neighbour BestNeighbour => 
            Neighbours.OrderBy(n => n.GetFitness()).FirstOrDefault();

        public World()
        {
            Neighbours = new List<Neighbour>();
        }

        public void Spawn()
        {
            // Generate {PopulationCount} neighbours
            for(int i = 0; i < this.PopulationCount; i++)
            {
                this.Neighbours.Add(GenerateNeighbour());
            }
        }

        private Neighbour GenerateNeighbour()
        {
            throw new NotImplementedException();
        }

        public void DoGeneration()
        {
            throw new NotImplementedException();
        }
    }
}
