using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgra.UAM.Entidades
{
    public abstract class Telefono
    {
        protected int _id;
        protected int _numero;
        protected string _descripcion;

        protected Telefono(int id, int numero, string descripcion)
        {
            _id = id;
            _numero = numero;
            _descripcion = descripcion;
        }

        public virtual void DatosTelefono()
        {
            Console.WriteLine("Muestra los datos del telefono", +_id,_numero,_descripcion);
        }

        public abstract void Telefonos();
    }
}

