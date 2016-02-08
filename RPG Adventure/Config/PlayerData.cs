namespace RPG_Adventure.Config
{
    using System.Data.SqlClient;
    using Model;
    using System;
    using System.Data;
    using System.Collections.Generic;
    class PlayerData
    {
        SqlConnection conn;

        public PlayerData()
        {
            conn = GetConnectionString();
        }

        public void CreateNewPlayer(Player player)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("CreateNewPlayer", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@name", player.Name));
                sqlcmd.Parameters.Add(new SqlParameter("@currenthitpoints", player.CurrentHitPoints));
                sqlcmd.Parameters.Add(new SqlParameter("@maximumhitpoints", player.MaximumHitPoints));
                sqlcmd.Parameters.Add(new SqlParameter("@level", player.Level));
                sqlcmd.Parameters.Add(new SqlParameter("@experiencepoints", player.ExperiencePoints));
                sqlcmd.Parameters.Add(new SqlParameter("@gold", player.Gold));
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw new ArgumentException("CreateNewPlayer failed");
            }
        }

        public List<Player> ReadPlayers()
        {
            List<Player> players = new List<Player>();
            try
            {
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("ReadPlayers", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(table);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                reader.Read();
                foreach (DataRow row in table.Rows)
                {
                    Player player = new Player(row["Name"].ToString());
                    player.CurrentHitPoints = int.Parse(row["currentHitPoints"].ToString());
                    player.MaximumHitPoints = int.Parse(row["maximumHitPoints"].ToString());
                    player.Level = byte.Parse(row["Level"].ToString());
                    player.ExperiencePoints = int.Parse(row["experiencePoints"].ToString());
                    player.Gold = int.Parse(row["gold"].ToString());
                    players.Add(player);
                }
                conn.Close();
                return players;
            }
            catch (Exception)
            {
                throw new ArgumentException("LoadPlayers failed");
            }
        }

        public void UpdatePlayer(Player player)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("UpdatePlayer", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@name", player.Name));
                sqlcmd.Parameters.Add(new SqlParameter("@currenthitpoints", player.CurrentHitPoints));
                sqlcmd.Parameters.Add(new SqlParameter("@maximumhitpoints", player.MaximumHitPoints));
                sqlcmd.Parameters.Add(new SqlParameter("@level", player.Level));
                sqlcmd.Parameters.Add(new SqlParameter("@experiencepoints", player.ExperiencePoints));
                sqlcmd.Parameters.Add(new SqlParameter("@gold", player.Gold));
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw new ArgumentException("UpdatePlayer failed");
            }
        }

        public void DeletePlayer(Player player)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("DeletePlayer", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@name", player.Name));
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw new ArgumentException("DeletePlayer failed");
            }
        }

        private SqlConnection GetConnectionString()
        {
            return new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                @"AttachDbFilename =|DataDirectory|\Config\MainDatabase.mdf;" +
                @"Integrated Security=True"
                );
        }
    }
}
