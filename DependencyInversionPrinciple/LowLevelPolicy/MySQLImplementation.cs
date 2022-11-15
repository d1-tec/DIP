using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighLevelPolicy;
// Miremos la dependencia, el namespace LowLevelPolicy depende de HighLevelPolicy, nos lo dice el using

namespace LowLevelPolicy
{
    public class MySQLImplementation : IRepository
    {
        public void Save(Movie movie)
        {
            Console.WriteLine($"Calling MySQLImplementation for movie {movie.Name}");
            /*
             
            Aca por ejemplo ejecutariamos una consulta sql
            INSERT INTO Movies (Name) VALUES (movies.Name) etc ...
             
             */
        }
    }
}
