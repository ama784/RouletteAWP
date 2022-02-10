using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public delegate void ValueChangesHandler(object sender, ValueChangeEventArgs e);
    public class ValueChangeEventArgs: EventArgs
    {
       
        private int _resultNumber;
        private string _resultColor;

        public int ResultNumber
        {
            get { return _resultNumber; }
            set { _resultNumber = value; }
        }

        public string ResultColor
        {
            get { return _resultColor; }
            set { _resultColor = value; }
        }
    }
}
