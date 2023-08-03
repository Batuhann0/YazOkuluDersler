<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <strong>
                <asp:Label ID="Label1" runat="server" Text="Ders Seçin:" Style="font-size: large"></asp:Label>
            </strong>
            <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" Width="730px"></asp:DropDownList>
        </div>

        <br />

        <strong>

            <asp:Label ID="Label2" runat="server" Text="Ogrenci ID:" Style="font-size: large"></asp:Label>
        </strong>
        <asp:TextBox ID="txtogrenciıd" CssClass="form-control" runat="server" Width="730px"></asp:TextBox>

        <br />

        <div style="margin-left:350px">
            <strong>
            <asp:Button ID="Button1" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" style="font-weight: bold" OnClick="Button1_Click" />

            </strong>

        </div>

    </form>


</asp:Content>

