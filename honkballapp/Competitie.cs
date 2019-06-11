using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///voor de connectie
using System.Data.SqlClient;
using System.Windows.Forms;


namespace honkballapp
{
    public class Competitie
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Honkbalcompetitie.mdf;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(connectionString);
        public string Naam { get; private set; }
        public int Jaar { get; private set; }
        public string Klasse { get; private set; }

        public List<Team> teams { get; private set; }

        public Competitie(string naam, int jaar, string klasse)
        {
            this.Naam = naam;
            this.Jaar = jaar;
            this.Klasse = klasse;
            teams = new List<Team>();
            Laadteams();
        }
        public void Laadteams()
        {
            teams.Clear();
            conn.Open(); 
            string Query = "select * from Teams";
            SqlCommand cmd = new SqlCommand(Query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //id titel file location file size date lastplayed
                    int TeamID = reader.GetInt32(0);
                    string naamTeam = reader.GetString(1);                
                    Team team = new Team(TeamID,naamTeam);
                    teams.Add(team);         
                }
            }
            conn.Close();
        }


    }
}
