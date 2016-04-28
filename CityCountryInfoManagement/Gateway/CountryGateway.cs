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
    public class CountryGateway
    {
        static SqlConnection connection = new SqlConnection();
        static string connectionString = WebConfigurationManager.ConnectionStrings["CountryDBConnString"].ConnectionString;

        public int Save(Country country)
        {
            connection.ConnectionString = connectionString;

            string query = "INSERT INTO Country  VALUES(@CountryName,@CountryAbout)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("CountryName", SqlDbType.VarChar);
            command.Parameters["CountryName"].Value = country.Name;
            command.Parameters.Add("CountryAbout", SqlDbType.VarChar);
            command.Parameters["CountryAbout"].Value = country.About;

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }
        public bool IsCountryExists(Country country)
        {
            connection.ConnectionString = connectionString;
            string query = "SELECT * FROM Country WHERE (CountryName =  @Name)";


           

            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            command.Parameters.Add("Name", SqlDbType.VarChar);
            command.Parameters["Name"].Value =country.Name;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            bool isCountryExist = false;

            if (reader.HasRows)
            {
                isCountryExist = true;
            }
            connection.Close();

            return isCountryExist;
        }



        public List<Country> LoadAllCountry()
        {

            string query = "SELECT * FROM Country ORDER BY CountryName ";

            connection.ConnectionString = connectionString;
            List<Country> countrylist = new List<Country>();

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Country country = null;


            while (reader.Read())
            {
                country = new Country();
                country.Id = (int)reader["Id"];
                country.Name = reader["CountryName"].ToString();
                country.About = reader["CountryAbout"].ToString();


                countrylist.Add(country);

            }
            reader.Close();
            connection.Close();

            return countrylist;
        }

        public List<CountryView> GetByCountryName(string countrySearchName)
        {
            connection.ConnectionString = connectionString;
            string query = "SELECT * FROM CountryView WHERE (CountryName LIKE '%'+@countrySearchName+'%')";
            //(CityName LIKE '%'+@citySearchName+'%')";
            

            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.Add("citySearchName", SqlDbType.VarChar);
            //command.Parameters["citySearchName"].Value = citySearchName;
            command.Parameters.Add("countrySearchName", SqlDbType.VarChar);
            command.Parameters["countrySearchName"].Value = countrySearchName;

            List<CountryView> countryList = new List<CountryView>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            CountryView countryView = null;
            while (reader.Read())
            {
                countryView = new CountryView();
                //countryView.Id = (int) reader["id"];
                countryView.Name = reader["CountryName"].ToString();
                countryView.About = reader["CountryAbout"].ToString();
                countryView.NoOfCities = Convert.ToInt32(reader["NoOfCities"].ToString());
                if (!reader["NoOfDwellers"].Equals(System.DBNull.Value))
                {
                    countryView.NoOfDwellers = reader.GetInt64(reader.GetOrdinal("NoOfDwellers"));
                }
                else
                {
                    countryView.NoOfDwellers = 0;
                }

                //aBook.Id = (int)reader["id"];
                //aBook.Isbn = reader["Isbn"].ToString();
                //aBook.CountryName = reader["CountryName"].ToString();
                //aBook.Author = reader["Author"].ToString();

                countryList.Add(countryView);
            }
            reader.Close();
            connection.Close();

            return countryList;
        }

        public static List<CountryView> GetAllCountry()
        {
            connection.ConnectionString = connectionString;
            string query = "SELECT * FROM CountryView ";
            //(CityName LIKE '%'+@citySearchName+'%')";


            SqlCommand command = new SqlCommand(query, connection);
            

            List<CountryView> countryList = new List<CountryView>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            CountryView countryView = null;
            while (reader.Read())
            {
                countryView = new CountryView();
                //countryView.Id = (int) reader["id"];
                countryView.Name = reader["CountryName"].ToString();
                countryView.About = reader["CountryAbout"].ToString();
                countryView.NoOfCities = Convert.ToInt32(reader["NoOfCities"].ToString());
                if (!reader["NoOfDwellers"].Equals(System.DBNull.Value))
                {
                    countryView.NoOfDwellers = reader.GetInt64(reader.GetOrdinal("NoOfDwellers"));
                }
                else
                {
                    countryView.NoOfDwellers = 0;
                }

                

                countryList.Add(countryView);
            }
            reader.Close();
            connection.Close();

            return countryList;
        }
    }
}