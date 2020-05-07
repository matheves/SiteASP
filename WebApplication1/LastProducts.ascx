<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LastProducts.ascx.cs" Inherits="WebApplication1.LastProducts" %>
<div style="height:100px; width:200px;">

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" style="width:50px; height:90px;" ImageUrl='<%# Eval("Product_Image") %>' />
        </ItemTemplate>
    </asp:DataList>
</div>

<asp:HiddenField ID="HiddenField1" runat="server" />
