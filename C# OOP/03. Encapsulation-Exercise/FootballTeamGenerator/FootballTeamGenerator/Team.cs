using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private int rating;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }

                name = value;
            }
        }
        public int Rating => GetRating();

        public IReadOnlyCollection<Player> Players { get => this.players.AsReadOnly(); }

        public void AddPlayer(Player player)
        {
            if (player != null)
            {
                players.Add(player);
            }
        }

        public void RemovePlayer(string playerName)
        {
            if (!players.Any(x => x.Name == playerName))
            {
                throw new Exception($"Player {playerName} is not in {this.Name} team.");
            }
            var p = players.FirstOrDefault(x => x.Name == playerName);
            players.Remove(p);
        }

        private int GetRating()
        {
            double rating = 0;
            foreach (var player in Players)
            {
                rating += player.GetStats();
            }
            return (int)Math.Ceiling(rating);
        }
    }
}
