<%@ Page Title="Rentcar| Vehiculos" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregaVehiculo.aspx.cs" Inherits="AutoCar_Den.AgregaVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1 class="text-center p-3">MANTENEDOR VEHICULOS</h1>
    <br />
    <section class="container">
        <div class="form-group row">
            <label for="txtMarca" class="col-sm-1 col-form-label">Marca</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtMarca" CssClass="form-control" runat="server"></asp:TextBox>

            </div>

        </div>
        <div class="form-group row">
            <label for="txtModelo" class="col-sm-1 col-form-label">Modelo</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtModelo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <label class="col-sm-1 col-form-label" for="txtAnio">Año</label>
            <div class="col-sm-5">
                <asp:DropDownList ID="documentAnio" CssClass="form-control border border-primary" runat="server">
                    <asp:ListItem Selected="True">2019</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group row">
            <label for="txtPuertas" class="col-sm-1 col-form-label">Puertas</label>
            <div class="col-sm-5">
                <asp:DropDownList ID="documentPuertas" CssClass="form-control border border-primary" runat="server">
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group row">
            <label for="txtPasajeros" class="col-sm-1 col-form-label">Pasajeros</label>
            <div class="col-sm-5">
                <asp:DropDownList ID="txtPasajeros" CssClass="form-control border border-primary" runat="server">
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtTransmision" class="col-sm-1 col-form-label">Transmision </label>
            <div class="col-sm-5">
                 <asp:DropDownList ID="txtTrasmision" cssClass="form-control border border-primary" runat="server">
                  <asp:ListItem>Automatico</asp:ListItem>
                  <asp:ListItem Selected="True">Manual</asp:ListItem>
            </asp:DropDownList>
            </div>
        </div>

        <div class="form-group row">
            <label for="urlPhoto" class="col-sm-1 col-form-label">Imagen</label>
            <div class="col-sm-5">
                <asp:TextBox ID="urlPhoto" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
        </div>


        <div class="form-group row">
            <div class="col-lg-12">
                <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Agregar" OnClick="btnGuardar_Click" />
            </div>
        </div>

    </section>

    <section class="container p-5">
        <table class="table table-bordered">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Marca</th>
                    <th scope="col">Modelo</th>
                    <th scope="col">Año</th>
                    <th scope="col">N.º de pasajeros</th>
                    <th scope="col">N.º de puertas</th>
                    <th scope="col">Transmision</th>
                    <th scope="col">Imagen</th>
                </tr>
            </thead>
            <tbody>
                <asp:PlaceHolder ID="tabla" runat="server"></asp:PlaceHolder>
                
            </tbody>
        </table>
    </section>
</asp:Content>
