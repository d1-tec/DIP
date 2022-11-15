using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLevelPolicy
{
    /*
     
    Si hay dudas de por que el nombre "Servicio", bueno, un "Servicio" no representa a ningun concepto de
    nuestro dominio, los servicios vienen de aplicar uno de los GRASP que vimos, Fabricacion Pura,
    ya que el objetivo que tienen es aumentar la cohesion (haciendo servicios enfocados en conceptos
    puntuales) y bajar el acoplamiento (para que los clientes se acoplen a servicios especificos y no
    a los modelos que estan "por debajo" de el)
     
     */
    public class MovieService
    {
        private IRepository repository;

        // Esto es lo que se conoce como "Dependency injection" ya que la dependencia
        // repository es "inyectada" o "pasada" a MovieService desde "fuera" (un tercero que no conocemos)
        public MovieService(IRepository repository)
        {
            this.repository = repository;
        }

        public void CreateMovie(Movie movie)
        {
            this.repository.Save(movie);
        }
    }
}
