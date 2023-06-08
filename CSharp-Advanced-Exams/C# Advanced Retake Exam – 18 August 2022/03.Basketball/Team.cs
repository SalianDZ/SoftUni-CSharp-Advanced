using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            players = new List<Player>();
        }

        private List<Player> players;

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public int Count { get { return players.Count;}}

        public string AddPlayer(Player player)
        {
            if (player.Position == null || player.Position == string.Empty || player.Name == null || player.Name == string.Empty)
            {
                return "Invalid player's information.";
            }
            if (OpenPositions <= 0)
            {
                return "There are no more open positions.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            if (players.Any(p => p.Name == name))
            {
                Player player = players.Where(p => p.Name == name).FirstOrDefault();
                players.Remove(player);
                OpenPositions++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RemovePlayerByPosition(string position)
        {
            if (players.Any(p => p.Position == position))
            {
                int count = players.Count(x => x.Position == position);
                players.RemoveAll(p => p.Position == position);
                OpenPositions += count;
                return count;
            }
            else
            {
                return 0;
            }
        }

        public Player RetirePlayer(string name)
        {
            if (players.Any(p => p.Name == name))
            {
                Player player = players.Where((p) => p.Name == name).FirstOrDefault();
                player.Retired = true;
                return player;
            }
            else
            {
                return null;
            }
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> players = new List<Player>();
            players.AddRange(this.players.Where(p => p.Games >= games));
            return players;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Active players competing for Team {Name} from Group {Group}:");

            foreach (var player in players.Where(p => p.Retired == false))
            {
                result.AppendLine(player.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}