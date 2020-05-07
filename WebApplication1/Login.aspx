<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="font-weight:bold; font-size:20pt; text-align:center; background-color: aqua;"> 
    Login
    </div>
<asp:Panel ID="Panel1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Email : "></asp:Label>
    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
    <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
</asp:Panel>
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
