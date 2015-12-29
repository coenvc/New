using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proost
{
    class DbConnection
    {
        public string ExError;
        public string error;
        private MySqlConnection connection;
        public int Bier { get; private set; }
        public int Wijn { get; private set; }
        public int Tequila { get; private set; }
        public int Rum { get; private set; }
        public int Wodka { get; private set; }

        public  string inlogStatus; 
        
        //Naam van de ingelogde gebruiker
        public string naamGebruiker;  
        //Wachwtwoord van de ingelogde gebruiker 
        public string wwGebruiker; 
        //Constructor 
        public DbConnection()
        {

            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            String connectionString = "server=athena01.fhict.local;" +
                    "database=dbi339814;" +
                    "user id=dbi339814;" + // your user id
                    "password=MKU9XLFeju;" +  // your password
                    "connect timeout=30;";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        error = "Cannot connect to server.  Contact administrator";
                        break;

                    case 1045:
                        error = "Invalid username/password, please try again";
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                ExError = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Deze methode voegt een gebruiker toe aan de app  door middel van een simpele query 
        /// </summary>
        /// <param name="gebruikersnaam">tbGebruikersnaam</param>
        /// <param name="wachtwoord">tbWachwtwoord</param>
        /// <param name="barcode">tb Barcode</param>
        public void AddUser(string gebruikersnaam, string wachtwoord, int barcode)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values( ?barcode,  ?wachtwoord , ?gebruikersnaam )";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = barcode;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = wachtwoord;
                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = gebruikersnaam;

                //Execute command
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
            //close connection
            
        } 
        /// <summary>
        /// Dit is het inlogscherm in het inlogform worden de gebruikersnaam en het wachtwoord doorgegeven 
        /// De datareader gaat tellen hoe vaak een gebruiker met het opgegeven wachtwoord voorkomt 
        /// als het voorkomt wordt er 1 bij de counter opgeteld. 
        /// Als de waarde van de counter dus 1 is, bestaan de combinatie van gebruiker en wachtwoord 
        /// </summary>
        /// <param name="gebruikersnaam">tbGebruikersnaam</param>
        /// <param name="wachtwoord">tbWachtwoord</param>
        /// <returns></returns>
        public bool Login(string gebruikersnaam, string wachtwoord)
        {
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM Users where UserNaam = ?username and Wachtwoord = ?password ";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = gebruikersnaam;
                cmd.Parameters.Add("?password", MySqlDbType.VarChar).Value = wachtwoord;

                MySqlDataReader DataReader = cmd.ExecuteReader();

                int count = 0; 
                while (DataReader.Read())
                {
                    count = count + 1;
                    
                }  
                if (count == 1)
                {
                    return true; 
                } 
                if(count != 1)
                {
                    inlogStatus = "De gebruikersnaam en/of wachtwoord zijn onjuist";
                    return false;  
                    
                }
                DataReader.Close();

                this.CloseConnection();
            }
            return false;
        }
        //Select statement
        public List<int>[] Select()
        {
            string query = "SELECT sum(Bier),sum(Wijn),sum(Tequila),sum(Wodka),sum(Rum) FROM bestelling WHERE UserID = 123456";
            //(SELECT UserID FROM users WHERE UserNaam = ? gebruikersnaam AND Wachtwoord = ? wachtwoord)
            //Create a list to store the result
            List<int>[] list = new List<int>[5];
            list[0] = new List<int>();
            list[1] = new List<int>();
            list[2] = new List<int>();
            list[3] = new List<int>();
            list[4] = new List<int>();

         //   Bier = Convert.ToInt32(list[0]);
         //   Wijn = Convert.ToInt32(list[1]);
         //   Tequila = Convert.ToInt32(list[2]);
         //   Wodka = Convert.ToInt32(list[3]);
         //   Rum = Convert.ToInt32(list[4]);
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command 
                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = naamGebruiker;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = wwGebruiker;
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(Convert.ToInt32(dataReader["sum(Bier)"] + "")) ;
                    list[1].Add(Convert.ToInt32(dataReader["sum(Wijn)"] + ""));
                    list[2].Add(Convert.ToInt32(dataReader["sum(Tequila)"] + ""));
                    list[3].Add(Convert.ToInt32(dataReader["sum(Wodka)"] + ""));
                    list[4].Add(Convert.ToInt32(dataReader["sum(Rum)"] + ""));
                }  

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list; 
            }
            else
            {
                return list;
            } 

             
        } 

        //public void BierAchievement()
        //{
        //    if (this.OpenConnection() == true)
        //    {
        //        //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
        //        string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values( ?barcode,  ?wachtwoord , ?gebruikersnaam )";

        //        //create command and assign the query and connection from the constructor

        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //     //   cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = barcode;
        //     //   cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = wachtwoord;
        //        cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = gebruikersnaam;

        //        //Execute command
        //        cmd.ExecuteNonQuery();

        //        this.CloseConnection();
        //    }
        //}
       
    }
}



       


