using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Proyecto.frmMenu;
using Microsoft.VisualBasic;


namespace Proyecto
{


    public partial class frmTransaccion : Form
    {

        private Conexion miConexion;
        public MySqlConnection Conexion { get; set; }

        string CotizacionDolarCompra = "0.00";
        string CotizacionDolarVenta = "0.00";
        string CotizacionDolarEbrouCompra = "0.00";
        string CotizacionDolarEbrouVenta = "0.00";
        string CotizacionEuroCompra = "0.00";
        string CotizacionEuroVenta = "0.00";
        string CotizacionPesoArgentinoCompra = "0.00O";
        string CotizacionPesoArgentinoVenta = "0.000";
        string CotizacionRealCompra = "0.00";
        string CotizacionRealVenta = "0.00";

        public frmTransaccion()
        {
            InitializeComponent();

            miConexion = new Conexion();
            Conexion = miConexion.GetConexion();
            this.Load += Transaccion_Load;
            string usuario = Sesion.NombreUsuario;
            string cargoUsuario = Sesion.CargoUsuario;

        }

        private void Transaccion_Load(object sender, EventArgs e)
        {
            cargarDólar();
            CargarMonedasT();
            CargarClientesT();

            txtMontoVentaM.Enabled = false;
            txtMontoCompraM.Enabled = false;
            txtMontoCompraT.Enabled = false;
            txtMontoVentaT.Enabled = false;


            cmbModoAM.SelectedItem = "Automatico";


            for (int i = 0; i < cmbMonedasT.Items.Count; i++)
            {
                DataRowView item = (DataRowView)cmbMonedasT.Items[i];
                if (item["Nombre"].ToString() == "DólarEbrou")
                {
                    cmbMonedasT.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbMonedaVT.Items.Count; i++)
            {
                DataRowView item = (DataRowView)cmbMonedaVT.Items[i];
                if (item["Nombre"].ToString() == "Peso Uruguayo")
                {
                    cmbMonedaVT.SelectedIndex = i;
                    break;
                }
            }
        }

        private void TextBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
 
        public void CargarClientesT()
        {
            try
            {
                string consulta = "SELECT Cliente_ID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM cliente where DadoDeBaja = 0";
                MySqlCommand cmd = new MySqlCommand(consulta, Conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaClientesP = new DataTable();

                Conexion.Open();
                adaptador.Fill(tablaClientesP);

                cmbClientesT.DisplayMember = "NombreCompleto";
                cmbClientesT.ValueMember = "Cliente_ID";
                cmbClientesT.DataSource = tablaClientesP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public void cargarDólar()
        {
            string nombreMoneda = "Dólar";
            string consultaArbitraje = "SELECT ValorCompra, ValorVenta FROM moneda WHERE Nombre = @nombreMoneda";

            using (MySqlConnection conexion = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020"))
            {
                using (MySqlCommand cmd = new MySqlCommand(consultaArbitraje, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreMoneda", nombreMoneda);

                    try
                    {
                        conexion.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal valorCompra = reader.GetDecimal(0);
                                decimal valorVenta = reader.GetDecimal(1);

                                txtArbitrajeC.Text = valorCompra.ToString();
                                txtArbitrajeV.Text = valorVenta.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la lista de Monedas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void CargarMonedasT()
        {
            try
            {
                string consultaM = "Select Nombre, ValorCompra, ValorVenta from moneda";
                using (MySqlConnection conexion = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020"))
                {
                    MySqlCommand cmd = new MySqlCommand(consultaM, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tablaMonedasT = new DataTable();
                    adaptador.Fill(tablaMonedasT);

                    cmbMonedasT.DisplayMember = "Nombre";
                    cmbMonedasT.ValueMember = "ValorCompra";
                    cmbMonedasT.DataSource = tablaMonedasT;

                    cmbMonedasT.SelectedIndexChanged += (sender, e) =>
                  {
                      if (cmbMonedasT.SelectedItem != null)
                      {

                          DataRowView selectedRow = (DataRowView)cmbMonedasT.SelectedItem;

                          txtMontoCompraT.Text = selectedRow["ValorCompra"].ToString();
                          txtMontoVentaM.Text = selectedRow["ValorVenta"].ToString();

                      }

                  };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Monedas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string consulta2 = "Select Nombre, ValorCompra, ValorVenta from moneda";
                MySqlCommand cmd2 = new MySqlCommand(consulta2, Conexion);
                MySqlDataAdapter adaptador2 = new MySqlDataAdapter(cmd2);
                DataTable tablaMonedasTV = new DataTable();
                adaptador2.Fill(tablaMonedasTV);

                cmbMonedaVT.DisplayMember = "Nombre";
                cmbMonedaVT.ValueMember = "ValorVenta";
                cmbMonedaVT.DataSource = tablaMonedasTV;



                cmbMonedaVT.SelectedIndexChanged += (sender, e) =>
                {
                    if (cmbMonedaVT.SelectedItem != null)
                    {

                        DataRowView selectedRow = (DataRowView)cmbMonedaVT.SelectedItem;

                        txtMontoVentaT.Text = selectedRow["ValorVenta"].ToString();
                        txtMontoCompraM.Text = selectedRow["ValorCompra"].ToString();

                    }

                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Monedas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Close();
            }
        }




        private void cmbModoAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModoAM.SelectedItem.ToString() == "Automatico")
            {
                txtMontoCompraT.Enabled = false;
                txtMontoVentaT.Enabled = false;
                txtMontoCompraM.Enabled = false;
                txtMontoVentaM.Enabled = false;
            }
            else if (cmbModoAM.SelectedItem.ToString() == "Manual")

            {
                txtMontoCompraT.Enabled = true;
                txtMontoVentaT.Enabled = true;
                txtMontoVentaM.Enabled = true;
                txtMontoCompraM.Enabled = true;
            }
        }


        private void rbCompraT_CheckedChanged(object sender, EventArgs e)
        {
            SobrescribirMonedas();

            if (rbCompraT.Checked)
            {
                pCompra.BackColor = Color.LightSkyBlue;
                txtMontoCompraT.Enabled = true;
                txtMontoVentaT.Enabled = false;
                lblMoneda.Text = "Moneda Compra";
                cmbMonedaVT.Location = new Point(185, 32);
                cmbMonedasT.Location = new Point(185, 187);
                txtMontoVentaT.Location = new Point(185, 90);
                txtMontoCompraM.Location = new Point(185, 119);
                txtMontoCompraT.Location = new Point(185, 237);
                txtMontoVentaM.Location = new Point(185, 266);
                lblValorTransaccion.Location = new Point(185, 220);
             
                rbVentaT.Checked = false;


                foreach (DataRowView item in cmbMonedasT.Items)
                {
                    if (item["Nombre"].ToString() == "DólarEbrou")
                    {
                        cmbMonedasT.SelectedItem = item;
                        break;
                    }
                }

                foreach (DataRowView item in cmbMonedaVT.Items)
                {
                    if (item["Nombre"].ToString() == "Peso Uruguayo")
                    {
                        cmbMonedaVT.SelectedItem = item;
                        break;
                    }
                }
            }
            else if (!rbCompraT.Checked)
            {
                Color activeCaptionColor = SystemColors.ActiveCaption;
                pCompra.BackColor = activeCaptionColor;
                lblMoneda.Text = "Moneda Venta";
                
                rbCompraT.Checked = false;
                cmbMonedaVT.Location = new Point(185, 187);
                cmbMonedasT.Location = new Point(185, 32);
                txtMontoVentaT.Location = new Point(185, 237);
                txtMontoCompraM.Location = new Point(185, 266);
                txtMontoCompraT.Location = new Point(185, 90);
                txtMontoVentaM.Location = new Point(185, 119);
                lblValorTransaccion.Location = new Point(185, 220);
            }
        }

        private void rbVentaT_CheckedChanged(object sender, EventArgs e)
        {
            SobrescribirMonedas();

            if (rbVentaT.Checked)
            {
                cmbMonedaVT.Location = new Point(185, 187);
                cmbMonedasT.Location = new Point(185, 32);
                txtMontoVentaT.Location = new Point(185, 237);
                txtMontoCompraM.Location = new Point(185, 266);
                txtMontoCompraT.Location = new Point(185, 90);
                txtMontoVentaM.Location = new Point(185, 119);
                lblValorTransaccion.Location = new Point(185, 220);
                pVenta.BackColor = Color.LightSkyBlue;

                txtMontoCompraT.Enabled = false;
                txtMontoVentaT.Enabled = true;
                lblMoneda.Text = "Moneda Venta";
                rbCompraT.Checked = false;


                foreach (DataRowView item in cmbMonedasT.Items)
                {
                    if (item["Nombre"].ToString() == "Peso Uruguayo")
                    {
                        cmbMonedasT.SelectedItem = item;
                        break;
                    }
                }

                foreach (DataRowView item in cmbMonedaVT.Items)
                {
                    if (item["Nombre"].ToString() == "DólarEbrou")
                    {
                        cmbMonedaVT.SelectedItem = item;
                        break;
                    }
                }
            }
            else if (!rbVentaT.Checked)
            {
                Color activeCaptionColor = SystemColors.ActiveCaption;
                pVenta.BackColor = activeCaptionColor;
                lblMoneda.Text = "Moneda Compra";
                cmbMonedaVT.Location = new Point(185, 32);
                cmbMonedasT.Location = new Point(185, 187);
                txtMontoVentaT.Location = new Point(185, 90);
                txtMontoCompraM.Location = new Point(185, 119);
                txtMontoCompraT.Location = new Point(185, 237);
                txtMontoVentaM.Location = new Point(185, 266);
                lblValorTransaccion.Location = new Point(185, 220);
                rbVentaT.Checked = false;

            }
        }


        private void SobrescribirMonedas()
        {
            string monedaDoy = "";
            string monedaRecibo = "";

            if (rbCompraT.Checked)
            {
                monedaDoy = ObtenerMoneda(lblMonedaDoy, cmbMonedasT);
                monedaRecibo = ObtenerMoneda(lblMonedaRecibo, cmbMonedaVT);
            }
            else if (rbVentaT.Checked)
            {
                monedaDoy = ObtenerMoneda(lblMonedaDoy, cmbMonedaVT);
                monedaRecibo = ObtenerMoneda(lblMonedaRecibo, cmbMonedasT);
            }

            lblMonedaDoy.Text = monedaDoy;
            lblMonedaRecibo.Text = monedaRecibo;
        }

        private string ObtenerMoneda(Label labelMoneda, ComboBox comboBoxMoneda)
        {
            DataRowView selectedItem = (DataRowView)comboBoxMoneda.SelectedItem;

            if (rbCompraT.Checked && selectedItem != null)
            {
                string nombreMoneda = selectedItem["Nombre"].ToString();

                switch (nombreMoneda)
                {
                    case "Dólar":
                        return " USD";
                    case "Peso Uruguayo":
                        return "   $";
                    case "Peso Argentino":
                        return " ARS";
                    case "Euro":
                        return "   €";
                    case "DólarEbrou":
                        return "eUSD";
                    case "Real":
                        return "  R$";
                    default:
                        return "";
                }
            }
            if (rbVentaT.Checked && selectedItem != null)
            {
                string nombreMoneda = selectedItem["Nombre"].ToString();

                switch (nombreMoneda)
                {
                    case "Dólar":
                        return " USD";
                    case "Peso Uruguayo":
                        return "   $";
                    case "Peso Argentino":
                        return " ARS";
                    case "Euro":
                        return "   €";
                    case "DólarEbrou":
                        return "eUSD";
                    case "Real":
                        return "  R$";
                    default:
                        return "";
                }
            }

            return "";
        }


        private void txtMontoT_TextChanged(object sender, EventArgs e)
        {
            txtClienteRecibe.KeyPress += TextBoxSoloNumeros_KeyPress;
            txtMontoT.KeyPress += TextBoxSoloNumeros_KeyPress;

            if (double.TryParse(txtMontoT.Text, out double montoT))
            {
                DataRowView monedaCompraSeleccionada = (DataRowView)cmbMonedasT.SelectedItem;
                DataRowView monedaVentaSeleccionada = (DataRowView)cmbMonedaVT.SelectedItem;

                if (monedaCompraSeleccionada != null && monedaVentaSeleccionada != null)
                {
                    double.TryParse(txtArbitrajeC.Text, out double arbitrajeCompra);
                    double.TryParse(txtArbitrajeV.Text, out double arbitrajeVenta);
                    double.TryParse(txtMontoVentaM.Text, out double valorVentaC);
                    double.TryParse(txtMontoCompraM.Text, out double valorCompraV);
                    double.TryParse(txtMontoCompraT.Text, out double valorCompra);
                    double.TryParse(txtMontoVentaT.Text, out double valorVenta);


                    if (rbCompraT.Checked)
                    {
                        double montoClienteRecibe = 0.0;
                        double montoClienteFinal = 0.0;
                        double montoPorcentaje = 0.0;
                        double ganancia_C = 0.0;
                        double conversor_C = 0.0;
                        double montoArbitraje = 0.0;
                        double comprobar_C = 0.0;
                        double promedioArbitraje = (arbitrajeCompra + arbitrajeVenta) / 2;

                        if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {

                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje); // DólarEbrou a Peso Uruguayo
                            montoPorcentaje = (montoClienteRecibe * 1.2) / 100;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje);
                            comprobar_C = Math.Round(comprobar_C, 2);

                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje) / valorCompra; // DólarEbrou a Peso Argentino
                            montoPorcentaje = (montoClienteRecibe * 1.5) / 100;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }

                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT * montoArbitraje); // DólarEbrou a Euro
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal / montoArbitraje);
                            ganancia_C = (montoT - conversor_C) * valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoClienteRecibe = (montoT * valorVenta) / valorCompra; // DólarEbrou a Real
                            montoPorcentaje = montoClienteRecibe * 0.07;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje); // DólarEbrou a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) * valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoClienteRecibe = (montoT * valorVenta); // Peso Uruguayo a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal);
                            ganancia_C = (conversor_C - montoT) / valorVenta;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje);
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoClienteRecibe = (montoT * valorVenta);  // Peso Uruguayo a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal);
                            ganancia_C = (conversor_C - montoT) / valorVenta;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        { 
                            montoClienteRecibe = (montoT * valorVenta); // Peso Uruguayo a Euro
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal);
                            ganancia_C = (conversor_C - montoT) / valorVenta;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoClienteRecibe = (montoT * valorVenta);  // Peso Uruguayo a Real
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal);
                            ganancia_C = (conversor_C - montoT) / valorVenta;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorVenta;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoClienteRecibe = (montoT * valorCompraV);  // Peso Uruguayo a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal);
                            ganancia_C = (montoT - conversor_C) * valorCompraV;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = arbitrajeCompra / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje);  // Peso Argentino a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal / montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {

                            montoArbitraje = arbitrajeCompra / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje);  // Peso Argentino a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal / montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = arbitrajeCompra / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje);  // Peso Argentino a Euro
                            montoPorcentaje = montoClienteRecibe * 0.016;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal / montoArbitraje);
                            ganancia_C = (montoT - conversor_C) * valorVenta;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {

                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorCompra;  // Peso Argentino a Real
                            montoPorcentaje = montoClienteRecibe * 0.017;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal / montoArbitraje);
                            ganancia_C = (conversor_C - montoT) * valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        { 
                            montoArbitraje = (valorCompra + valorVentaC)/ 2;
                            montoClienteRecibe = (montoT / valorCompra);  // Peso Argentino a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * valorCompra);
                            ganancia_C = (montoT - conversor_C);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorCompra;  // Real a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (conversor_C - montoT) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorCompra;   // Real a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (conversor_C - montoT) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT * montoArbitraje) * valorCompra;  // Real a Euro
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (conversor_C - montoT) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoClienteRecibe = montoT / valorCompra;  // Real a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje);
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje); // Real a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT * montoArbitraje);  // Euro a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal);
                            ganancia_C = (montoT - conversor_C) * ((valorVentaC - valorCompraV) * 2);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT * montoArbitraje) ;  // Euro a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / ((valorCompra - valorVenta) *2);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorCompra;  // Euro a Real
                            montoPorcentaje = montoClienteRecibe * 0.019;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal);
                            ganancia_C = (montoT - conversor_C);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoClienteRecibe = montoT / valorCompra;  // Euro a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje) / valorCompra;  // Euro a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorCompra;  // Dólar a DólarEbrou
                            montoClienteRecibe = Math.Round(montoClienteRecibe, 2);
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (conversor_C - montoT) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoClienteRecibe = montoT / valorCompra;  // Dólar a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorCompraV;  // Dólar a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C) / valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = arbitrajeCompra / valorVenta;
                            montoClienteRecibe = (montoT * montoArbitraje) ;  // Dólar a Euro
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal / montoArbitraje);
                            ganancia_C = (montoT - conversor_C) * valorCompra;
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoClienteRecibe = (montoT * valorVenta) / valorCompra;   // Dólar a Real
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_C = (montoClienteFinal * montoArbitraje);
                            ganancia_C = (montoT - conversor_C);
                            ganancia_C = Math.Round(ganancia_C, 2);

                            comprobar_C = (montoClienteFinal * promedioArbitraje) / valorCompra;
                            comprobar_C = Math.Round(comprobar_C, 2);
                        }
                        else
                        {
                            txtClienteRecibe.Text = string.Empty;
                        }

                        txtClienteRecibe.Text = montoClienteFinal.ToString();
                        txtGanancia.Text = ganancia_C.ToString();
                        txtComprobar.Text = comprobar_C.ToString();
                    }

