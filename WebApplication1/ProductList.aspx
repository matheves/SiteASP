<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WebApplication1.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="font-weight:bold; font-size:20pt; text-align:center; background-color: lightblue;">
        Product List :

    </div>

    <div style=""width:90%">
        
        <asp:DataList ID="DataList1" runat="server" Width="100%">
            <ItemTemplate>
                <table style="width:100%; border:2px solid lightgrey; height:140px; text-align:center;">
                    <tr>
                        <td rowspan="3" style="border:2px dashed lightgrey; text-align:center;">
                            <asp:Image ID="Image1" runat="server" Height="180px" ImageUrl='<%# Eval("Product_Image") %>' Width="150px" />
                        </td>
                        <td style="border:2px dashed lightgrey; text-align:center; width:200%; font-size:25px; font-weight:700;">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
                        </td>
                        <td rowspan="3" style="border:2px dashed lightgrey; text-align:center;">
                            <asp:Button class="btn btn-info" ID="Button1" runat="server" Text="Add to Basket" OnClick="Button1_Click" />
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">More Details</asp:LinkButton>
                            <br />
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Product_id") %>' Visible="False"></asp:Label>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("Product_Name") %>' Visible="False"></asp:Label>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("Product_Price") %>' Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        
                        <td style="border:2px dashed lightgrey; text-align:center;font-size:25px;">
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Product_Category") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border:2px dashed lightgrey; text-align:center;font-size:25px; color:darkblue; height: 57px;">
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Product_Price") %>'></asp:Label>
                            <asp:Label ID="Label5" runat="server" ForeColor='<%# FixColor(Eval("Product_Status")) %>' Text='<%# FixStatus( Eval("Product_Status") )%>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

    </div>

</asp:Content>
