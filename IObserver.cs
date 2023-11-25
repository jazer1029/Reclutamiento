using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reclutamiento
{
    public interface IObserver
    {
        string cedula { get; set; }
        string nombre { get; set; }
        string correo { get; set; }
        int aspiracionS { get; set; }
        string areaT { get; set; }

        void Actualizar();

    }
}
