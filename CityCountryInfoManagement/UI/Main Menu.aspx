<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main Menu.aspx.cs" Inherits="CityCountryInfoManagement.UI.Main_Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="../Content/font-awesome.min.css" rel="stylesheet" />
    <link href="../CSS/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper">
    <h1 class="headertext">Country City Management Systems</h1>
      
        
       <div class="buttonwrapper">
           <asp:LinkButton ID="cityEntryButton" runat="server" OnClick="cityEntryButton_Click" ><i class="fa fa-car button1 color1"> City</i>
</asp:LinkButton>
       
   
        <asp:LinkButton ID="countryEntryButton" runat="server" OnClick="countryEntryButton_Click" ><i class="fa fa-flag-o button1 color2"> Country</i>
</asp:LinkButton>
        
     
        <asp:LinkButton ID="cityviewButton" runat="server" OnClick="cityviewButton_Click" ><i class="fa fa-binoculars button1 color3"> City View</i>
</asp:LinkButton>
     
    <asp:LinkButton ID="countryviewButton" runat="server" OnClick="countryviewButton_Click" ><i class="fa fa-search button1 color4"> Country View</i>
</asp:LinkButton>

       </div>
         
    </div>
    </form>
</body>
</html>
