using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLAR_SDO.Model
{
    public class DataModel
    {
        public string Fecha  { get; set; }
        public List<string> Imagenes { get; set; } = new List<string>();

        public DataModel(string fecha, List<string> imagenes)
        {
            this.Fecha = fecha;
            this.Imagenes = imagenes;
        }
    }
}
