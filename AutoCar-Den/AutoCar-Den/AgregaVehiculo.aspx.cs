using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoCar_Den
{
    public partial class AgregaVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        public void cargaLista()
        {

            StringBuilder table = new StringBuilder();
            Vehiculo listaVehiculos = new Vehiculo();
            List<Vehiculo> list = listaVehiculos.listarVehiculos();



            foreach (Vehiculo v in listaVehiculos.listarVehiculos())
            {
                table.Append("<tr>");
                table.Append("<th class='align-middle' scope=1>" + v.Id_vehiculo + "</th>");
                table.Append("<td class='align-middle'>" + v.Marca + "</td>");
                table.Append("<td class='align-middle'>" + v.Modelo + "</td>");
                table.Append("<td class='align-middle'>" + v.Anio + "</td>");
                table.Append("<td class='align-middle'>" + v.Cant_pasajeros + "</td>");
                table.Append("<td class='align-middle'>" + v.Cant_puertas + "</td>");
                table.Append("<td class='align-middle'>" + v.Transmision + "</td>");
                table.Append("<td><img class='mx-center d-block' style='height:100px;' src=" + v.Imagen + "></td>");
                table.Append("</tr>");

            }

            tabla.Controls.Add(new Literal { Text = table.ToString() });

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Vehiculo v1 = new Vehiculo();

            v1.Marca = this.txtMarca.Text;
            v1.Modelo = this.txtModelo.Text;
            v1.Anio = int.Parse(this.documentAnio.Text);
            v1.Cant_pasajeros = int.Parse(this.txtPasajeros.Text);
            v1.Cant_puertas = int.Parse(this.documentPuertas.Text);
            v1.Transmision = this.txtTrasmision.Text;
            v1.Imagen = this.urlPhoto.Text;





            if (v1.agregarVehiculo())
            {
                Response.Redirect("AgregaVehiculo.aspx");
            }
            else
            {
                Response.Write("NO AGREGADO");

            }


        }
    }
}