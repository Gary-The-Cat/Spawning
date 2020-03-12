using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game.GeneticAlgorithm
{
    public class Neighbour
    {
        private static Random random = new Random();

        public List<int> Sequence { get; set; }

        public Neighbour(List<int> sequence)
        {
            this.Sequence = sequence;
        }

        public double GetFitness()
        {
            return random.NextDouble();
        }
    }
}
