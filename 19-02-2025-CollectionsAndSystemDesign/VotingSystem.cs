using System;
using System.Collections.Generic;

class VotingSystem
{
    private Dictionary<string, int> votes = new Dictionary<string, int>();
    private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
    private LinkedList<string> voteOrder = new LinkedList<string>();

    public void CastVote(string candidate)
    {
        if (votes.ContainsKey(candidate))
        {
            votes[candidate]++;
        }
        else
        {
            votes[candidate] = 1;
        }

        sortedVotes[candidate] = votes[candidate];
        voteOrder.AddLast(candidate);
    }

    static void Main()
    {
        VotingSystem voting = new VotingSystem();
        voting.CastVote("Tushar");
        voting.CastVote("Parashar");
        voting.CastVote("GLA");

        Console.WriteLine("Votes:");
        foreach (KeyValuePair<string, int> entry in voting.sortedVotes)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }
}
