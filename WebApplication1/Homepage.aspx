<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WebApplication1.Homepage" %>

<%@ Register Src="~/LastProducts.ascx" TagPrefix="uc1" TagName="LastProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="text-align:center;align-items:center;font-size:24pt;">

    <a href="ProductList.aspx" > Go to Products</a>
        <br />
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Go to News</asp:LinkButton>
    <br />
      <div style="display:inline-block;">
        <uc1:LastProducts runat="server" ID="LastProducts" no_to_disp="3"/>
        <br />
        <uc1:LastProducts runat="server" ID="LastProducts1" no_to_disp="2"/>
        <br />
        <uc1:LastProducts runat="server" ID="LastProducts2" no_to_disp="1"/>
      </div>
    </div>

</asp:Content>
