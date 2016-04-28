using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CityCountryInfoManagement.UI
{
    public partial class Main_Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cityEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CityEntryUI.aspx");
        }

        protected void countryEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CountryEntryUI.aspx");
        }

        protected void countryviewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CountryViewUI.aspx");
        }

        protected void cityviewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CityViewUI.aspx");
        }
    }
}