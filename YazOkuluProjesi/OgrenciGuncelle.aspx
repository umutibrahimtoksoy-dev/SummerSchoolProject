<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <form id="Form1" runat ="server" >
         <div>
            <strong>
            <asp:Label for="Txtid" ID="Label6" runat="server" Text="Öğrenci Id:" ></asp:Label>
            </strong>
            <asp:TextBox ID="Txtid" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />         
        <div>
            <strong>
            <asp:Label for="TxtAd" ID="Label1" runat="server" Text="Öğrenci Ad:" ></asp:Label>
            </strong>
            <asp:TextBox ID="TxtAd" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
         <div>
             <strong>
            <asp:Label for="TxtSoyad" ID="Label2" runat="server" Text="Öğrenci Soyad:" ></asp:Label>
             </strong>
            <asp:TextBox ID="TxtSoyad" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
         <div>
             <strong>
            <asp:Label for="TxtNumara" ID="Label3" runat="server" Text="Öğrenci Numara:" ></asp:Label>
             </strong>
            <asp:TextBox ID="TxtNumara" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
         <div>
             <strong>
            <asp:Label for="TxtFotograf" ID="Label4" runat="server" Text="Öğrenci Fotoğraf:" ></asp:Label>
             </strong>
            <asp:TextBox ID="TxtFotograf" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
         <div>
             <strong>
            <asp:Label for="TxtSifre" ID="Label5" runat="server" Text="Öğrenci Şifre:" ></asp:Label>
             </strong>
            <asp:TextBox ID="TxtSifre" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br>
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-info" Width="100px"  Height="50px" OnClick="guncelle_Click" />
    </form>
</asp:Content>

