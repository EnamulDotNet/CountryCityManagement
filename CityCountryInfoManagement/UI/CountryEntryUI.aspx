<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntryUI.aspx.cs" Inherits="CityCountryInfoManagement.UI.CountryEntryUI" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_editor.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_style.css" rel="stylesheet" />
    <link href="../CSS/style.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 99%;
            height: 192px;
        }
        .auto-style2 {
            width: 763px;
        }
    </style>

</head>
<body>
    
    <form id="form1" runat="server">
    <fieldset class="fieldsetstyle3"><legend>Country Entry</legend>
     <table class="auto-style1">
        <tr>
            <td>
             <span class="whitetext">Name</span></td>
            <td class="auto-style2">
                <asp:TextBox ID="countryEntryNameTextBox" CssClass="textboxstyle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span class="whitetext">About</span></td>
            <td class="auto-style2"><textarea id="countryEntryAbout" CssClass="textboxstyle" runat="server"></textarea></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                <%--<asp:Button ID="countryEntrySaveButton" runat="server" Text="Save" OnClick="countryEntrySaveButton_Click" />--%>
                <asp:LinkButton ID="countryEntrySaveButton" runat="server" OnClick="countryEntrySaveButton_Click" ><i class="fa fa-floppy-o button-form form-button-color1"> Save</i>
</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
                <%--<asp:Button ID="countryEntryButton" runat="server" Text="Reset" />--%>
                <asp:LinkButton ID="countryEntryButton" runat="server" OnClick="cancelbutton_Click" ><i class="fa fa-ban button-form form-button-color2"> Cancel</i>
</asp:LinkButton>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <br />
            </td>
        </tr>
         
                  </table>
        </fieldset>
                 <asp:GridView ID="countryEntryGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="OnPageIndexChanging" CellPadding="3" PageSize="4" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2"  CssClass="gridviewstyle">
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
                 
            
         
   
    
    
        </form >
        
    <script src="../Scripts/jquery-2.1.4.js"></script>
    <script src="../froala_editor_1.2.7/js/froala_editor.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/tables.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/lists.min.js"></script>
   
    <script src="../froala_editor_1.2.7/js/plugins/media_manager.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_family.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_size.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/block_styles.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/video.min.js"></script>
        <script>
        $(function () {
            $('#countryEntryAbout').editable({
                inlineMode: false,
                alwaysBlank: true,
                height: 150
            })
        });
  </script>
</body>
</html>
