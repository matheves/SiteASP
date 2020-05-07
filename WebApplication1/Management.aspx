<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="WebApplication1.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="display:inline-block;">
    <asp:Button ID="Button1" runat="server" Text="User Management" css="btn btn-success" OnClick="Button1_Click" />  <br />
    <asp:Button ID="Button2" runat="server" Text="News Management" css="btn btn-info" OnClick="Button2_Click" />  <br />
    <asp:Button ID="Button3" runat="server" Text="Product Management" css="btn btn-info" OnClick="Button3_Click" /> <br />
    <asp:Button ID="Button4" runat="server" Text="Factor Management" css="btn btn-info" OnClick="Button4_Click" />
    </div>
</asp:Content>
