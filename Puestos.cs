using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reclutamiento
{
    class Puestos
    {

        //Puestos puesto1 = new Puestos("Tecnologia", "Software", 200, false);
        //Puestos puesto2 = new Puestos("Mantenimiento", "Conserge", 100, false);
        //Puestos puesto3 = new Puestos("Transporte", "Mensajero", 150, false);
        
        public string area;
        public string puesto;
        public int salario;
        public bool estatus;



        public Puestos(string area, string puesto,int salario,bool estatus)
        {
            this.area = area;
            this.puesto = puesto;
            this.salario = salario;
            this.estatus = estatus;
        }
    }
}
