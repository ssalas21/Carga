using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargar_Subdere.BLL {
    class PermisosBLL {

        Permisos_de_CirculacionEntities context;

        public int GetType(string tipo) {
            context = new Permisos_de_CirculacionEntities();
            return (from l in context.Tipos_de_Vehiculos where l.Descripcion.Equals(tipo) select l.Codigo).FirstOrDefault();
        }

    }
}
