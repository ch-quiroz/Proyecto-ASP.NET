using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;


namespace negocio
{
   public  class Vehiculo
    {


        private int id_vehiculo;
        private string modelo;
        private string marca;
        private int anio;
        private int cant_pasajeros;
        private int cant_puertas;
        private string transmision;
        private string imagen;


      


        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Cant_pasajeros { get => cant_pasajeros; set => cant_pasajeros = value; }
        public int Cant_puertas { get => cant_puertas; set => cant_puertas = value; }
        public string Transmision { get => transmision; set => transmision = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        public Vehiculo(){
            

        }

        public bool agregarVehiculo(){


            try{
                datos.Vehiculo v = new datos.Vehiculo();

                v.marca = this.marca;
                v.modelo = this.modelo;
                v.anio = this.anio;
                v.nro_puertas = this.cant_puertas;
                v.nro_pasajeros = this.cant_pasajeros;
                v.trasmision = this.transmision;
                v.imagen = this.imagen;

                Conn.ModeloRentcar.Vehiculo.Add(v);
                Conn.ModeloRentcar.SaveChanges();

                return true;
            }
            catch (Exception){
                return false;
            }
            
            

        }  

        public List<Vehiculo> listarVehiculos(){


            List<datos.Vehiculo> datosVehiculos = Conn.ModeloRentcar.Vehiculo.ToList();
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            
            

            foreach (datos.Vehiculo v1 in datosVehiculos)
            {
                Vehiculo v = new Vehiculo();
                v.Id_vehiculo = v1.id_vehiculo;
                v.Marca = v1.marca;
                v.Modelo = v1.modelo;
                v.Anio = v1.anio;
                v.Cant_pasajeros = v1.nro_pasajeros;
                v.Cant_puertas = v1.nro_puertas;
                v.Transmision = v1.trasmision;
                v.imagen = v1.imagen;

                listaVehiculos.Add(v);

            }

            return listaVehiculos;


        }
   }
}
