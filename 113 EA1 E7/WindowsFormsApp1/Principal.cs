using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class principal : Form
    {
        //Creamos la lista que tendra a nuestro alfabeto
        List<char> alfabeto = new List<char>();

        //variables booleanas para guardar el estado true false
        bool PrimeraCondicion;       
        bool TerceraCondicion;
        bool CuartaCondicion;
        bool QuintaCondicion;
        bool SoloEnAlfabeto;  //segunda condición

        //variables para permitir el movimiento de la ventana
        Point posicionPrincipal;
        Boolean mouseAction;

        //Variables de nombre y matricula
        readonly string Nombre;
        readonly string Matricula;

        //Variables para el parámetro principalAgrandado
        string nom;
        string mat;

        //Metodo Constructor por Defecto
        public principal()
        {

        }
        
        //Metodo Constructor
        public principal(string Nombre, string Matricula)
        {
            InitializeComponent();

            nom = Nombre;
            mat = Matricula;

            label2.Text = Nombre;
            Nombre = Nombre.ToLower();
            this.Nombre = Nombre;

            this.Matricula = Matricula;
            label3.Text = Matricula;                     

           //Ingresamos el nombre a la lista
           for(int i=0;i<Nombre.Length;i++)
           {
                if(!Nombre[i].Equals(' '))
                {  
                    alfabeto.Add(Nombre[i]);
                }               
           }

           //Ingresamos la matricula a la lista          
           for (int i=0;i<Matricula.Length;i++)
           {
                if(!Matricula[i].Equals(' '))
                {
                    alfabeto.Add(Matricula[i]);
                }            
           }

           //Ingresamos el punto a la lista
           alfabeto.Add('.');
         
           //Mandamos a validar el alfabeto(no repetidos,no espacios)
           Metodos met = new Metodos();
           met.ObtenerAlfabeto(alfabeto);
   
           //Mandamos llamar al metodo que hace posible la visualizacion
           labelAlfabeto.Text ="{"+ met.AlfabetoVisible(alfabeto)+"}";           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Esconde los elementos mencionados
            tablaCondiciones.Hide();
            imgCondicion1.Hide();
            imgCondicion2.Hide();
            imgCondicion3.Hide();
            imgCondicion4.Hide();
            imgCondicion5.Hide();

            //Esconde los labels
            labelCondicion1.Hide();
            label1.Hide();
            label4.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }

        private void boxText(object sender, EventArgs e)
        {

        }

        private void principal_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void principal_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - posicionPrincipal.X, Cursor.Position.Y - posicionPrincipal.Y);
            }
        }

        private void principal_MouseDown(object sender, MouseEventArgs e)
        {
            posicionPrincipal = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void botonSalir_MouseHover(object sender, EventArgs e)
        {
            botonSalir.BackgroundImage = Properties.Resources.Cerrar2_2;
        }

        private void botonSalir_MouseLeave(object sender, EventArgs e)
        {
            botonSalir.BackgroundImage = Properties.Resources.Cerrar2;
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        private void botonMinimizar_MouseHover(object sender, EventArgs e)
        {
            botonMinimizar.BackgroundImage = Properties.Resources.Minimizar2;
        }

        private void botonMinimizar_MouseLeave(object sender, EventArgs e)
        {
            botonMinimizar.BackgroundImage = Properties.Resources.Minimizar;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string verificar = CadenaVerificar.Text;

            Console.WriteLine("Longitud de cadena a verificar:" + verificar.Length);
            Metodos met = new Metodos();

            //Llamamos las funciones para validar las condiciones
            SoloEnAlfabeto = met.EnAlfabeto(verificar, alfabeto);
            PrimeraCondicion = met.PrimerSimboloDigito(alfabeto, verificar);
            TerceraCondicion = met.ContieneTodasLasIniciales(Nombre, verificar);
            CuartaCondicion = met.ElFinalDeLaCadena(verificar, Matricula, alfabeto);
            QuintaCondicion = met.NoPuntosSeguidos(verificar, alfabeto);

            //Muestra los elementos escondidos
            tablaCondiciones.Show();
            imgCondicion1.Show();
            imgCondicion2.Show();
            imgCondicion3.Show();
            imgCondicion4.Show();
            imgCondicion5.Show();

            //Muestra los labels escondidos
            labelCondicion1.Show();
            label1.Show();
            label4.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label8.Text = "\"."+mat+"\"";
            label9.Show();

            if (PrimeraCondicion==true)
            {
                imgCondicion1.BackgroundImage = Properties.Resources.palomitaexpandida;
            }
            else
            {
                imgCondicion1.BackgroundImage = Properties.Resources.tachitaexpandida;
            }

            if (SoloEnAlfabeto == true)
            {
                imgCondicion2.BackgroundImage = Properties.Resources.palomitaexpandida;
            }
            else
            {
                imgCondicion2.BackgroundImage = Properties.Resources.tachitaexpandida;
            }

            if (TerceraCondicion == true)
            {
                imgCondicion3.BackgroundImage = Properties.Resources.palomitaexpandida;
            }
            else
            {
                imgCondicion3.BackgroundImage = Properties.Resources.tachitaexpandida;
            }

            if (CuartaCondicion == true)
            {
                imgCondicion4.BackgroundImage = Properties.Resources.palomitaexpandida;
            }
            else
            {
                imgCondicion4.BackgroundImage = Properties.Resources.tachitaexpandida;
            }
            if (QuintaCondicion == true)
            {
                imgCondicion5.BackgroundImage = Properties.Resources.palomitaexpandida;
            }
            else
            {
                imgCondicion5.BackgroundImage = Properties.Resources.tachitaexpandida;
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.botonAccion2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.botonAccion;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            CadenaVerificar.Text = "";
            tablaCondiciones.Hide();
            imgCondicion1.Hide();
            imgCondicion2.Hide();
            imgCondicion3.Hide();
            imgCondicion4.Hide();
            imgCondicion5.Hide();

            labelCondicion1.Hide();
            label1.Hide();
            label4.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }

        private void botonLimpiar_MouseHover(object sender, EventArgs e)
        {
            botonLimpiar.BackgroundImage = Properties.Resources.botonLimpiar2;
        }

        private void botonLimpiar_MouseLeave(object sender, EventArgs e)
        {
            botonLimpiar.BackgroundImage = Properties.Resources.botonLimpiar;
        }
    }
}
