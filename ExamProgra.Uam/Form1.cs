using ExamProgra.UAM.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamProgra.UAM.Entidades;


namespace ExamProgra.Uam
{
    public partial class Form1 : Form
    {

        List<Persona> gente = new List<Persona>();
        Prueba  prueba = new Prueba();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click()//object sender, EventArgs e/n)
        //{
        //  //  DataTable data;
        //  ////  data = prueba.prueba2();

        //  //  dataGridView1.DataSource = data.DataSet;

        //  //  if (data != null)
        //  //  {
        //  //      if (data.Rows.Count > 0)
        //  //      {
        //  //          dataGridView1.DataSource = null;
        //  //          dataGridView1.DataSource = data;
        //  //      }
        //  //  }
        //}
        { }

        

        private void button4_Click(object sender, EventArgs e)
        {

            prueba.mostrarPersonas(gente);
            dataGridView1.DataSource = gente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prueba.salirmensaje();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prueba.Agregar_persona(int.Parse(IDPersonaTXT.Text), NombrePersonatxt.Text, CorreoPersonatxt.Text, int.Parse(CedPersonatxt.Text), ApellidoPersonatxt.Text);
            // Oper.Insertar(persona);
            MessageBox.Show("Agregado correctamente");
           // formulario.borrar();

          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BorrarInfo_Click(object sender, EventArgs e)
        {
            
                //Form1 formulario = new Form1();


            IDPersonaTXT.Text = "";
            NombrePersonatxt.Text = "";
            CorreoPersonatxt.Text = "";
            NombrePersonatxt.Text = "";
            ApellidoPersonatxt.Text = "";
            IDPersonaTXT.Text = "";
            CedPersonatxt.Text = "";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
