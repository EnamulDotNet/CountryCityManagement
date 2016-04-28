<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityViewUI.aspx.cs" Inherits="CityCountryInfoManagement.UI.CityViewUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../CSS/style.css" rel="stylesheet" />
    <title>City View</title>
</head>
<body>
       <form id="form1" runat="server">
    <div style="height: 311px">
        <fieldset>
            <legend>
                View Cities
            </legend>
            <fieldset class="fieldsetstyle2">
                <legend>Search Criteria</legend>
                <table>
                    <tr>
                        <td>
                            <asp:RadioButton ID="cityRadioButton" CssClass="whitetext"  runat="server" GroupName="search" Checked="True" Text="City" />
                            <br />
                            <br />
                            <asp:RadioButton ID="countryRadioButton" CssClass="whitetext" runat="server" GroupName="search" Text="Country" />
                        </td><td class="auto-style1">
                            <asp:TextBox ID="cityNameTextBox" CssClass="textboxstyle" runat="server" Height="22px"></asp:TextBox>
                            <br />
                            <asp:DropDownList ID="countryDropDownList" CssClass="textboxstyle" runat="server">
                            </asp:DropDownList>
                            <asp:Label ID="messageLabel" runat="server"></asp:Label>
                        </td>
                        <td> 
                            <br />
                            <br />
    <%-- <asp:Button ID="searchCityButton" runat="server" Text="Search" OnClick="searchCityButton" style="height: 26px" />--%>
   <asp:LinkButton ID="searchCityButton" runat="server" OnClick="searchCityButton_Click" ><i class="fa fa-search button-form form-button-color2"> Search</i>
</asp:LinkButton>

                        </td>
                    </tr>
                </table>
                
            </fieldset>
            <asp:GridView ID="cityGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="OnPageIndexChanging" CellPadding="3" PageSize="4" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" CssClass="gridviewstyle3">
                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CityName")%>'></asp:Label>
                    </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="About">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CityAbout")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="No Of Dwellers">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("NoOfDwellers")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Location">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Location")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Weather">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("Weather")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Country">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CountryName")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="About Country">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CountryAbout")%>'></asp:Label>
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

        </fieldset>
    
    </div>
    </form>
</body>
</html>
