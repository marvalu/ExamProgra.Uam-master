using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ExamProgra.UAM.Entidades;


namespace ExamProgra.UAM.Acceso_a_datos
{
	public class ConeccionBD 
	{
        //Data Source = DESKTOP - SNQBSJ2; Initial Catalog = Exam; User ID = UserProgra3; Password=Abcd1234
        //private string connectionString = "Data Source=172.28.217.10\\SQLDEV001;Initial Catalog=CR_CORE;Integrated Security=True";
        //public void ConexionSQLNoQuery(string sql) // No retorna nada
        //{
        //    SqlConnection cnn;
        //    SqlCommand cmd;


        //    cnn = new SqlConnection(connectionString);
        //    try
        //    {
        //        cnn.Open();
        //        cmd = new SqlCommand(sql, cnn);
        //        cmd.ExecuteNonQuery();
        //        //SqlDataReader resultado = cmd.ExecuteReader();
        //        cmd.Dispose();
        //        Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Can not open connection ! " + ex.Message);
        //    }
        //    // Closing the connection  
        //    finally
        //    {
        //        cnn.Close();
        //    }
        //}
        //public SqlDataReader ConexionSQLQuery(string sql) // Retorna algun elemento
        //{
        //    SqlConnection cnn;
        //    SqlCommand cmd;


        //    cnn = new SqlConnection(connectionString);
        //    try
        //    {
        //        cnn.Open();
        //        cmd = new SqlCommand(sql, cnn);
        //        //cmd.ExecuteNonQuery();
        //        SqlDataReader resultado = cmd.ExecuteReader();
        //        cmd.Dispose();
        //        if (resultado.HasRows)
        //        {
        //            cnn.Close();
        //            return resultado;
        //        }
        //        else
        //        {
        //            Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Can not open connection ! " + ex.Message);
        //    }
        //    // Closing the connection  
        //    finally
        //    {

        //        cnn.Close();

        //    }
        //    return null;
        //}
        //public void ConexionADO(string sql)
        //{
        //    try
        //    {
        //        string querystring = "Select * from Items";
        //        SqlDataAdapter adapter = new SqlDataAdapter(querystring, connectionString);
        //        DataSet ds = new DataSet();
        //        adapter.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Can not open connection ! " + ex.Message);
        //    }

        //}

    }
}