                    else if (rbVentaT.Checked)
                    {
                        double montoClienteRecibe = 0.0;
                        double montoClienteFinal = 0.0;
                        double montoPorcentaje = 0.0;
                        double ganancia_V = 0.0;
                        double conversor_V = 0.0;
                        double montoArbitraje;
                        double comprobar_V = 0.0;


                        if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoClienteRecibe = (montoT * valorCompra); // DólarEbrou a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal;
                            ganancia_V = (conversor_V - montoT) / valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // DólarEbrou a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                             conversor_V = (montoClienteFinal / montoArbitraje);
                            ganancia_V = (conversor_V - montoT) * valorVenta;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // DólarEbrou a Euro
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra);
                            ganancia_V = (montoT - conversor_V);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) ; // DólarEbrou a Real
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra) ;
                            ganancia_V = (montoT - conversor_V);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "DólarEbrou" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // DólarEbrou a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.016;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra);
                            ganancia_V = (montoT - conversor_V) ;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje); // Peso Uruguayo a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal / valorVenta;
                            ganancia_V = (montoT - conversor_V) / valorVenta;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje); // Peso Uruguayo a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal / valorVenta;
                            ganancia_V = (montoT - conversor_V) / valorVenta;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje); // Peso Uruguayo a Euro
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal / valorVenta;
                            ganancia_V = (montoT - conversor_V) / valorVenta;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoArbitraje = valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje); // Peso Uruguayo a Real
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal / valorVenta;
                            ganancia_V = (montoT - conversor_V) / valorVenta;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Uruguayo" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoClienteRecibe = montoT / valorVenta; // Peso Uruguayo a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal * valorVenta;
                            ganancia_V = (montoT - conversor_V);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoClienteRecibe = (montoT * valorCompra) ; // Peso Argentino a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal;
                            ganancia_V = (montoT - conversor_V) * valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {

                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje); // Peso Argentino a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) * valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje); // Peso Argentino a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) * valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje); // Peso Argentino a Euro
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) * valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Peso Argentino" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {

                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorVenta; // Peso Argentino a Real
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta);
                            ganancia_V = (montoT - conversor_V) * valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje); // Real a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal / valorCompra;
                            ganancia_V = (montoT - conversor_V) ;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // Real a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal * valorVenta);
                            ganancia_V = (conversor_V - montoT) / (valorCompra / valorVenta);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorCompra;  // Real a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) / valorCompra ;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = valorVenta;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorCompra;  // Real a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) /valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Real" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta;// Real a Euro
                            montoPorcentaje = montoClienteRecibe * 0.015;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) /valorCompra ;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) ;  // Euro a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal;
                            ganancia_V = (conversor_V - montoT) / valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje); // Euro a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.017;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) * valorVenta;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Dólar")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje); // Euro a Dólar
                            montoPorcentaje = montoClienteRecibe * 0.017;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta) * valorCompra;
                            ganancia_V = (montoT - conversor_V) * valorVenta;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // Euro a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra);
                            ganancia_V = (montoT - conversor_V) * (-valorVenta);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Euro" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT / montoArbitraje) * valorVenta; // Euro a Real
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra);
                            ganancia_V = (montoT - conversor_V);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "DólarEbrou")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // Dólar a DólarEbrou
                            montoPorcentaje = montoClienteRecibe * 0.018;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorVenta);
                            ganancia_V = (montoT - conversor_V);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Uruguayo")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje); // Dólar a Peso Uruguayo
                            montoPorcentaje = montoClienteRecibe * 0.012;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = montoClienteFinal;
                            ganancia_V = (conversor_V - montoT) / valorCompra;
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Peso Argentino")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // Dólar a Peso Argentino
                            montoPorcentaje = montoClienteRecibe * 0.013;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra);
                            ganancia_V = (montoT - conversor_V) *(-valorVenta);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Euro")
                        {
                            montoArbitraje = valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) / valorVenta; // Dólar a Euro
                            montoPorcentaje = montoClienteRecibe * 0.014;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra);
                            ganancia_V = (montoT - conversor_V);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }
                        else if (monedaCompraSeleccionada["Nombre"].ToString() == "Dólar" && monedaVentaSeleccionada["Nombre"].ToString() == "Real")
                        {
                            montoArbitraje = arbitrajeVenta / valorCompra;
                            montoClienteRecibe = (montoT * montoArbitraje) * valorVenta; // Dólar a Real
                            montoPorcentaje = montoClienteRecibe * 0.016;
                            montoClienteFinal = montoClienteRecibe - montoPorcentaje;
                            montoClienteFinal = Math.Round(montoClienteFinal, 2);

                            conversor_V = (montoClienteFinal / valorCompra);
                            ganancia_V = (montoT - conversor_V);
                            ganancia_V = Math.Round(ganancia_V, 2);
                        }

                        txtClienteRecibe.Text = montoClienteFinal.ToString();
                        txtGanancia.Text = ganancia_V.ToString();
                        txtComprobar.Text = comprobar_V.ToString();
                       
                    }
                }
                else
                {
                    txtClienteRecibe.Text = string.Empty;
                }
            }
        }

        private void txtClienteRecibe_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnIngresarT_Click(object sender, EventArgs e)
        {
            if (cmbClientesT.SelectedValue == null ||
                cmbMonedasT.SelectedValue == null ||
                cmbMonedaVT.SelectedValue == null ||
                (rbCompraT.Checked && (string.IsNullOrEmpty(txtMontoT.Text) || string.IsNullOrEmpty(txtClienteRecibe.Text))) ||
                (rbVentaT.Checked && (string.IsNullOrEmpty(txtMontoT.Text) || string.IsNullOrEmpty(txtClienteRecibe.Text))))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            int idCliente = Convert.ToInt32(cmbClientesT.SelectedValue);
            string cargoUsuario = frmMenu.Sesion.CargoUsuario;

            using (MySqlConnection connection = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020"))
            {
                connection.Open();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO transacción (Moneda_C, Moneda_V, Tipo, Monto_C, Monto_V, Cliente, CargoUsuario) " +
                                          "VALUES (@Moneda_C, @Moneda_V, @Tipo, @Monto_C, @Monto_V, @Cliente, @CargoUsuario)";
                    command.Parameters.AddWithValue("@Moneda_C", cmbMonedasT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@Moneda_V", cmbMonedaVT.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@Tipo", rbCompraT.Checked ? "Compra" : "Venta");
                    command.Parameters.AddWithValue("@Monto_C", rbCompraT.Checked ? Convert.ToDouble(txtMontoT.Text) : 0);
                    command.Parameters.AddWithValue("@Monto_V", rbVentaT.Checked ? Convert.ToDouble(txtMontoT.Text) : 0);
                    command.Parameters.AddWithValue("@Cliente", idCliente);
                    command.Parameters.AddWithValue("@CargoUsuario", cargoUsuario);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            decimal montoGanancia = Convert.ToDecimal(txtGanancia.Text);
                            string tipoOperacion = rbCompraT.Checked ? "Compra" : "Venta";

                            ActualizarGanancias(montoGanancia, tipoOperacion);
                            MessageBox.Show("Los datos se ingresaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo ingresar los datos. Verifica los campos e intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ActualizarGanancias(decimal montoGanancia, string tipoOperacion)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020"))
            {
                connection.Open();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Ganancia (Fecha, TipoOperacion, MontoGanancia) VALUES (CURRENT_TIMESTAMP, @TipoOperacion, @MontoGanancia)";

                    command.Parameters.AddWithValue("@TipoOperacion", tipoOperacion);
                    command.Parameters.AddWithValue("@MontoGanancia", montoGanancia);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ganancias registradas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar las ganancias. Verifica la base de datos y vuelve a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar las ganancias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private void cmbMonedasT_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarMonedasEntreComboBox(cmbMonedasT, cmbMonedaVT);
            txtMontoT_TextChanged(sender, e);
            SobrescribirMonedas();
        }

        private void cmbMonedasVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarMonedasEntreComboBox(cmbMonedaVT, cmbMonedasT);
            txtMontoT_TextChanged(sender, e);
            SobrescribirMonedas();
        }


        private void CambiarMonedasEntreComboBox(ComboBox sourceComboBox, ComboBox targetComboBox)
        {
            DataRowView sourceItem = (DataRowView)sourceComboBox.SelectedItem;
            DataRowView targetItem = (DataRowView)targetComboBox.SelectedItem;

            if (sourceItem != null && targetItem != null)
            {
                if (sourceItem["Nombre"].ToString() == targetItem["Nombre"].ToString())
                {
                    targetComboBox.SelectedIndexChanged -= cmbMonedasVT_SelectedIndexChanged;
                    targetComboBox.SelectedItem = sourceComboBox.SelectedItem;
                    targetComboBox.SelectedIndexChanged += cmbMonedasVT_SelectedIndexChanged;
                }
            }
        }



        private void btnVolverT_Click(object sender, EventArgs e)
        {
            Form FormMenu = new frmMenu();

            this.Close();
            FormMenu.Show();

        }

        private void btnMouseEnterT(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            if (bt != null)
            {
                bt.BackColor = Color.LightBlue;
            }
        }

        private void btnMouseLeaveT(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            if (bt != null)
            {
                bt.BackColor = Color.SteelBlue;
            }
        }

        private void ExtraerCotizaciones()
        {
            var edgeDriveService = EdgeDriverService.CreateDefaultService();
            edgeDriveService.HideCommandPromptWindow = true;
            var edgeOptions = new EdgeOptions();

            try
            {

                IWebDriver driver = new EdgeDriver(edgeDriveService, edgeOptions);
                driver.Manage().Window.Size = new Size(0, 0);

                driver.Manage().Window.Position = new System.Drawing.Point(-2000, -2000);

                driver.Navigate().GoToUrl("https://www.brou.com.uy/web/guest/cotizaciones");

                var elementosCotizaciones = driver.FindElements(By.ClassName("valor"));

                CotizacionDolarCompra = elementosCotizaciones[4].Text;
                CotizacionDolarVenta = elementosCotizaciones[5].Text;

                CotizacionDolarEbrouCompra = elementosCotizaciones[8].Text;
                CotizacionDolarEbrouVenta = elementosCotizaciones[9].Text;

                CotizacionEuroCompra = elementosCotizaciones[12].Text;
                CotizacionEuroVenta = elementosCotizaciones[13].Text;

                CotizacionPesoArgentinoCompra = elementosCotizaciones[16].Text;
                CotizacionPesoArgentinoVenta = elementosCotizaciones[17].Text;

                CotizacionRealCompra = elementosCotizaciones[20].Text;
                CotizacionRealVenta = elementosCotizaciones[21].Text;

                driver.Manage().Window.Position = new System.Drawing.Point(0, 0);

                driver.Quit();
            }
            finally
            {
                edgeDriveService.Dispose();
            }
        }




        private void ActualizarMonedas()
        {
            string connectionString = "Server=codelabmysqlserver.ddns.net;Database=codelabagencia;User=bdcode;Password=11452020";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE moneda SET ValorCompra = @ValorCompra, ValorVenta = @ValorVenta WHERE Nombre = @Nombre";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Dólar");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionDolarCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionDolarVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "DólarEbrou");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionDolarEbrouCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionDolarEbrouVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Euro");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionEuroCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionEuroVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Peso Argentino");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionPesoArgentinoCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionPesoArgentinoVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();

                        command.Parameters.AddWithValue("@Nombre", "Real");
                        command.Parameters.AddWithValue("@ValorCompra", CotizacionRealCompra.ToString().Replace(",", "."));
                        command.Parameters.AddWithValue("@ValorVenta", CotizacionRealVenta.ToString().Replace(",", "."));
                        command.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblCotizacionWeb_Click(object sender, EventArgs e)
        {
            ExtraerCotizaciones();
            ActualizarMonedas();
            CargarMonedasT();
            for (int i = 0; i < cmbMonedasT.Items.Count; i++)
            {
                DataRowView item = (DataRowView)cmbMonedasT.Items[i];
                if (item["Nombre"].ToString() == "DólarEbrou")
                {
                    cmbMonedasT.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbMonedaVT.Items.Count; i++)
            {
                DataRowView item = (DataRowView)cmbMonedaVT.Items[i];
                if (item["Nombre"].ToString() == "Peso Uruguayo")
                {
                    cmbMonedaVT.SelectedIndex = i;
                    break;
                }
            }
        }


        private void lblCotizacionWeb_MouseHover(object sender, EventArgs e)
        {
            lblCotizacionWeb.ForeColor = Color.Blue;
        }

        private void lblCotizacionWeb_MouseLeave(object sender, EventArgs e)
        {
            lblCotizacionWeb.ForeColor = Color.DarkBlue;
        }

        
    }
}

