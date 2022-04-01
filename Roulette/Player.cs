using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public  class Player
    {
        public event ValueChangesHandler ValueChanged;
        public static string Name { get; set; }
        public static int PlayRounds { get; set; }
        public static double Cash { get; set; }
        public static string SetOnColor { get; set; }
        public static int SetOnNumber { get; set; }

        public static double CurrentAccountBalance { get; set; }

        public void OnValueChanged()
        {
            ValueChanged?.Invoke(this, new ValueChangeEventArgs());
        }

        public Player()
        {

        }

        public void PlayerGetToPlayRoom(Player player)
        {
            player.ValueChanged += Program.MyValueChanged;

        }

        public void PlayerLeaveThePlayRoom(Player player)
        {
            player.ValueChanged -= Program.MyValueChanged;
        }
    }
}
