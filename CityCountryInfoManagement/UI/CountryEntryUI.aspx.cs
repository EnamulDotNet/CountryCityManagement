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
    public partial class CountryEntryUI : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAllCountry();
            }
                
          
            
            

        }

  

        protected void countryEntrySaveButton_Click(object sender, EventArgs e)
        {
            
            Country country = new Country();
            country.Name = countryEntryNameTextBox.Text;
            country.About = Request.Form["countryEntryAbout"];
            
            Label1.Text = countryManager.save(country);
            LoadAllCountry();

        }

        public void LoadAllCountry()
        {
            countryEntryGridView.DataSource = countryManager.LoadAllCountry();
            countryEntryGridView.DataBind();
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            countryEntryGridView.PageIndex = e.NewPageIndex;
            LoadAllCountry();
        }

        protected void cancelbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main Menu.aspx");
        }
    }
}