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
        public int B5 { get; private set; }
        public int B10 { get; private set; }
        public int B25 { get; private set; }
        public int B50 { get; private set; }
        public int W5 { get; private set; }
        public int W10 { get; private set; }
        public int W25 { get; private set; }
        public int W50 { get; private set; }
        public int T5 { get; private set; }
        public int T10 { get; private set; }
        public int T25 { get; private set; }
        public int T50 { get; private set; }
        public int R5 { get; private set; }
        public int R10 { get; private set; }
        public int R25 { get; private set; }
        public int R50 { get; private set; }
        public int WO5 { get; private set; }
        public int WO10 { get; private set; }
        public int WO25 { get; private set; }
        public int WO50 { get; private set; }
        public int AantalRumVerkocht { get; private set; }
        public int AantalTequilaVerkocht { get; private set; }
        public string datum1;
        public string datum2;
        public int AantalBier;
        public int Barcode;
        public int Bier;
        public int Wijn;
        public int Wodka;
        public int Rum;
        public int Tequila;

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
        public void Achievement()
        {
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "SELECT B5, B10, B25, B50, W5,W10,W25,W50,WO5,WO10,WO25,WO50,T5,T10,T25,T50,R5,R10,R25,R50  FROM users WHERE UserID = 567  ";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add("?gebruikersnaam", MySqlDbType.VarChar).Value = ingelogdeGebruikerNaam;
                cmd.Parameters.Add("?wachtwoord", MySqlDbType.VarChar).Value = ingelogdeGebruikerww;
                cmd.Parameters.Add("?datum1", MySqlDbType.Timestamp).Value = datum1;
                cmd.Parameters.Add("?datum2", MySqlDbType.Timestamp).Value = datum2;
                MySqlDataReader DataReader = cmd.ExecuteReader();
                while (DataReader.Read())
                {
                    B5 = (Convert.ToInt32(DataReader["B5"]));
                    B10 = (Convert.ToInt32(DataReader["B10"]));
                    B25 = (Convert.ToInt32(DataReader["B25"]));
                    B50 = (Convert.ToInt32(DataReader["B50"]));
                    W5 = (Convert.ToInt32(DataReader["W5"]));
                    W10 = (Convert.ToInt32(DataReader["W10"]));
                    W25 = (Convert.ToInt32(DataReader["W25"]));
                    W50 = (Convert.ToInt32(DataReader["W50"]));
                    WO5 = (Convert.ToInt32(DataReader["WO5"]));
                    WO10 = (Convert.ToInt32(DataReader["WO10"]));
                    WO25 = (Convert.ToInt32(DataReader["WO25"]));
                    WO50 = (Convert.ToInt32(DataReader["WO50"]));
                    T5 = (Convert.ToInt32(DataReader["T5"]));
                    T10 = (Convert.ToInt32(DataReader["T10"]));
                    T25 = (Convert.ToInt32(DataReader["T25"]));
                    T50 = (Convert.ToInt32(DataReader["T50"]));
                    R5 = (Convert.ToInt32(DataReader["R5"]));
                    R10 = (Convert.ToInt32(DataReader["R10"]));
                    R25 = (Convert.ToInt32(DataReader["R25"]));
                    R50 = (Convert.ToInt32(DataReader["R50"]));




                }
                DataReader.Close();
            }
            if (this.OpenConnection() == true)
            {
                //string query = "INSERT INTO users (UserID, Wachtwoord, UserNaam) values('"+barcode+"', '"+wachtwoord+"' , '"+gebruikersnaam+"')"; 
                string query = "SELECT sum(Bier),sum(Wijn),sum(Tequila),sum(Wodka),sum(Rum) FROM bestelling WHERE UserID = ?barcode ";

                //create command and assign the query and connection from the constructor

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = Barcode;
                MySqlDataReader DataReader = cmd.ExecuteReader();
                while (DataReader.Read())
                {
                    Bier = (Convert.ToInt32(DataReader["sum(Bier)"]));
                    Wijn = (Convert.ToInt32(DataReader["sum(Wijn)"]));
                    Wodka = (Convert.ToInt32(DataReader["sum(Wodka)"]));
                    Tequila = (Convert.ToInt32(DataReader["sum(Tequila)"]));
                    Rum = (Convert.ToInt32(DataReader["sum(Rum)"]));

                }
                DataReader.Close();
            }
        }

        public void ControleerAchievementBier()
        {

            //close connection
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM users";
                if (B5 == 0 && Bier >= 5)
                {
                    query = "UPDATE `dbi339814`.`users` SET `B5` = '1' WHERE `users`.`UserID` = ?barcode;";
                            
                }
                if (B10 == 0 && Bier >= 10)
                {
                    query = "UPDATE `dbi339814`.`users` SET `B5` = '1' , `B10` = '1' WHERE `users`.`UserID` = ?barcode;";
                    
                }
                if (B25 == 0 && Bier >= 25)
                {
                    query = "UPDATE `dbi339814`.`users` SET `B5` = '1' , `B10` = '1', `B25` = '1' WHERE `users`.`UserID` = ?barcode;";
                    
                }
                if (B50 == 0 && Bier >= 50)
                {
                    query = "UPDATE `dbi339814`.`users` SET `B5` = '1' , `B10` = '1', `B25` = '1', `B50` = '1' WHERE `users`.`UserID` = ?barcode;";
                   
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = Barcode;
                cmd.ExecuteNonQuery();

            }
        }
        public void ControleerAchievementWijn()
        {

            //close connection
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM users";
                if (B5 == 0 && Wijn >= 5)
                {
                    query = "UPDATE `dbi339814`.`users` SET `W5` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B10 == 0 && Wijn >= 10)
                {
                    query = "UPDATE `dbi339814`.`users` SET `W5` = '1' , `W10` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B25 == 0 && Wijn >= 25)
                {
                    query = "UPDATE `dbi339814`.`users` SET `W5` = '1' , `W10` = '1', `W25` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B50 == 0 && Wijn >= 50)
                {
                    query = "UPDATE `dbi339814`.`users` SET `W5` = '1' , `W10` = '1', `W25` = '1', `W50` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = Barcode;
                cmd.ExecuteNonQuery();


            }
        }
            public void ControleerAchievementWodka()
        {

            //close connection
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM users";
                if (B5 == 0 && Wijn >= 5)
                {
                    query = "UPDATE `dbi339814`.`users` SET `WO5` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B10 == 0 && Wijn >= 10)
                {
                    query = "UPDATE `dbi339814`.`users` SET `WO5` = '1' , `WO10` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B25 == 0 && Wijn >= 25)
                {
                    query = "UPDATE `dbi339814`.`users` SET `WO5` = '1' , `WO10` = '1', `WO25` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B50 == 0 && Wijn >= 50)
                {
                    query = "UPDATE `dbi339814`.`users` SET `WO5` = '1' , `WO10` = '1', `WO25` = '1', `WO50` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = Barcode;
                cmd.ExecuteNonQuery();


            }
        }
        public void ControleerAchievementRum()
        {

            //close connection
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM users";
                if (B5 == 0 && Wijn >= 5)
                {
                    query = "UPDATE `dbi339814`.`users` SET `R5` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B10 == 0 && Wijn >= 10)
                {
                    query = "UPDATE `dbi339814`.`users` SET `R5` = '1' , `R10` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B25 == 0 && Wijn >= 25)
                {
                    query = "UPDATE `dbi339814`.`users` SET `R5` = '1' , `R10` = '1', `R25` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B50 == 0 && Wijn >= 50)
                {
                    query = "UPDATE `dbi339814`.`users` SET `R5` = '1' , `R10` = '1', `R25` = '1', `R50` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = Barcode;
                cmd.ExecuteNonQuery();

            }
        }
        public void ControleerAchievementTequila()
        {

            //close connection
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM users";
                if (B5 == 0 && Wijn >= 5)
                {
                    query = "UPDATE `dbi339814`.`users` SET `T5` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B10 == 0 && Wijn >= 10)
                {
                    query = "UPDATE `dbi339814`.`users` SET `T5` = '1' , `T10` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B25 == 0 && Wijn >= 25)
                {
                    query = "UPDATE `dbi339814`.`users` SET `T5` = '1' , `T10` = '1', `T25` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                if (B50 == 0 && Wijn >= 50)
                {
                    query = "UPDATE `dbi339814`.`users` SET `T5` = '1' , `T10` = '1', `T25` = '1', `T50` = '1' WHERE `users`.`UserID` = ?barcode;";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?barcode", MySqlDbType.Int32).Value = Barcode;
                cmd.ExecuteNonQuery();


            }
        }
    }
    } 
     