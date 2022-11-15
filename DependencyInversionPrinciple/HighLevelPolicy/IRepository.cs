using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLevelPolicy
{
    /*
     
    La interfaz se declara desde el paquete que necesita que le "provean" un servicio
    y un tercero "pasa" o "inyecta" esa implementacion, de forma de que invertimos la dependencia

     */
    public interface IRepository
    {
        void Save(Movie movie);
    }
}
