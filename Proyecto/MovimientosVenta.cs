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
    public partial class MovimientosVenta : Form
    {

        Form FormMenu = new Form3();
        Form FormMovimientos = new Movimientos();
        public MovimientosVenta()
        {
            InitializeComponent();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {

            this.Close();
            FormMenu.Show();
        }

        private void btnVolverMovimientos_Click(object sender, EventArgs e)
        {

            this.Close();
            FormMovimientos.Show();
        }
    }
}
