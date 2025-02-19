namespace VotingSystem
{
	class Program
	{
        static void Main()
        {
            Voting votingSystem = new Voting();

            string[] candidates = { "Alice", "Bob", "Alice", "Charlie", "Bob", "Alice" };
            foreach (var candidate in candidates)
                votingSystem.CastVote(candidate);

            votingSystem.DisplayResults();
        }
    }
}