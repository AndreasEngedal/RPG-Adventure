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
        SqlConnection sqlCon = GetSqlConnection();

        public void CreateHero(Hero hero)
        {
            try
            {
                sqlCon.Open();
                SqlCommand sqlcmd = new SqlCommand("CreateHero", sqlCon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(new SqlParameter("@name", hero.Name));
                sqlcmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection
                (
                @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Andreas\Documents\Visual Studio 2015\Projects\@RPG-Adventure\RPG Adventure\MainDatabase.mdf;Integrated Security=True"
                );
            return conn;
        }
    }
}
