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

    public partial class PrincipalForm : Form
    {
        public event EventHandler<BuscarEventArgs> OnBuscar;
        public event EventHandler<MostrarEventArgs> OnMostrar;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarEventArgs mostrarEventArgs = new MostrarEventArgs();
            mostrarEventArgs.tipo = Tipo.PELICULA;
            OnMostrar(this, mostrarEventArgs);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuscarEventArgs buscarEventArgs = new BuscarEventArgs();
            buscarEventArgs.texto = textBox1.Text;
            if (textBox1.TextLength > 2)
            {
                OnBuscar(this, buscarEventArgs);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarEventArgs mostrarEventArgs = new MostrarEventArgs();
            mostrarEventArgs.tipo = Tipo.ACTOR;
            OnMostrar(this, mostrarEventArgs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarEventArgs mostrarEventArgs = new MostrarEventArgs();
            mostrarEventArgs.tipo = Tipo.DIRECTOR;
            OnMostrar(this, mostrarEventArgs);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarEventArgs mostrarEventArgs = new MostrarEventArgs();
            mostrarEventArgs.tipo = Tipo.PRODUCTOR;
            OnMostrar(this, mostrarEventArgs);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarEventArgs mostrarEventArgs = new MostrarEventArgs();
            mostrarEventArgs.tipo = Tipo.ESTUDIO;
            OnMostrar(this, mostrarEventArgs);
        }
    }

    public enum Tipo { PELICULA,ACTOR,DIRECTOR,PRODUCTOR,ESTUDIO }

    public class BuscarEventArgs : EventArgs
    {
        public string texto { get; set; }
    }

    public class MostrarEventArgs : EventArgs
    {
        public Tipo tipo;
    }
}
