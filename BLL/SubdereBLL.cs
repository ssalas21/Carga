using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargar_Subdere.BLL {
    class SubdereBLL {

        DBSubdereEntities context;

        public List<Subdere> GetSubderes() {
            context = new DBSubdereEntities();
            return (from l in context.Subdere select l).ToList();
        }

    }
}
