<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UsersManagement.aspx.cs" Inherits="WebApplication1.UsersManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:lightcyan; font-weight:bold; height:20px; color:darkblue">
    New User:
    </div>
    <div>
        Name :&nbsp;&nbsp;
    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <br />
        <br />
        Birth date :&nbsp;&nbsp;
    <asp:DropDownList ID="TxtDay" runat="server">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>
        <asp:ListItem>13</asp:ListItem>
        <asp:ListItem>14</asp:ListItem>
        <asp:ListItem>15</asp:ListItem>
        <asp:ListItem>16</asp:ListItem>
        <asp:ListItem>17</asp:ListItem>
        <asp:ListItem>18</asp:ListItem>
        <asp:ListItem>19</asp:ListItem>
        <asp:ListItem>20</asp:ListItem>
        <asp:ListItem>21</asp:ListItem>
        <asp:ListItem>22</asp:ListItem>
        <asp:ListItem>23</asp:ListItem>
        <asp:ListItem>24</asp:ListItem>
        <asp:ListItem>25</asp:ListItem>
        <asp:ListItem>26</asp:ListItem>
        <asp:ListItem>27</asp:ListItem>
        <asp:ListItem>28</asp:ListItem>
        <asp:ListItem>29</asp:ListItem>
        <asp:ListItem>30</asp:ListItem>
        <asp:ListItem>31</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="TxtMonth" runat="server">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="TxtYear" runat="server">
        <asp:ListItem>2010</asp:ListItem>
        <asp:ListItem>2009</asp:ListItem>
        <asp:ListItem>2008</asp:ListItem>
        <asp:ListItem>2007</asp:ListItem>
        <asp:ListItem>2006</asp:ListItem>
        <asp:ListItem>2005</asp:ListItem>
        <asp:ListItem>2004</asp:ListItem>
        <asp:ListItem>2003</asp:ListItem>
        <asp:ListItem>2002</asp:ListItem>
        <asp:ListItem>2001</asp:ListItem>
        <asp:ListItem>2000</asp:ListItem>
        <asp:ListItem>1999</asp:ListItem>
        <asp:ListItem>1998</asp:ListItem>
        <asp:ListItem>1997</asp:ListItem>
        <asp:ListItem>1996</asp:ListItem>
        <asp:ListItem>1995</asp:ListItem>
        <asp:ListItem>1994</asp:ListItem>
        <asp:ListItem>1993</asp:ListItem>
        <asp:ListItem>1992</asp:ListItem>
        <asp:ListItem>1991</asp:ListItem>
        <asp:ListItem>1990</asp:ListItem>
        <asp:ListItem>1989</asp:ListItem>
        <asp:ListItem>1988</asp:ListItem>
        <asp:ListItem>1987</asp:ListItem>
        <asp:ListItem>1986</asp:ListItem>
        <asp:ListItem>1985</asp:ListItem>
        <asp:ListItem>1984</asp:ListItem>
        <asp:ListItem>1983</asp:ListItem>
        <asp:ListItem>1982</asp:ListItem>
        <asp:ListItem>1981</asp:ListItem>
        <asp:ListItem>1980</asp:ListItem>
        <asp:ListItem>1979</asp:ListItem>
        <asp:ListItem>1978</asp:ListItem>
        <asp:ListItem>1977</asp:ListItem>
        <asp:ListItem>1976</asp:ListItem>
        <asp:ListItem>1975</asp:ListItem>
        <asp:ListItem>1974</asp:ListItem>
        <asp:ListItem>1973</asp:ListItem>
        <asp:ListItem>1972</asp:ListItem>
        <asp:ListItem>1971</asp:ListItem>
        <asp:ListItem>1970</asp:ListItem>
        <asp:ListItem>1969</asp:ListItem>
        <asp:ListItem>1968</asp:ListItem>
        <asp:ListItem>1967</asp:ListItem>
        <asp:ListItem>1966</asp:ListItem>
        <asp:ListItem>1965</asp:ListItem>
        <asp:ListItem>1964</asp:ListItem>
        <asp:ListItem>1963</asp:ListItem>
        <asp:ListItem>1962</asp:ListItem>
        <asp:ListItem>1961</asp:ListItem>
        <asp:ListItem>1960</asp:ListItem>
        <asp:ListItem>1959</asp:ListItem>
        <asp:ListItem>1958</asp:ListItem>
        <asp:ListItem>1957</asp:ListItem>
        <asp:ListItem>1956</asp:ListItem>
        <asp:ListItem>1955</asp:ListItem>
        <asp:ListItem>1954</asp:ListItem>
        <asp:ListItem>1953</asp:ListItem>
        <asp:ListItem>1952</asp:ListItem>
        <asp:ListItem>1951</asp:ListItem>
        <asp:ListItem>1950</asp:ListItem>
        <asp:ListItem>1949</asp:ListItem>
        <asp:ListItem>1948</asp:ListItem>
        <asp:ListItem>1947</asp:ListItem>
        <asp:ListItem>1946</asp:ListItem>
        <asp:ListItem>1945</asp:ListItem>
        <asp:ListItem>1944</asp:ListItem>
        <asp:ListItem>1943</asp:ListItem>
        <asp:ListItem>1942</asp:ListItem>
        <asp:ListItem>1941</asp:ListItem>
        <asp:ListItem>1940</asp:ListItem>
        <asp:ListItem>1939</asp:ListItem>
        <asp:ListItem>1938</asp:ListItem>
        <asp:ListItem>1937</asp:ListItem>
        <asp:ListItem>1936</asp:ListItem>
        <asp:ListItem>1935</asp:ListItem>
        <asp:ListItem>1934</asp:ListItem>
        <asp:ListItem>1933</asp:ListItem>
        <asp:ListItem>1932</asp:ListItem>
        <asp:ListItem>1931</asp:ListItem>
        <asp:ListItem>1930</asp:ListItem>
        <asp:ListItem>1929</asp:ListItem>
        <asp:ListItem>1928</asp:ListItem>
        <asp:ListItem>1927</asp:ListItem>
        <asp:ListItem>1926</asp:ListItem>
        <asp:ListItem>1925</asp:ListItem>
        <asp:ListItem>1924</asp:ListItem>
        <asp:ListItem>1923</asp:ListItem>
        <asp:ListItem>1922</asp:ListItem>
        <asp:ListItem>1921</asp:ListItem>
        <asp:ListItem>1920</asp:ListItem>
        <asp:ListItem>1919</asp:ListItem>
        <asp:ListItem>1918</asp:ListItem>
        <asp:ListItem>1917</asp:ListItem>
        <asp:ListItem>1916</asp:ListItem>
        <asp:ListItem>1915</asp:ListItem>
        <asp:ListItem>1914</asp:ListItem>
        <asp:ListItem>1913</asp:ListItem>
        <asp:ListItem>1912</asp:ListItem>
        <asp:ListItem>1911</asp:ListItem>
        <asp:ListItem>1910</asp:ListItem>
        <asp:ListItem>1909</asp:ListItem>
        <asp:ListItem>1908</asp:ListItem>
        <asp:ListItem>1907</asp:ListItem>
        <asp:ListItem>1906</asp:ListItem>
        <asp:ListItem>1905</asp:ListItem>
        <asp:ListItem>1904</asp:ListItem>
        <asp:ListItem>1903</asp:ListItem>
        <asp:ListItem>1902</asp:ListItem>
        <asp:ListItem>1901</asp:ListItem>
        <asp:ListItem>1900</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    City :&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="TxtCity" runat="server">
        <asp:ListItem>Paris</asp:ListItem>
        <asp:ListItem>Grenoble</asp:ListItem>
        <asp:ListItem>Lyon</asp:ListItem>
        <asp:ListItem>Marseille</asp:ListItem>
        <asp:ListItem>Toulouse</asp:ListItem>
        <asp:ListItem>Strasbourg</asp:ListItem>
        <asp:ListItem>Bordeaux</asp:ListItem>
        <asp:ListItem>Nice</asp:ListItem>
        <asp:ListItem>Rennes</asp:ListItem>
        <asp:ListItem>Guingamps</asp:ListItem>
        <asp:ListItem>Aix En Provence</asp:ListItem>
        <asp:ListItem>Nantes</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    Email :&nbsp;&nbsp; <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <div style="display:inline-block">
    Image :<asp:FileUpload ID="PathImage" runat="server" />
    </div>
    <br />
    &nbsp;<br />
    &nbsp;
    <asp:Button ID="Button2" runat="server" Text="Upload" OnClick="Button2_Click" />
    <br />
    <asp:Label ID="LabelImage" runat="server" Text="Pease select a file"></asp:Label>
    <br />
    <asp:Image ID="Image1" runat="server" Height="101px" Width="101px" />
    <br />
    <br />
    Password :&nbsp;&nbsp;
    <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
    <br />
    Repeat password :&nbsp;&nbsp;
    <asp:TextBox ID="TxtRepeatPassword" runat="server"></asp:TextBox>

    <br />

    </div>

    <asp:Button class="btn btn-info" ID="Button1" runat="server" Text="ADD New" OnClick="Button1_Click" />
    <asp:Button CssClass="btn btn-success" ID="Button5" runat="server" Text="Update" OnClick="Button5_Click" />
    <br />

    <div style="background-color:lightcyan; font-weight:bold; height:20px; color:darkblue">
    Users Data:
    </div>
    <div>


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" PageSize="5">
            <Columns>
                <asp:BoundField DataField="Users_Name" HeaderText="Users Name" />
                <asp:BoundField DataField="Users_City" HeaderText="City" />
                <asp:BoundField DataField="Users_BirthDate" HeaderText="Birth Date" />
                <asp:BoundField DataField="Users_Email" HeaderText="Email" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image2" runat="server" Height="20px" ImageUrl='<%# Eval("Users_Image") %>' Width="20px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Commands">
                    <ItemTemplate>
                        <asp:Button class="btn btn-primary" ID="Button4" runat="server" Text="Edit" OnClick="Button4_Click" />
                        <asp:Button CssClass="btn btn-danger" ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Users_id") %>' Visible="False"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>


        <asp:Button ID="Button6" class="btn btn-primary" runat="server" Text="Back To Management Menu" OnClick="Button6_Click" />


        <br />
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>


    </div>

    <style>

        div {
            text-align:center;
        }

        table { 
            width: 750px; 
            border-collapse: collapse; 
            margin:50px auto;
        }   
        /* Zebra striping */
        tr:nth-of-type(odd) { 
            background: #eee; 
        }
        th { 
            background: #3498db; 
            color: white; 
            font-weight: bold; 
        }
        td, th { 
            padding: 10px; 
            border: 1px solid #ccc; 
            text-align: left; 
            font-size: 18px;
        }
        label {
            width:60px;
            float:left;
            font-size:12px;
            line-height:24px;
            font-weight:bold;

        }
        input {
            margin-bottom:5px;
            line-height:18px;
            padding:2px 5px;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            border:1px solid #CCC;
        }
    </style>



</asp:Content>
