using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public delegate void InvaildMesureEventHandler();
    public class Spieler : EventArgs
    {
        public event InvaildMesureEventHandler InvaildMeasure;
        private string _name;
        private int _zahl;
        private string _farbe;
        private int _einsatz;
        private double _guthaben;
        public double Guthaben {
            get => _guthaben;
            set
            {
                if (_guthaben != null)
                {
                    _guthaben = value;
                }
                else
                {
                    InvaildMeasure();
                }
            }
        }
        
        public string Name { 
            get => _name;
            set
            {
                if(_name != null)
                {
                    _name = value;
                }
                else
                {
                    InvaildMeasure();
                }
            }
        }

        public int Zahl
        {
            get => _zahl;
            set
            {
                if (_zahl != 0)
                {
                    _zahl = value;
                }
                else
                {
                    InvaildMeasure();
                }
            }
        }

        public string Farbe {
            get => _farbe;
            set
            {
                if (_farbe != null)
                {
                    _farbe = value;
                }
                else
                {
                    InvaildMeasure();
                }
            }
        }

        public int Einsatz {
            get => _einsatz;
            set
            {
                if (_einsatz != 0)
                {
                    _einsatz = value;
                }
                else
                {
                    InvaildMeasure();
                }
            }
        }

        
        public Spieler()
        {

        }
    }
}
