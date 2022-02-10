using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Player
    {
        public event ValueChangesHandler ValueChanged;
        public string Name { get; set; }
        public int PlayRounds { get; set; }
        public double Cash { get; set; }
        public string SetOnColor { get; set; }

        public double CurrentAccountBalance { get; set; }

        public void OnValueChanged()
        {
            ValueChanged?.Invoke(this, new ValueChangeEventArgs());
        }

        public Player()
        {

        }
    }
}
