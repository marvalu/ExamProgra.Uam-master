using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgra.UAM.Entidades
{
    public class Hogar : Telefono


    {
        protected string provincia;
        protected string ciudad;

        public Hogar(int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
        }

        public Hogar(string provincia, string ciudad, int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
            this.provincia = provincia;
            this.ciudad = ciudad;
        }

        public override void Telefonos()
        {
            Console.WriteLine("Implementar info de salida para info");
        }
    }
}
