using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var vlogers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Statistics")
                {
                    break;
                }
                if (input.Contains("joined"))
                {
                    string username = input.Split()[0];
                    if (!vlogers.ContainsKey(input.Split()[0]))
                    {
                        vlogers.Add(username, new Dictionary<string, HashSet<string>>());
                        vlogers[username].Add("followings", new HashSet<string>());
                        vlogers[username].Add("followers", new HashSet<string>());

                    }
                }
                else if (input.Contains("followed"))
                {
                    string[] username = input.Split();
                    string firstVloger = username[0];
                    string secondVloger = username[2];
                    if (!vlogers.ContainsKey(firstVloger)
                        || !vlogers.ContainsKey(secondVloger)
                        || firstVloger == secondVloger)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    vlogers[firstVloger]["followings"].Add(secondVloger);
                    vlogers[secondVloger]["followers"].Add(firstVloger);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            var sortedVogers = vlogers
                .OrderByDescending(f => f.Value["followers"].Count)
                .ThenBy(f => f.Value["followings"].Count)
                .ToDictionary(k => k.Key, y => y.Value);
            int count = 1;
            foreach (var (username, value) in sortedVogers)
            {
                int followersCount = sortedVogers[username]["followers"].Count;
                int followingsCount = sortedVogers[username]["followings"].Count;
                Console.WriteLine($"{count}. {username} : {followersCount} followers, {followingsCount} following");
                if (count == 1)
                {
                    var followersCollection = value["followers"].OrderBy(x => x).ToList();
                    foreach (var userName in followersCollection)
                    {
                        Console.WriteLine($"*  {userName}");
                    }

                }
                count++;
            }

        }
    }
}

