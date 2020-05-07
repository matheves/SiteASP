<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="WebApplication1.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="font-weight:bold; font-size:24pt; text-align:center; background-color: lightblue;">

        This is your Basket

        

    </div>

    <div>
        <asp:Label ID="Label3" runat="server" Text="Your basket is empty" Visible="False" style="font-size:26pt;" ForeColor="red"></asp:Label>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Product_Name" HeaderText="Name" />
                <asp:BoundField DataField="Product_Price" HeaderText="Price" />
                <asp:TemplateField HeaderText="Qty">
                    <ItemTemplate>
                        &nbsp;<asp:Button ID="Button1" runat="server" class="btn-sm btn-success" Text="+" OnClick="Button1_Click" />
                        &nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text='<%# Eval("Qty") %>'></asp:Label>
                        &nbsp;
                        <asp:Button ID="Button2" runat="server" class="btn-sm btn-danger" Text="-" OnClick="Button2_Click" />
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Product_id") %>' Visible="False"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>


        <asp:Button ID="Button3" runat="server" Text="Payment" class="btn btn-info" OnClick="Button3_Click" />


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
