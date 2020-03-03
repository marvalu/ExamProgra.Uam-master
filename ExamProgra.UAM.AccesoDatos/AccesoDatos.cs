using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamProgra.UAM.Entidades;

namespace ExamProgra.UAM.AccesoDatos
{
    public interface IOperaciones<T>
    {

        
            void Insertar(T item);
            T Buscar(int id);
            List<T> BuscarTodo();
            void Modificar(T item);
            void Eliminar(T item);

        
    }

}

