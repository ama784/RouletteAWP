using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public delegate void InvaildMesureEventHandler(object sender, Spieler e);
    public class Spieler : EventArgs
    {
        public event InvaildMesureEventHandler InvaildMeasure;
        private string _name;
        private int _zahl;
        private string _farbe;
        private double _einsatz;
        private double _guthaben;
        private Spieler _player;
        public double Guthaben {
            //get => _guthaben;
            //set
            //{
            //    //if (_guthaben != 0)
            //    //{
            //    //    _guthaben = value;
            //    //}
            //    //else
            //    //{
            //    //    InvaildMeasure(this,_player);
            //    //}
            //    Ge
            //}
            get;set;
        }
        
        public string Name {
            //get => _name;
            //set
            //{
            //    if(_name != null)
            //    {
            //        _name = value;
            //    }
            //    else
            //    {
            //        InvaildMeasure(this, _player);
            //    }
            //}
            get;set;
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
                    InvaildMeasure(this, _player);
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
                    InvaildMeasure(this, _player);
                }
            }
        }

        public double Einsatz {
            get => _einsatz;
            set
            {
                if (_einsatz != 0)
                {
                    _einsatz = value;
                }
                else
                {
                    InvaildMeasure(this, _player);
                }
            }
        }

       public void OnValueChanged()
        {
            InvaildMeasure?.Invoke(this, _player);
        }

        
        public Spieler()
        {
        }
    }
}
