<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dersTalep.aspx.cs" Inherits="dersTalep" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Dersler"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Talep Oluştur" OnClick="kaydet_Click" CssClass="btn btn-info" Width="100px"  Height="50px" />
        </div>
    </form>
</body>
</html>
