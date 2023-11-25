using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reclutamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            List<Puestos> puesto = new List<Puestos>();

            List<IObserver> candi = new List<IObserver>();
            Servicio servicio = new Servicio();
            Puestos puestos = new Puestos("Tecnologia", "Software", 200, false);

            puesto.Add(puestos);

            Console.Clear();
            int Opciones = 100;


            while (Opciones != 0)
            {
                //Menu
                Console.WriteLine("-----Bienvenidos-----");
                Console.WriteLine();
                Console.WriteLine("[1].Crear candidato" + "\n[2].Quitar candidato" + "\n[3].Notificar candidato" + "\n[0].Salir");

                Opciones = Convert.ToInt32(Console.ReadLine());

                //Hago un switch para poder interactuar con el menu de arriba y darle funcionalidad dependiendo de la opcion elegida
                switch (Opciones)
                {
                    case 1:

                        Console.WriteLine("Escriba su cedula");
                        string cedula = Console.ReadLine();

                        Console.WriteLine("\n");
                        Console.WriteLine("Escriba su nombre");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("\n");
                        Console.WriteLine("Escriba su correo electronico");
                        string correo = Console.ReadLine();

                        Console.WriteLine("\n");
                        Console.WriteLine("Escribe su aspiracion salarial");
                        int aspiracionS = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n");
                        Console.WriteLine("Escriba el area en el cual desea trabajar");
                        string areaT = Console.ReadLine();

                        Candidatos candidato = new Candidatos(cedula, nombre, correo, aspiracionS, areaT);

                        servicio.Agregar_Suscriptor(candidato);
                        break;

                    case 2:
                        string candidatoX;
                        Console.WriteLine("Escriba el nombre del candidato a eliminar ");
                        candidatoX = Console.ReadLine();

                        for (int i = 0; i < servicio.candidatos.Count; i++)
                        {
                            if (servicio.candidatos[i].nombre == candidatoX)
                            {
                                candi.Add(servicio.candidatos[i]);
                                servicio.Quitar_Suscriptor(candi[i]);
                            }
                        }


                        break;

                    case 3:
                        servicio.Correo(puesto);
                        Console.ReadKey();
                        break;

                    case 0:

                        break;

                    default:
                        Console.WriteLine("Introduce una opcion valida");
                        break;
                }

                Menu();

            }

        }
    }
}
