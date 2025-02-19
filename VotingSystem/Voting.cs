using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    internal class Voting
    {
        private Dictionary<string, int> votes = new Dictionary<string, int>();
        private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
        private LinkedList<string> voteOrder = new LinkedList<string>();

        public void CastVote(string candidate)
        {
            if (votes.ContainsKey(candidate))
                votes[candidate]++;
            else
                votes[candidate] = 1;

            sortedVotes[candidate] = votes[candidate];
            voteOrder.AddLast(candidate);
        }

        public void DisplayResults()
        {
            Console.WriteLine("\nSorted Results:");
            foreach (var entry in sortedVotes)
                Console.WriteLine($"{entry.Key}: {entry.Value}");

            Console.WriteLine("\nVote Order:");
            foreach (var candidate in voteOrder)
                Console.Write(candidate + " ");
        }
    }
}
