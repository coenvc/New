using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kassa
{
    public class Database
    {
        private MySqlConnection connection;
        public string inlogStatus;
        public string error;
        public string ExError;
        public string ingelogdeGebruikerww;
        public string ingelogdeGebruikerNaam;
        public int AantalWijnVerkocht { get; private set; }
        public int AantalBierVerkocht;
        public int AantalWodkaVerkocht { get; private set; }
        public int AantalRumVerkocht { get; private set; }
        public int AantalTequilaVerkocht { get; private set; }
        public string datum1;
        public string datum2; 


        //Constructor
        public Database()
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
               if (connection.State == System.Data.ConnectionState.Closed)
               {
                    connection.Open();
               }
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //?aantal45: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        error = "Cannot connect to server.  Contact administrator";
                        break;

                    case 1:
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
       

        public void AddBier(int bier, int barcode)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "INSERT INTO bestelling (UserID, Bier, CafeID) values(?barcode,?aantal , (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord))";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = barcode;
                cmd.Parameters.Add("?aantal", MySqlDbType.Int32).Value = bier;
                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                //cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = gebruikersnaam;

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void AddWijn(int wijn, int barcode)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "INSERT INTO bestelling (UserID, Wijn, CafeID) values(?barcode, ?aantal, (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord))";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = barcode;
                cmd.Parameters.Add("?aantal", MySqlDbType.Int32).Value = wijn;
                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                //cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = gebruikersnaam;

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public int GetBier()
        {
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "SELECT sum(Bier) FROM bestelling WHERE CafeId = (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord) ";

                //create command and assign the query and connection from the constructor
                
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                cmd.Parameters.Add("?datum1", MySqlDbType.Timestamp).Value = datum1;
                cmd.Parameters.Add("?datum2", MySqlDbType.Timestamp).Value = datum2;  
                MySqlDataReader DataReader = cmd.ExecuteReader();  
                while (DataReader.Read())
                {
                    AantalBierVerkocht = (Convert.ToInt32(DataReader["sum(Bier)"]));
                }
                DataReader.Close();
                //Execute command
                cmd.ExecuteNonQuery();

               

                //close connection
                this.CloseConnection();
            }

            return AantalBierVerkocht; 
        }
        public int GetWijn()
        {
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "SELECT sum(Wijn) FROM bestelling WHERE CafeId = (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord) AND Datum BETWEEN ?datum1 and ?datum2";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                cmd.Parameters.Add("?datum1", MySqlDbType.Timestamp).Value = datum1;
                cmd.Parameters.Add("?datum2", MySqlDbType.Timestamp).Value = datum2;
                MySqlDataReader DataReader = cmd.ExecuteReader();
                while (DataReader.Read())
                {
                    AantalWijnVerkocht = (Convert.ToInt32(DataReader["sum(Wijn)"]));
                }
                DataReader.Close();
                //Execute command
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }

            return AantalWijnVerkocht;
        }
        public int GetWodka()
        {
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "SELECT sum(Wodka) FROM bestelling WHERE CafeId = (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord) AND Datum BETWEEN ?datum1 and ?datum2";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                cmd.Parameters.Add("?datum1", MySqlDbType.Timestamp).Value = datum1;
                cmd.Parameters.Add("?datum2", MySqlDbType.Timestamp).Value = datum2;
                MySqlDataReader DataReader = cmd.ExecuteReader();
                while (DataReader.Read())
                {
                    AantalWodkaVerkocht = (Convert.ToInt32(DataReader["sum(Wodka)"]));
                }
                DataReader.Close();
                //Execute command
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }

            return AantalWodkaVerkocht;
        }
        public int GetRum()
        {
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "SELECT sum(Rum) FROM bestelling WHERE CafeId = (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord) AND Datum BETWEEN ?datum1 and ?datum2";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                cmd.Parameters.Add("?datum1", MySqlDbType.Timestamp).Value = datum1;
                cmd.Parameters.Add("?datum2", MySqlDbType.Timestamp).Value = datum2;
                MySqlDataReader DataReader = cmd.ExecuteReader();
                while (DataReader.Read())
                {
                    AantalRumVerkocht = (Convert.ToInt32(DataReader["sum(Rum)"]));
                }
                DataReader.Close();
                //Execute command
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }

            return AantalRumVerkocht;
        }
        public int GetTequila()
        {
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "SELECT sum(Tequila) FROM bestelling WHERE CafeId = (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord) AND Datum BETWEEN ?datum1 and ?datum2";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                cmd.Parameters.Add("?datum1", MySqlDbType.Timestamp).Value = datum1;
                cmd.Parameters.Add("?datum2", MySqlDbType.Timestamp).Value = datum2;


                MySqlDataReader DataReader = cmd.ExecuteReader();
                while (DataReader.Read())
                {
                    AantalTequilaVerkocht = (Convert.ToInt32(DataReader["sum(Tequila)"]));
                }
                DataReader.Close();
                //Execute command
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }

            return AantalTequilaVerkocht;
        }


        public void AddWodka(int wodka, int barcode)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "INSERT INTO bestelling (UserID, Wodka, CafeID) values(?barcode, ?aantal, (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord))";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = barcode;
                cmd.Parameters.Add("?aantal", MySqlDbType.Int32).Value = wodka;
                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                //cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = gebruikersnaam;

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void AddRum(int rum, int barcode)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "INSERT INTO bestelling (UserID, Rum, CafeID) values(?barcode, ?aantal, (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord))";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = barcode;
                cmd.Parameters.Add("?aantal", MySqlDbType.Int32).Value = rum;
                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                //cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = gebruikersnaam;

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void AddTequila(int tequila, int barcode)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "INSERT INTO bestelling (UserID, Tequila, CafeID) values(?barcode, ?aantal, (SELECT CafeID FROM cafes WHERE CafeNaam = ?gebruikersnaam and CafeWachtwoord = ?wachtwoord))";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = barcode;
                cmd.Parameters.Add("?aantal", MySqlDbType.Int32).Value = tequila;
                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                //cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = gebruikersnaam;

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public bool Login(string gebruikersnaam, string wachtwoord)
        {
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM cafes where CafeNaam = ?username and CafeWachtwoord = ?password ";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = gebruikersnaam;
                cmd.Parameters.Add("?password", MySqlDbType.VarChar).Value = wachtwoord;
                ingelogdeGebruikerNaam = gebruikersnaam;
                ingelogdeGebruikerww = wachtwoord;
                MySqlDataReader DataReader = cmd.ExecuteReader();

                int count = 0;
                while (DataReader.Read())
                {
                    count = count + 1;
                    

                }
                DataReader.Close(); 

                if (count == 1)
                {
                    return true;

                }
                if (count != 1)
                {
                    inlogStatus = "De gebruikersnaam en/of wachtwoord zijn onjuist";
                    return false;

                }
                

                this.CloseConnection();
            }
            return false;
        }
      


        } 
       
    }