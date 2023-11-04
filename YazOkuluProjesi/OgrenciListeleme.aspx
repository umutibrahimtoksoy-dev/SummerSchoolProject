<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.master" AutoEventWireup="true" CodeFile="OgrenciListeleme.aspx.cs" Inherits="OgrenciListeleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci İd</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>Öğrenci İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%# Eval("OgrId") %></td>
                <td><%# Eval("OgrAd") %></td>
                <td><%# Eval("OgrSoyad") %></td>
                <td><%# Eval("OgrNumara") %></td>
                <td><%# Eval("OgrSifre") %></td>
                <td><%# Eval("OgrFotograf") %></td>
                <td><%# Eval("OgrBakiye") %></td>
                <td>
                    <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OgrId=" + Eval("OgrId") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                    <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OgrId=" + Eval("OgrId") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                </td>
            </tr>
               </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

