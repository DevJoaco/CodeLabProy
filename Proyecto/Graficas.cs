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
    public partial class Graficas : Form
    {

        Form FormMenu = new Form3();
        public Graficas()
        {
            InitializeComponent();
        }

        private void btnVolverG_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu.Show();
        }

        private void Graficas_Load(object sender, EventArgs e)
        {

        }
    }
}
