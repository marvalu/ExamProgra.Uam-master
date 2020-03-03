using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ExamProgra.UAM.AccesoDatos;

namespace ExamProgra.UAM.Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string email;
        private int cedula;
        private string apellidos;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
      //  public List<Celular> Obj_celular { get => obj_celular; set => obj_celular = value; }

       // List<Celular> obj_celular = new List<Celular>();

        public Persona()
        {

        }

        public Persona(int id, string nombre, string email, int cedula, string apellidos /*int idtel, int numero, string descripcionTel*/)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.cedula = cedula;
            this.apellidos = apellidos;
            //object descripcion = null;
            //  Telefono telefono = new Telefono(int idtel, int numero, string descripcionTel);


        }



        
    }
}
