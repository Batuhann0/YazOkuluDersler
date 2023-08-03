<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci AD</th>
            <th>Öğrenci SOYAD</th>
            <th>Öğrenci NUMARA</th>
            <th>Öğrenci SİFRE</th>
            <th>Öğrenci FOTOĞRAF</th>
            <th>Öğrenci BAKİYE</th>
            <th>İşlemler</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OGRENCİId")%></td>
                        <td><%#Eval("Ad")%></td>
                        <td><%#Eval("Soyad")%></td>
                        <td><%#Eval("Numara")%></td>
                        <td><%#Eval("SIFRE")%></td>
                        <td><%#Eval("Fotograf")%></td>
                        <td><%#Eval("Bakiye")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl=<%#"~/OgrenciSil.aspx?OGRID="+Eval("OGRENCİId")%> ID="HyperLink1" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink>                           
                            <asp:HyperLink NavigateUrl=<%#"~/OgrenciGuncelle.aspx?OGRID="+Eval("OGRENCİId")%> ID="HyperLink2" CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>

            </asp:Repeater>
        </tbody>

    </table>
</asp:Content>

