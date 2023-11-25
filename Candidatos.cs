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
    class Candidatos : IObserver
    {
        public string cedula{ get; set; }
        public string nombre{ get; set; }
        public string correo{ get; set; }
        public int aspiracionS{ get; set; }
        public string areaT { get; set; }

        public Candidatos(string cedula, string nombre, string correo, int aspiracionS, string areaT)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.correo = correo;
            this.aspiracionS = aspiracionS;
            this.areaT = areaT;
        }

        public void Actualizar()
        {
            if (/*aspiracionS >= Servicio.salario && areaT == Servicio.area*/true)
            {
                string gmail = "jazerramirez51@gmail.com";
                string contraseña = "yhwruijfblptlvzg";

                MailMessage mensaje = new MailMessage();
                mensaje.Subject = "Puesto disponible";
                mensaje.From = new MailAddress(gmail);
                mensaje.Body = Servicio.mensaje;
                mensaje.To.Add(new MailAddress("Aqui va algo"));

                SmtpClient client = new SmtpClient();

                client.Host = "client.gmail.com";

                client.Port = 587;

                client.UseDefaultCredentials = false;

                client.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential(gmail, contraseña);

                client.Credentials = nc;

                client.Send(mensaje);

            }
        }
    } 
}
