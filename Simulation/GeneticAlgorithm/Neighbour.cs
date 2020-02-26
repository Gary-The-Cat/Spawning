using System.Collections.Generic;

namespace Game.GeneticAlgorithm
{
    public class Neighbour
    {
        public List<int> Sequence { get; set; }

        public Neighbour(List<int> sequence)
        {
            this.Sequence = sequence;
        }

        public double GetFitness()
        {
            return -1;
        }
    }
}
