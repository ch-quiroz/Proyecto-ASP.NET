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
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargaCatalogo();
        }

        public void cargaCatalogo(){

            StringBuilder table = new StringBuilder();
            Vehiculo listaVehiculos = new Vehiculo();
            List<Vehiculo> list = listaVehiculos.listarVehiculos();



            foreach (Vehiculo v in listaVehiculos.listarVehiculos())
            {
                table.Append("<div class='col mb-4'>");
                table.Append("<div class='card h-100'>");
                table.Append("<div class='card'>");
                table.Append("<img style= 'height: 250px; width: 365px;' src =" + v.Imagen+" class='card-img-top' />");
                table.Append("<div class='card-body'>");
                table.Append("<h5 class='card-title'>"+v.Marca+" "+v.Modelo+"</h5>");
                table.Append("</div>");
                table.Append("<ul class='list-group list-group-flush'>");
                table.Append("<li class='list-group-item'><Strong>Año Fabricacion:  </Strong>"+v.Anio+"</li>");
                table.Append("<li class='list-group-item'><Strong>Cantidad de pasajeros:  </Strong>" + v.Cant_pasajeros+ "</li>");
                table.Append("<li class='list-group-item'><Strong>Cantidad de puertas:  </Strong>" + v.Cant_puertas + "</li>");
                table.Append("<li class='list-group-item'><Strong>Transmision:  </Strong>" + v.Transmision + "</li>");
                table.Append("</ul>");
                table.Append("<div class='card-body m-2'>");
                table.Append("<a href='#' class='btn btn-success btn-lg'>Rentar</a>");
                table.Append("<a href='#' class='card-link m-5'>Mas informacion</a>");
                table.Append("</div></div></div></div>");
            
            }

            catalogo.Controls.Add(new Literal { Text = table.ToString() });
        }
    }
}