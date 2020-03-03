using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgra.UAM.Entidades
{
    public class Celular : Telefono
    {
        protected string _compañia;
        protected Boolean _roaming = true;

        //public Celular()
        //{
        //}

        public Celular(string compañia, bool roaming, int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
            _compañia = compañia;
            _roaming = roaming;
        }

        public override void Telefonos()
        {
            Console.WriteLine("Implementar info de salida para info");
        }
    }



}

