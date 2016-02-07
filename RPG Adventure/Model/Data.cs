using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RPG_Adventure
{
    class Data
    {
        SqlConnection conn = GetSqlConnection();

        public List<Hero> LoadHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            try
            {
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("LoadHeroes", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(table);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                reader.Read();
                foreach (DataRow row in table.Rows)
                {
                    Hero hero = new Hero();
                    hero.Name = row["Name"].ToString();
                    hero.CurrentHealth = int.Parse(row["CurrentHealth"].ToString());
                    hero.MaxHealth = int.Parse(row["MaxHealth"].ToString());
                    hero.MinDamage = int.Parse(row["MinDamage"].ToString());
                    hero.MaxDamage = int.Parse(row["MaxDamage"].ToString());
                    hero.Level = byte.Parse(row["Level"].ToString());
                    hero.Experience = int.Parse(row["Experience"].ToString());
                    hero.Coins = int.Parse(row["Coins"].ToString());
                    heroes.Add(hero);
                }
                conn.Close();
                return heroes;
            }
            catch (Exception)
            {
                throw new ArgumentException("LoadHeroes failed");
            }
        }

        public void CreateHero(Hero hero)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("CreateHero", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@name", hero.Name));
                sqlcmd.Parameters.Add(new SqlParameter("@currenthealth", hero.CurrentHealth));
                sqlcmd.Parameters.Add(new SqlParameter("@maxhealth", hero.MaxHealth));
                sqlcmd.Parameters.Add(new SqlParameter("@mindamage", hero.MinDamage));
                sqlcmd.Parameters.Add(new SqlParameter("@maxdamage", hero.MaxDamage));
                sqlcmd.Parameters.Add(new SqlParameter("@level", hero.Level));
                sqlcmd.Parameters.Add(new SqlParameter("@experience", hero.Experience));
                sqlcmd.Parameters.Add(new SqlParameter("@coins", hero.Coins));
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw new ArgumentException("CreateHero failed");
            }
        }

        public void DeleteHero(Hero hero)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("DeleteHero", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@name", hero.Name));
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw new ArgumentException("DeleteHero failed");
            }
        }

        public void SaveHero(Hero hero)
        {
            SqlCommand sqlcmd = new SqlCommand("SaveHero", conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(new SqlParameter("@name", hero.Name));
            sqlcmd.Parameters.Add(new SqlParameter("@currenthealth", hero.CurrentHealth));
            sqlcmd.Parameters.Add(new SqlParameter("@maxhealth", hero.MaxHealth));
            sqlcmd.Parameters.Add(new SqlParameter("@mindamage", hero.MinDamage));
            sqlcmd.Parameters.Add(new SqlParameter("@maxdamage", hero.MaxDamage));
            sqlcmd.Parameters.Add(new SqlParameter("@level", hero.Level));
            sqlcmd.Parameters.Add(new SqlParameter("@experience", hero.Experience));
            sqlcmd.Parameters.Add(new SqlParameter("@coins", hero.Coins));
            conn.Open();
            sqlcmd.ExecuteNonQuery();
            conn.Close();
        }

        private static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection
                (
                @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\MainDatabase.mdf; Integrated Security=True"
                );
            return conn;
        }
    }
}
