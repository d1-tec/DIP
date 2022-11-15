using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighLevelPolicy;
using LowLevelPolicy;
// Para que la inversion de dependencias sea posible debe haber un tercer paquete que conozca
// a los otros dos

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este tercer paquete instancia la dependencia
            IRepository repository = new MySQLImplementation();

            // Y luego se la inyecta
            MovieService movieService = new MovieService(repository);

            // MovieService usa la dependencia sin conocerla
            // (Si revisamos el paquete HighLevelPolicy no existe referencia al
            // paquete LowLevelPolicy)
            movieService.CreateMovie(new Movie { Name = "Star Wars" });

            /*
             
            Por que se llama invertir la dependencia?
            Porque lo usual es que si ejecutamos codigo dependamos de el (tengo que
            conocer algo para invocarlo)

            Cuando invertimos la dependencia lo que hacemos es invocar codigo que no conocemos

            MovieService invoca a MySQLImplementation sin conocerlo ya que existe un tercero 
            que le inyecta la dependencia
             
             */

            Console.ReadLine();
        }
    }
}
