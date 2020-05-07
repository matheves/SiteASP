<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductsManagement.aspx.cs" Inherits="WebApplication1.ProductManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="font-weight:bold; font-size:24pt; text-align:center; background-color: lightblue;">
    <p>
        Product infos :</p>
    </div>
    <p>
        Name :
        <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
    </p>
    <p>
        Category :
        <asp:TextBox ID="TextCategory" runat="server"></asp:TextBox>
    </p>
    <p>
        Price :
        <asp:TextBox ID="TextPrice" runat="server"></asp:TextBox>
    </p>
    <div style="display:inline-block">
        <p>
            Image :
            <asp:FileUpload ID="PathImage" runat="server" />
        </p>
    </div>
    <p>
        <asp:Image ID="Image1" runat="server" Height="91px" Width="79px" />
    </p>
    <p>
        <asp:Label ID="LabelImage" runat="server" Text="Please select an image"></asp:Label>
    </p>
    <p>
        <asp:Button ID="ButtonUpload" runat="server" OnClick="ButtonUpload_Click" Text="Upload" />
    </p>
    <p>
        Status :
        <asp:TextBox ID="TextStatut" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button class="btn btn-info" ID="ButtonADD" runat="server" OnClick="ButtonADD_Click" Text="ADD" />
        <asp:Button CssClass="btn btn-success" ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
    </p>
    <p>
        Products data :</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Product_Name" HeaderText="Name" />
                <asp:BoundField DataField="Product_Category" HeaderText="Category" />
                <asp:BoundField DataField="Product_Price" HeaderText="Price" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image2" runat="server" Height="56px" ImageUrl='<%# Eval("Product_Image") %>' Width="53px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Product_Status" HeaderText="Status" />
                <asp:TemplateField HeaderText="Commands">
                    <ItemTemplate>
                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit" />
                        <asp:Button CssClass="btn btn-danger" ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Product_id") %>' Visible="False"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button3" class="btn btn-primary" runat="server" Text="Back To Management Menu" OnClick="Button3_Click" />
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
