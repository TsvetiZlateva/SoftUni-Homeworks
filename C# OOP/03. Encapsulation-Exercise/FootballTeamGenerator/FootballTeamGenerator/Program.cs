using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    if (command == "END")
                    {
                        break;
                    }

                    var tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

                    if (tokens[0] == "Team")
                    {
                        string teamName = tokens[1];
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }

                    if (tokens[0] == "Add")
                    {
                        string teamName = tokens[1];
                        string playerName = tokens[2];
                        int endurance = int.Parse(tokens[3]);
                        int sprint = int.Parse(tokens[4]);
                        int dribble = int.Parse(tokens[5]);
                        int passing = int.Parse(tokens[6]);
                        int shooting = int.Parse(tokens[7]);
                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        if (!teams.Any(x => x.Name == teamName))
                        {
                            throw new Exception($"Team {teamName} does not exist.");
                        }

                        else
                        {
                            teams.FirstOrDefault(x => x.Name == teamName).AddPlayer(player);
                        }
                    }

                    if (tokens[0] == "Remove")
                    {
                        string teamName = tokens[1];
                        string playerName = tokens[2];
                        var team = teams.FirstOrDefault(x => x.Name == teamName);                   
                        team.RemovePlayer(playerName);
                    }

                    if (tokens[0] == "Rating")
                    {
                        string teamName = tokens[1];

                        if (!teams.Any(x => x.Name == teamName))
                        {
                            throw new Exception($"Team {teamName} does not exist.");
                        }

                        else
                        {
                            Console.WriteLine($"{teamName} - {teams.FirstOrDefault(x => x.Name == teamName).Rating}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
