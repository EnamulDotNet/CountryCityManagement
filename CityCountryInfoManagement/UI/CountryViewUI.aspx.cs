using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityCountryInfoManagement.BLL;

namespace CityCountryInfoManagement.UI
{
    public partial class CountryViewUI : System.Web.UI.Page
    {
        CountryManager countryManager=new CountryManager();
        private string searchName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //countryManager.LoadAllCountry();
                GetCountry();
            }
            
        }
        private void GetCountry()
        {
            countryViewGridView.DataSource = countryManager.GetAllCountry();
           countryViewGridView.DataBind();
        }

       
        protected void countryViewSearchButton_Click(object sender, EventArgs e)
        {
             string searchname = countryViewSearchTextBox.Text;

            if (searchname.Length > 0)
            {
                if (countryManager.GetByCountryName(searchname).Count == 0)
                {
                    countryViewGridView.DataSource = null;
                    countryViewGridView.DataBind();
                    countryViewMeassageLabel.Text = "*This is not availabel";
                   
                }
                else
                {
                    countryViewMeassageLabel.Text = "";
                    ShowCountry(searchname);
                }

                }
            else
                {
                    countryViewGridView.DataSource = null;
                    countryViewGridView.DataBind();
                    countryViewMeassageLabel.Text = "Please input a name";
                }
            


        }

        private void ShowCountry(string countrySearchName)
        {
            countryViewGridView.DataSource = countryManager.GetByCountryName(countrySearchName);
            countryViewGridView.DataBind();
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            countryViewGridView.PageIndex = e.NewPageIndex;
            
            countryManager.LoadAllCountry();
        }
    }
       
    
}