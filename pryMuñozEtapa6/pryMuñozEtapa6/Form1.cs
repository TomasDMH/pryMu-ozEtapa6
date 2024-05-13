using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMuñozEtapa6
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private List<clsVehiculo> vehiculos = new List<clsVehiculo>();
        private Random Aleatorio = new Random();

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            pctEspacio.Refresh();
            vehiculos.Clear();
            int cantidadVehiculos = Int32.Parse(txtCantidad.Text);

            for (int i = 0; i < cantidadVehiculos; i++)
            {
                int x = Aleatorio.Next(0, pctEspacio.Width = 410); 
                int y = Aleatorio.Next(0, pctEspacio.Height = 212); 
                clsVehiculo.TipoVehiculo tipo = (clsVehiculo.TipoVehiculo)Aleatorio.Next(3); 
                clsVehiculo vehiculo = new clsVehiculo(tipo, x, y);

                bool choca = false;
                foreach (clsVehiculo v in vehiculos)
                {
                    if (vehiculo.Colision(v))
                    {
                        choca = true;
                        break;
                    }
                }

                if (!choca)
                {
                    vehiculos.Add(vehiculo);
                    vehiculo.Dibujar(pctEspacio.CreateGraphics());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (clsVehiculo vehiculo in vehiculos)
            {
                vehiculo.Mover();

                foreach (clsVehiculo v in vehiculos)
                {
                    if (vehiculo != v && vehiculo.Colision(v))
                    {
                        vehiculo.Detener();
                        break;
                        MessageBox.Show("Los vehículos chocaron.");
                    }
                }
                vehiculo.Dibujar(pctEspacio.CreateGraphics());

                int dx = Aleatorio.Next(-10, 11); 
                int dy = Aleatorio.Next(-10, 11); 
                pctEspacio.Left += dx; 
                pctEspacio.Top += dy; 
            }
        }

        private void pctEspacio_Click(object sender, EventArgs e)
        {

        }
    }
    
}
