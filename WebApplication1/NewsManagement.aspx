<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewsManagement.aspx.cs" Inherits="WebApplication1.NewsManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        News Management :</p>
    <p>
        Title :
        <asp:TextBox ID="TextTitle" runat="server"></asp:TextBox>
    </p>
    <p>
        Date :
        <asp:DropDownList ID="DayList" runat="server">
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
        <asp:DropDownList ID="MonthList" runat="server">
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
        </asp:DropDownList>+
        <asp:DropDownList ID="YearList" runat="server">
        <asp:ListItem>2019</asp:ListItem>
        <asp:ListItem>2018</asp:ListItem>
        <asp:ListItem>2017</asp:ListItem>
        <asp:ListItem>2016</asp:ListItem>
        <asp:ListItem>2015</asp:ListItem>
        <asp:ListItem>2014</asp:ListItem>
        <asp:ListItem>2013</asp:ListItem>
        <asp:ListItem>2012</asp:ListItem>
        <asp:ListItem>2011</asp:ListItem>
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
    </p>
    <p>
        Body :</p>
    <p>
        &nbsp;<asp:TextBox ID="TextBody" TextMode="MultiLine" runat="server" Height="132px" Width="792px"></asp:TextBox>
    </p>
    <div style="display:inline-block">
        <p>
            Image : <asp:FileUpload ID="PathImage" runat="server" />
        </p>
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
    </p>
    <p>
        <asp:Label ID="LabelImage" runat="server" Text="Please select a file"></asp:Label>
    </p>
    <p>
        <asp:Image ID="Image1" runat="server" Height="95px" Width="92px" />
    </p>
    <p>
        <asp:Button class="btn btn-info" ID="Button2" runat="server" OnClick="Button2_Click" Text="ADD" />
        <asp:Button CssClass="btn btn-success" ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        News Data :</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="News_title" HeaderText="Title" />
                <asp:BoundField DataField="News_date" HeaderText="Date" />
                <asp:BoundField DataField="News_body" HeaderText="Body" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image2" runat="server" Height="42px" ImageUrl='<%# Eval("News_img") %>' Width="42px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Commands">
                    <ItemTemplate>
                        <asp:Button class="btn btn-primary" ID="Button4" runat="server" OnClick="Button4_Click" Text="Edit" />
                        <asp:Button CssClass="btn btn-danger" ID="Button5" runat="server" OnClick="Button5_Click" Text="Delete" />
                        <asp:Label ID="LabelID" runat="server" Text='<%# Eval("News_id") %>' Visible="False"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button6" class="btn btn-primary" runat="server" OnClick="Button6_Click" Text="Back To Management Menu" />
    </p>

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
