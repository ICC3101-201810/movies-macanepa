using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultimoLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            wait();
            PrincipalForm principalForm = new PrincipalForm();
            PrincipalController principalController = new PrincipalController(principalForm);
            LlenarDB();

            this.Hide();
            principalForm.Show();
            
        }

        public void wait()
        {

            //System.Threading.Thread.Sleep(5000);
            this.Show();
        }

        public void LlenarDB()
        {
            Director p1 = new Director("111", "1111", DateTime.Now, "BBB");
            Actor p2 = new Actor("222", "222", DateTime.Now, "BBB");
            Productor p3 = new Productor("333", "111", DateTime.Now, "BBB");
            Actor p4 = new Actor("444", "222", DateTime.Now, "BBB");

            Estudio estudio = new Estudio("estuu", "aqui", DateTime.Now);

            Pelicula pelicula = new Pelicula("PPP", p1, DateTime.Now, "wiwi", 400.0, estudio);

            PeliculaActor pa1 = new PeliculaActor(pelicula, p2);
            PeliculaActor pa2 = new PeliculaActor(pelicula, p4);
            PeliculaProductor pp1 = new PeliculaProductor(pelicula, p3);


            BaseDatos.lstPersonas.AddRange(new List<Persona>() { p1, p2, p3, p4 });
            BaseDatos.lstPeliculas.AddRange(new List<Pelicula>() { pelicula });
            BaseDatos.lstEstudio.AddRange(new List<Estudio> (){ estudio });
            BaseDatos.lstPeliculaActor.AddRange(new List<PeliculaActor>() { pa1,pa2 });
            BaseDatos.lstPeliculaProductor.AddRange(new List<PeliculaProductor>() { pp1 });

        }



    }
}
