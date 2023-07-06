using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button; // realiza la invocacion del boton

            foreach (Control ctr in pPrincipal.Controls)  // Iteracion del panel principal
            {
                if (ctr is Button)   // si ctr es un boton
                {
                    bt.ForeColor = Color.Black; // cambiar color de letra a negro
                }
            }
            }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            // HANDLER PARA EVENTO CUANDO EL MOUSE SALGA EN EL BOTON        ( EVENTO )

            Button bt = sender as Button; // realiza la invocacion del boton

            foreach (Control ctr in pPrincipal.Controls)  // Iteracion del panel principal
            {
                if (ctr is Button)   // si ctr es un boton
                {
                    bt.ForeColor = Color.White; // cambiar color de letra a blanco
                }
            }
        }




        private void pRegistro_Paint(object sender, PaintEventArgs e)
        {
            // REGISTRO ( PANEL ) pRegistro
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // ACCEDER  ( BOTON ) btnAcceder

            Form fLogin = new Form1();
            Form fRegistro = new Form2();

            fLogin.Show();
            this.Close();
        }

    }
}
