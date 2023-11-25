using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows;

namespace Reclutamiento
{
    class Servicio
    {
        static public string area;
        static public int salario;
        static public bool estatus;
        static public string mensaje;

        public List<IObserver> candidatos = new List<IObserver>();

        public void Agregar_Suscriptor(IObserver observadora)
        {
            candidatos.Add(observadora);

        }

        public void Quitar_Suscriptor(IObserver observadora)
        {
            candidatos.Remove(observadora);

        }

        public void Notificar()
        {

            foreach (var elemento in candidatos)
            {
                elemento.Actualizar();
            }
        }

       public void Correo(List<Puestos> puestos)
        {
            for (int i = 0; i < puestos.Count; i++)
            {
                area = puestos[i].area;
                salario = puestos[i].salario;
                estatus = puestos[i].estatus;
                mensaje = $"****Puesto****\n Puesto: {puestos[i].puesto}\n Salario: {puestos[i].salario}\n Estado: {puestos[i].estatus}\n Area: {puestos[i].area}";
                Notificar();

            }
        }

    }
}
