<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="WebOOPKatmanliMimariStok.UrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürün Adı:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Ürün Adı..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Ürün Fiyatı:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Ürün Fiyatı..." OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Ürün Adeti:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Ürün Adeti..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürünü Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click"  />
        </div>

    </form>
</asp:Content>
