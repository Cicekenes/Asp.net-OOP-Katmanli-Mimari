<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="WebOOPKatmanliMimariStok.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Personel Adı:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Personel Adı..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Personel Soyadı:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Personel Soyadı..." ></asp:TextBox>
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Personel Maaş" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Personel Maaş"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Personel Departmanı: " Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" ></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Personeli Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click"   />
        </div>
        <br />
        
    </form>
</asp:Content>
