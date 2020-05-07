<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="WebApplication1.NewsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="font-weight:bold; font-size:20pt; text-align:center; background-color: lightblue;">
        News List :

    </div>
    <div style=""width:90%">
        <asp:DataList ID="DataList1" runat="server" width="100%">
            <ItemTemplate>
                <table style="width:100%; border:2px solid lightgrey; height:140px; text-align:center;">
                    <tr>
                        <td rowspan="2" style="border:2px dashed lightgrey; text-align:center;">
                            <asp:Image ID="Image1" runat="server" Height="180px" ImageUrl='<%# Eval("News_Img") %>' Width="150px" />
                        </td>
                        <td style="border:2px dashed lightgrey; text-align:center; width:200%; font-size:30px; font-weight:700;">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("News_title") %>'></asp:Label>
                        </td>
                        <td rowspan="2" style="border:2px dashed lightgrey; text-align:center;">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">More Details</asp:LinkButton>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("News_id") %>' Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border:2px dashed lightgrey; text-align:center;font-size:15px; color:darkblue;">
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("News_Date") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>



    </div>

</asp:Content>
