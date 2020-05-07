<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewsItem.aspx.cs" Inherits="WebApplication1.NewsItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
        <asp:Label ID="Label1" runat="server" Text="Label" style="font-weight:bold; font-size:40px;align-content:center;"></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" Width="200px" Height="300px" style="align-content:center;"/>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label" style="font-size:20px; color:darkblue;align-content:center;"></asp:Label>
        <br />
        
        <asp:Label ID="Label3" runat="server" Text="Label" style="font-size:20px;align-content:center;"></asp:Label>
        <br />
        
    </div>
</asp:Content>
