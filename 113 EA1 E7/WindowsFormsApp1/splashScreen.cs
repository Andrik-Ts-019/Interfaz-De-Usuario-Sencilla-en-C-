using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class splashScreen : Form
    {
        //variables para permitir el movimiento de la ventana
        Point posicionPrincipal;
        Boolean mouseAction;

        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            timerSplashScreen.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerSplashScreen.Stop();
            this.Close();
        }

        private void splashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void splashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - posicionPrincipal.X, Cursor.Position.Y - posicionPrincipal.Y);
            }
        }

        private void splashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            posicionPrincipal = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }
    }
}
