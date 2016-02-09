using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Adventure
{
    using System.Collections.Generic;
    using Model;
    using Config;
    public class PlayerController
    {
        // Does the class need a public List<Player>?
        public List<Player> players;
        private PlayerData data;
        private Player player;

        public PlayerController()
        {
            data = new PlayerData();
            players = ReadPlayers();
        }

        public void CreateNewPlayer(string name)
        {
            player = new Player(name);
            data.CreateNewPlayer(player);
            players.Add(player);
        }

        public List<Player> ReadPlayers()
        {
            return data.ReadPlayers();
        }

        public void UpdatePlayer(Player player)
        {
            data.UpdatePlayer(player);
        }

        public void DeletePlayer(Player player)
        {
            data.DeletePlayer(player);
        }
    }
}
