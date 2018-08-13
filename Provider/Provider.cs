using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caborca.Provider
{
    public class Provider
    {
        public static EstacionProvider Estacion {
            get { return EstacionProvider.Instance; }
        }
        public static DatosProvider Datos {
            get { return DatosProvider.Instance; }
        }
    }
}
