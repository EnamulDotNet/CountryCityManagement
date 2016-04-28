<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryViewUI.aspx.cs" Inherits="CityCountryInfoManagement.UI.CountryViewUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../CSS/style.css" rel="stylesheet" />
    <title>Country View</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 131px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <fieldset class="fieldsetstyle2"><legend>Search criteria</legend>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2 whitetext">&nbsp;&nbsp;&nbsp; &nbsp;Name</td>
                <td>
                    <asp:TextBox ID="countryViewSearchTextBox" CssClass="textboxstyle" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <%--<asp:Button ID="countryViewSearchButton"  runat="server" Text="Search" OnClick="countryViewSearchButton_Click" />--%>
                    <asp:LinkButton ID="countryViewSearchButton" runat="server" OnClick="countryViewSearchButton_Click" ><i class="fa fa-search button-form form-button-color2"> Search</i>
</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="countryViewMeassageLabel" runat="server"></asp:Label>
                </td>
            </tr>
        </table>

    </fieldset>
        <asp:GridView ID="countryViewGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="OnPageIndexChanging" CellPadding="3" PageSize="4" CssClass="gridviewstyle4" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
            <Columns>
                  <asp:TemplateField HeaderText="SL#">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Name")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="About">
                    <ItemTemplate>
                        <asp:HiddenField runat="server" ID="idHiddenField" Value='<%#Eval("Id")%>'/>
                        <asp:Label runat="server" Text='<%#Eval("About")%>'></asp:Label>
                    </ItemTemplate>
                     </asp:TemplateField>
                    <asp:TemplateField HeaderText="No of Cities">
                    <ItemTemplate>
                       
                        <asp:Label runat="server" Text='<%#Eval("NoOfCities")%>'></asp:Label>
                    </ItemTemplate>
                     </asp:TemplateField>
                    <asp:TemplateField HeaderText="No of City Dwellers">
                    <ItemTemplate>
                       
                        <asp:Label runat="server" Text='<%#Eval("NoOfDwellers")%>'></asp:Label>
                    </ItemTemplate>
                     </asp:TemplateField>
                </Columns>
                     <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                     <HeaderStyle BackColor="#f79365" Font-Bold="True" ForeColor="White" />
                     <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                     <RowStyle BackColor="#FFF7E7" ForeColor="#F7783E" CssClass="rowfont" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
   
    </form>
</body>
</html>
