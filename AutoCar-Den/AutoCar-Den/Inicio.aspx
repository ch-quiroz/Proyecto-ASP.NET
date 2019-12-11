<%@ Page Title="Rentcar| Inicio" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="AutoCar_Den.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row row-cols-1 row-cols-md-3 p-4" >
         <asp:PlaceHolder ID="catalogo" runat="server"></asp:PlaceHolder>
     </div>
</asp:Content>
