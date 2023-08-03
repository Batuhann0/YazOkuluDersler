<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciEkle.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <strong>
                    <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtAd" ErrorMessage="Ad Boş Geçilemez"></asp:RequiredFieldValidator> <%--uyarı mesajı--%>
            
            </div>

            <br />

            <div>
                <strong>
                    <asp:Label for="txtsoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <strong>
                    <asp:Label for="txtnumara" runat="server" Text="Öğrenci Numara:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtnumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <strong>
                    <asp:Label for="txtsifre" runat="server" Text="Öğrenci Sifre:"></asp:Label>
                </strong>
                <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>

                <strong>
                    <asp:Label for="txtfotograf" runat="server" Text="Öğrenci Fotograf:"></asp:Label>
                </strong>
                <asp:FileUpload ID="FileUploadfoto" runat="server" />
            </div>
        </div>


        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>

</asp:Content>

