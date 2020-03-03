using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamProgra.UAM.Entidades;
using ExamProgra.UAM.AccesoDatos;
using ExamProgra.UAM.Acceso_a_datos;
using System.Data.SqlClient;
using System.Data;
//using ExamProgra.UAMPresentacion;


namespace ExamProgra.UAM.Logica
{
    public class Prueba
    {

        List<Persona> Gente = new List<Persona>();
    
        Persona p1 = new Persona();
        //Celular c1 = new Celular();

        public Prueba()
        {
        }

        public Prueba(List<Persona> lista, Persona p1, Celular c1)
        {
            
            
            //this.c1 = c1;

            //this.p1.Obj_celular = c1;

        }

        //public DataTable  prueba2 (int id){

        //    //ConeccionBD con = new ConeccionBD();
        //    //string connetionString = null;
        //    //SqlConnection cnn;
        //    //SqlCommand cmd;
        //    //string sql = null;
        //    //SqlDataReader reader;

        //    //connetionString = "Data Source=172.28.217.10\\SQLDEV001;Initial Catalog=CR_CORE;Integrated Security=True";
        //    //sql = "select * from stc_par_marca";

        //    //sql = "update persona set nombre = ''Marco'' where id = " + id;

        //    //cnn = new SqlConnection(connetionString);
        //    //try
        //    //{
        //    //    cnn.Open();
        //    //    cmd = new SqlCommand(sql, cnn);
        //    //    reader = cmd.ExecuteReader();
        //    //    DataTable Tabla = new DataTable();
        //    //    Tabla.Load(reader);
        //    //    //while (reader.Read())
        //    //    //{
        //    //    //    Console.WriteLine( reader.GetValue(0) + " - " + reader.GetValue(1) + " - " + reader.GetValue(2));
        //    //    //}
        //    //    reader.Close();
        //    //    cmd.Dispose();
        //    //    cnn.Close();
        //    //    return Tabla;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine("Can not open connection ! ");
        //    //    return null;
        //    //}
        //}


        public void salirmensaje() {
            Console.WriteLine("sssssssssssssssssssss");
        }
        public void Agregar_persona(int id, string nombre, string mail, int ced, string apellido) {




            //int id= Convert.ToInt32(Console.ReadLine());
            //string nombre=Console.ReadLine();
            //string email= Console.ReadLine(); 
            //int cedula= Convert.ToInt32(Console.ReadLine()); 
            //string apellidos= Console.ReadLine();

            
            Persona persona = new Persona(id, nombre, mail, ced, apellido);

            Gente.Add(persona);
       
        }
        public void eliminar_persona(int num) {

            Persona p1 = new Persona();
            int contador = Gente.Count() - 1;
            while (contador >= 0) {
                //p1 = ((Persona)Gente)(contador)
                //   // (((Persona)Gente)(contador))
                    
            
            }
        
        
        }

        public List<Persona> mostrarPersonas(List<Persona>Gente) {
            //// DatosTabla(List<Persona> persona)
            //dataGridView1 dt = dataGridView1();
            //dataGridView1.DataSource = Gente;


            return Gente;

        }
    }
}
