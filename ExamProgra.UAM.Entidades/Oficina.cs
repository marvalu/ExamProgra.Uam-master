using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgra.UAM.Entidades
{
    public class Oficina : Telefono


    {
        protected string _provincia;
        protected string _ciudad;

        public Oficina(int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
        }

        public Oficina(string provincia, string ciudad, int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
            this._provincia = provincia;
            this._ciudad = ciudad;
        }

        public override void Telefonos()
        {
            Console.WriteLine("Implementar info de salida para info");
        }
    }
}
