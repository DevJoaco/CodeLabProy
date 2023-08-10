using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            // HANDLER PARA EVENTO CUANDO EL MOUSE ENTRE EN EL BOTON        ( EVENTO )

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


        private void txtEnter(object sender, EventArgs e)
        {

            TextBox tx = sender as TextBox;
            foreach (Control ctr in pIniciarSesión.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }

        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in pIniciarSesión.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }










        private void Pprincipal_Paint(object sender, PaintEventArgs e)
        {
            // PANEL PRINCIPAL         ( PANEL ) pPrincipal
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // BOTON REGISTRARSE           ( BUTTON ) btnRegistrarse

            Form fRegistro = new Form2();
            Form fLogin = new Form1();

            fRegistro.Show();
            this.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            // AUN NO TIENES UNA CUENTA       ( LABEL )
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // YA CUENTAS CON UNA CUENTA      ( LABEL )
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // INGRESA DANDOLE CLICK AL BOTON DE ABAJO        ( LABEL )
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BOTON ACCEDER          ( BUTTON ) btnAcceder


        }

        private void label2_Click(object sender, EventArgs e)
        {
            // REGISTRATE DANDOLE CLICK AL BOTON DE ABAJO         ( LABEL ) 

        }

        private void pContenedor_Paint(object sender, PaintEventArgs e)
        {
            // PANEL CONTENEDOR          ( PANEL ) pContenedor

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // BOTON REGISTRAR    ( BUTTON )  btnRegistrar

        }

        private void pIniciarSesión_Paint(object sender, PaintEventArgs e)
        {
            // INICIAR SESIÓN        ( PANEL )     pIniciarSesión
        }



        private void pContraseñaIS_Paint(object sender, PaintEventArgs e)
        {
            // CONTRASEÑA INICIAR SESIÓN   ( PANEL ) pContraseñaIS

        }

        private void pUsuarioIS_Paint(object sender, PaintEventArgs e)
        {
            // USUARIO INICIAR SESIÓN   ( PANEL ) pUsuarioIS

        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            // BOTON INICIAR SESIÓN  ( BUTTON )  btnIniciarSesión


        }

        private void label14_Click(object sender, EventArgs e)
        {
            // LABEL INICIAR SESIÓN  ( LABEL )
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
