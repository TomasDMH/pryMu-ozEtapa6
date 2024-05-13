using pryMuñozEtapa6.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMuñozEtapa6
{
    public class clsVehiculo
    {
        public enum TipoVehiculo
        {
            Auto,
            Avion,
            Barco
        }
        public TipoVehiculo Tipo { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool MovimientoDetenido { get; private set; }

        private int velocidad = 5;

        public clsVehiculo(TipoVehiculo tipo, int x, int y)
        {
            Tipo = tipo;
            X = x;
            Y = y;
            MovimientoDetenido = false;
        }
        public void Mover()
        {
            if (!MovimientoDetenido)
            {
                
                switch (Tipo)
                {
                    case TipoVehiculo.Auto:
                        X += velocidad;
                        break;
                    case TipoVehiculo.Avion:
                        Y -= velocidad;
                        break;
                    case TipoVehiculo.Barco:
                        Y += velocidad;
                        break;
                }
            }
        }

        public void Detener()
        {
            MovimientoDetenido = true;
        }

        public bool Colision(clsVehiculo otroVehiculo)
        {
            return X < otroVehiculo.X + 50 && X + 50 > otroVehiculo.X &&
               Y < otroVehiculo.Y + 50 && Y + 50 > otroVehiculo.Y;
        }

        public void Dibujar(Graphics g)
        {
            switch (Tipo)
            {
                case TipoVehiculo.Auto:
                    g.DrawImage(Resources.auto1, X, Y, 40, 30);
                    break;
                case TipoVehiculo.Avion:
                    g.DrawImage(Resources.avion1, X, Y, 50, 50);
                    break;
                case TipoVehiculo.Barco:
                    g.DrawImage(Resources.barco1, X, Y, 60, 50);
                    break;
            }
        }
    }
}
