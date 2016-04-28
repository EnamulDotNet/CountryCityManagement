using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CityCountryInfoManagement.Models;

namespace CityCountryInfoManagement.Gateway
{
    public class CityGateway
    {
        SqlConnection connection = new SqlConnection();
        string connectionString = WebConfigurationManager.ConnectionStrings["CountryDBConnString"].ConnectionString;
        public  int Save(City city)
        {
            connection.ConnectionString = connectionString;
            string query = "INSERT INTO City VALUES(@CityName,@CityAbout,@Dwellers,@Location,@Weather,@CountryId)";
            SqlCommand Command = new SqlCommand(query,connection);
            Command.Parameters.Clear();
            Command.Parameters.Add("CityName", SqlDbType.VarChar);
            Command.Parameters["CityName"].Value = city.Name;
            Command.Parameters.Add("CityAbout", SqlDbType.VarChar);
            Command.Parameters["CityAbout"].Value = city.About;
            Command.Parameters.Add("Dwellers", SqlDbType.BigInt);
            Command.Parameters["Dwellers"].Value = city.Dwellers;
            Command.Parameters.Add("Location", SqlDbType.VarChar);
            Command.Parameters["Location"].Value = city.Location;
            Command.Parameters.Add("Weather", SqlDbType.VarChar);
            Command.Parameters["Weather"].Value = city.Weather;
            Command.Parameters.Add("CountryId", SqlDbType.Int);
            Command.Parameters["CountryId"].Value = city.CountryId;
            connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public  bool IsCityExists(City city)
        {
            string query = "SELECT * FROM City WHERE (CityName = @Name)" ;


            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            command.Parameters.Add("Name", SqlDbType.VarChar);
            command.Parameters["Name"].Value = city.Name;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            bool isCityExist = false;

            if (reader.HasRows)
            {
                isCityExist = true;
            }
            connection.Close();

            return isCityExist;
        }

        public List<City> LoadAllCities()
        {
            string query = "SELECT * FROM City ORDER BY CityName";

            connection.ConnectionString = connectionString;
            List<City> citylist = new List<City>();

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
           City city = null;


            while (reader.Read())
            {
                city = new City();
                city.Id = (int)reader["Id"];
                city.Name = reader["CityName"].ToString();
                
                city.About = reader["CityAbout"].ToString();
                city.Dwellers = Convert.ToInt64(reader["Dwellers"]);
                city.Location = reader["Location"].ToString();
                city.Weather = reader["Weather"].ToString();
                city.CountryId = reader["CountryId"].ToString();

                citylist.Add(city);

            }
            reader.Close();
            connection.Close();

            return citylist;
        }

        public List<CityView> GetCityByCityName(string citySearchName)
        {
            connection.ConnectionString = connectionString;
            string query = "SELECT * FROM CityView WHERE (CityName LIKE '%'+@citySearchName+'%')";


            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.Add("citySearchName", SqlDbType.VarChar);
            command.Parameters["citySearchName"].Value = citySearchName;
            List<CityView> cityList = new List<CityView>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            CityView cityView = null;
            while (reader.Read())
            {
                cityView = new CityView();
                cityView.CityName = reader["CityName"].ToString();
                cityView.CityAbout = reader["CityAbout"].ToString();
                if (!reader["NoOfDwellers"].Equals(System.DBNull.Value))
                {
                    cityView.NoOfDwellers = reader.GetInt64(reader.GetOrdinal("NoOfDwellers"));
                }
                else
                {
                    cityView.NoOfDwellers = 0;
                }
                cityView.Location = reader["Location"].ToString();
                cityView.Weather = reader["Weather"].ToString();
                cityView.CountryName = reader["CountryName"].ToString();
                cityView.CountryAbout = reader["CountryAbout"].ToString();
                cityList.Add(cityView);

            }
            reader.Close();
            connection.Close();
            return cityList;
        }

        public List<Country> GetAllCountry()
        {
            connection.ConnectionString = connectionString;
            string query = "SELECT * FROM Country";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Country> countryList = new List<Country>();
            while (reader.Read())
            {
                Country country = new Country();

                country.Name = reader["CountryName"].ToString();
                country.Id = Int32.Parse(reader["Id"].ToString());
                countryList.Add(country);

            }
            reader.Close();
            connection.Close();
            return countryList;
        }

        public List<CityView> GetAllCity()
        {
            connection.ConnectionString = connectionString;
            string query = "SELECT * FROM CityView";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<CityView> cityList = new List<CityView>();
            while (reader.Read())
            {
                CityView cityView = new CityView();
                cityView.CityName = reader["CityName"].ToString();
                cityView.CityAbout = reader["CityAbout"].ToString();
                if (!reader["NoOfDwellers"].Equals(System.DBNull.Value))
                {
                    cityView.NoOfDwellers = reader.GetInt64(reader.GetOrdinal("NoOfDwellers"));
                }
                else
                {
                    cityView.NoOfDwellers = 0;
                }

                cityView.Location = reader["Location"].ToString();
                cityView.Weather = reader["Weather"].ToString();
                cityView.CountryName = reader["CountryName"].ToString();
                cityView.CountryAbout = reader["CountryAbout"].ToString();
                cityList.Add(cityView);

            }
            reader.Close();
            connection.Close();
            return cityList;
        }

        public List<CityView> GetCityByCountryName(string countrySearchName)
        {
            connection.ConnectionString = connectionString;
            string query = "SELECT * FROM CityView WHERE (CountryName LIKE '%'+@countrySearchName+'%')";


            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.Add("countrySearchName", SqlDbType.VarChar);
            command.Parameters["countrySearchName"].Value = countrySearchName;
            
            List<CityView> cityList = new List<CityView>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            CityView cityView = null;
            while (reader.Read())
            {
                cityView = new CityView();
                cityView.CityName = reader["CityName"].ToString();
                cityView.CityAbout = reader["CityAbout"].ToString();
                if (!reader["NoOfDwellers"].Equals(System.DBNull.Value))
                {
                    cityView.NoOfDwellers = reader.GetInt64(reader.GetOrdinal("NoOfDwellers"));
                }
                else
                {
                    cityView.NoOfDwellers = 0;
                }


                cityView.Location = reader["Location"].ToString();
                cityView.Weather = reader["Weather"].ToString();
                cityView.CountryName = reader["CountryName"].ToString();
                cityView.CountryAbout = reader["CountryAbout"].ToString();
                cityList.Add(cityView);

            }
            reader.Close();
            connection.Close();
            return cityList;
        }
    }
}