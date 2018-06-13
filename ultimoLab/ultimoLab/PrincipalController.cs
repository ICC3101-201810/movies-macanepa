using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace ultimoLab
{
    class PrincipalController
    {
        PrincipalForm principalForm;

        public PrincipalController(PrincipalForm principalForm)
        {
            this.principalForm = principalForm;
            this.principalForm.OnBuscar += Buscar;
            this.principalForm.OnMostrar += Mostrar;
        }

        private void Buscar(object sender, BuscarEventArgs e)
        {
            //MessageBox.Show(e.texto);

            List<Persona> lstPersona = BaseDatos.lstPersonas.Where(x => x.nombre == e.texto || x.apellido == e.texto).ToList();
            List<Estudio> lstEstudio = BaseDatos.lstEstudio.Where(x => x.nombre == e.texto || x.direccion == e.texto).ToList();
            List<Pelicula> lstPeliculas = BaseDatos.lstPeliculas.Where(x => x.nombre == e.texto || x.descripcion == e.texto).ToList();

            List<Object> searchList = new List<object>();
            searchList.AddRange(lstPersona);
            searchList.AddRange(lstEstudio);
            searchList.AddRange(lstPeliculas);

            int counter = 0;

            string str = string.Empty;
            foreach(var element in searchList)
            {
                if (element is Persona) 
                {
                    Persona element1 = (Persona)element;
                    str += $"{element1.GetType().ToString()} : nombre: {element1.nombre} Apellido: {element1.apellido}\n";
                }
                if (element is Estudio) 
                {
                    Estudio element1 = (Estudio)element;
                    str += $"{element1.GetType().ToString()} : nombre: {element1.nombre} Direccion: {element1.direccion}\n";
                }
                if (element is Pelicula) 
                {
                    Pelicula element1 = (Pelicula)element;
                    str += $"{element1.GetType().ToString()} : nombre: {element1.nombre} Descripcion: {element1.descripcion}\n";
                }
                counter++;
                if (counter > 49) { break; }
                
            }

            MessageBox.Show(str);

        }

        private void Mostrar(object sender, MostrarEventArgs e)
        {
            List<Object> lstShow = new List<object>();
            if (e.tipo == Tipo.ACTOR)
            {
                foreach (Persona persona in BaseDatos.lstPersonas)
                {
                    if (persona is Actor)
                    {
                        lstShow.Add((Actor)persona);
                    }
                }
            }
            if (e.tipo == Tipo.DIRECTOR)
            {
                foreach (Persona persona in BaseDatos.lstPersonas)
                {
                    if (persona is Director)
                    {
                        lstShow.Add((Director)persona);
                    }
                }
            }
            if (e.tipo == Tipo.PRODUCTOR)
            {
                foreach (Persona persona in BaseDatos.lstPersonas)
                {
                    if (persona is Productor)
                    {
                        lstShow.Add((Productor)persona);
                    }
                }
            }
            if (e.tipo == Tipo.ESTUDIO)
            {
                foreach (Estudio estudio in BaseDatos.lstEstudio)
                {
                    lstShow.Add(estudio);
                }
            }
            if (e.tipo == Tipo.PELICULA)
            {
                foreach (Pelicula pelicula in BaseDatos.lstPeliculas)
                {
                    lstShow.Add(pelicula);
                }
            }
        }

    }
}
