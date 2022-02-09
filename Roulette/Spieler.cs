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
        public double Guthaben { get; set; }
        //Guthaben wird draufaddiet abgezoigen
        //spiellogik loop runde roundstart event einsatz wier agefragt  
        //event für spiel 
        //postfreundevent 
        //Abprüfungsevent
        //eventhandling
        //rotschwarz
        //gerade undgerade
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

        public int Zahl { get; set; }

        public string Farbe { get; set; }

        public int Einsatz { get; set; }
    }
}
