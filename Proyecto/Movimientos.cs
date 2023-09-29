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
    public partial class Movimientos : Form
    {
        
       
       
        
        public Movimientos()
        {
            InitializeComponent();
        }

        private void btnVolverMo_Click(object sender, EventArgs e)
        {
            Form FormMenu = new Form3();

            this.Close();
            FormMenu.Show();

        }


        private void btnMouseEnterMO(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            foreach (Control ctr in pMovimientos.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.AntiqueWhite;
                }
            }
        }

        private void btnMouseLeaveMO(object sender, EventArgs e)
        {


            Button bt = sender as Button;

            foreach (Control ctr in pMovimientos.Controls)
            {
                if (ctr is Button)
                {
                    bt.BackColor = Color.LightSteelBlue;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form FormMovimientosCompra = new MovimientosCompra();

            this.Close();
            FormMovimientosCompra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form FormMovimientosPrestamo = new MovimientosPrestamo();

            this.Close();
            FormMovimientosPrestamo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FormMovimientosVenta = new MovimientosVenta();

            this.Close();
            FormMovimientosVenta.Show();
        }

        private void VolverMovimientosP_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenuP_Click(object sender, EventArgs e)
        {

        }

        private void pMovimientos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
