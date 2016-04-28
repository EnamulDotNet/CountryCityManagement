using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityCountryInfoManagement.BLL;
using CityCountryInfoManagement.Models;

namespace CityCountryInfoManagement.UI
{
    public partial class CityViewUI : System.Web.UI.Page
    {
        CityManager cityManager=new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountry();
                GetCity();

            }
        }

        private void GetCity()
        {
            cityGridView.DataSource = cityManager.GetAllCity();
            cityGridView.DataBind();
        }

        private void LoadCountry()
        {
            List<Country> country = cityManager.GetAllCountry();
            // set the department list as a data source to dropdownlist
            Country deafultCountry = new Country();

            deafultCountry.Id = -1;
            deafultCountry.Name = "Select...";

            country.Insert(0, deafultCountry);

            countryDropDownList.DataSource = country;
            countryDropDownList.DataTextField = "Name";
            countryDropDownList.DataValueField = "Name";
            // databind
            countryDropDownList.DataBind();

        }

        protected void searchCityButton_Click(object sender, EventArgs e)
        {
            string selectedValue = countryDropDownList.SelectedValue;


            //  string countrySearchName = TextBox1.Text;






            if (cityRadioButton.Checked == true)
            {
                if (cityNameTextBox.Text == string.Empty)
                {
                    messageLabel.Text = "Please write ....";
                }
                else
                {
                    string citySearchName = cityNameTextBox.Text;
                    if (cityManager.GetCityByCityName(citySearchName).Count == 0)
                    {
                        messageLabel.Text = "data not match";
                        cityGridView.DataSource = null;
                        cityGridView.DataBind();
                    }
                    else
                    {
                        messageLabel.Text = "";
                        cityGridView.DataSource = cityManager.GetCityByCityName(citySearchName);
                        cityGridView.DataBind();
                    }

                }
            }
            else if (countryRadioButton.Checked == true)
            {

                cityGridView.DataSource = cityManager.GetCityByCountryName(selectedValue);
                cityGridView.DataBind();
            }
           
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cityGridView.PageIndex = e.NewPageIndex;
            GetCity();
        }
    }
}