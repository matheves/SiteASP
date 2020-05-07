<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FactorManagement.aspx.cs" Inherits="WebApplication1.FactorManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="font-weight:bold; font-size:24pt; text-align:center; background-color: lightblue;">
        List of Factors<br />

    </div>
    <div>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Factore_id" HeaderText="id" />
                <asp:BoundField DataField="Factore_DateTime" HeaderText="date" />
                <asp:BoundField DataField="Factore_Status" HeaderText="status" />
                <asp:TemplateField HeaderText="Command">
                    <ItemTemplate>
                        <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Confirm" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="View" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="Button3_Click" />
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Factore_id") %>' Visible="False"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
        <br />
        
    </div>
    <div style="font-weight:bold; font-size:24pt; text-align:center; background-color: lightblue;">
        
        Factor Info
    </div>
    <div style="font-size:18pt;">
        <br />
        Date :
        <asp:Label ID="LabelDate" runat="server" Text=""></asp:Label>
        <br />
        UserName : <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
        
        <br />
        UserEmail : <asp:Label ID="LabelEmail" runat="server" Text=""></asp:Label>
        <br />
        Status : <asp:Label ID="LabelStatus" runat="server" Text=""></asp:Label>
        
        <br />
&nbsp;</div>
     <div style="font-weight:bold; font-size:24pt; text-align:center; background-color: lightblue;">
        Factor Item
     </div>
    <div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Product_Name" HeaderText="Product" />
                <asp:BoundField DataField="FactoreItem_No" HeaderText="Qantity" />
                <asp:BoundField DataField="FactoreItem_Sum" HeaderText="Price" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button4" class="btn btn-primary" runat="server" Text="Back To Management Menu" OnClick="Button4_Click" />
        <br />
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
