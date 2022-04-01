using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Game_RoulettLogic
{
    public class Player
    {
        public event ValueChangesHandler ValueChanged;
        public string Name { get; set; }
        public string SetColor { get; set; }
        public double RoundMoney { get; set; }
        
        public int SetOnNumber { get; set; }
        public double CurrentAccountBalance { get; set; }
        public Spiellogic Spiellogic;
        public void OnValueChanged()
        {
            ValueChanged?.Invoke(this, new ValueChangeEventArgs());
        }

        public Player()
        {

        }

        public void PlayerGetToPlayRoom(Player player)
        {
            Spiellogic = new Spiellogic();
            Spiellogic.player = player;
            player.ValueChanged += Spiellogic.MyValueChanged;

        }

        public void PlayerLeaveThePlayRoom(Player player)
        {
            player.ValueChanged -= Spiellogic.MyValueChanged;
        }
    }
}
