using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
namespace negocio
{
    public class Conn
    {
        private static RentcarEntities1 entidadDatos;

        public static RentcarEntities1 ModeloRentcar 
        {
            get
            {
                if (entidadDatos == null)
                {

                    entidadDatos = new RentcarEntities1();
                    
                }

                return entidadDatos;
            }
        }



        public Conn() { }

    }
}
