using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Game_RoulettLogic
{
    public class Spiellogic
    {
        public static Player player;
        public void MyValueChanged(object sender, ValueChangeEventArgs e)
        {
            try
            {
                this.SetRandomNumberColor(e);
                ExamineColorNumber(e);
                //MainWindow.test(e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetRandomNumberColor(ValueChangeEventArgs e)
        {
            Random number = new Random();
            Random color = new Random();

            e.ResultNumber = number.Next(37);
            int colornumber = color.Next(3);
            switch (colornumber)
            {
                case 1: e.ResultColor = "schwarz"; break; //schwarz
                case 2: e.ResultColor = "rot"; break; //rot
            }
        }

        private void ExamineColorNumber(ValueChangeEventArgs e)
        {
            if (player.SetColor == e.ResultColor && player.SetOnNumber== e.ResultNumber)
            {
                MessageBox.Show("Sie haben gewonnen", "Sieg", MessageBoxButton.OK);
                CalculateCurrentABPlus();
            }
            else
            {
                MessageBox.Show("Sie haben Verloren", "Niederlage", MessageBoxButton.OK);
                CalculateCurrentABMinus();
            }
        }

        private void CalculateCurrentABPlus()
        {
            player.CurrentAccountBalance += player.RoundMoney;
        }

        private void CalculateCurrentABMinus()
        {
            player.CurrentAccountBalance -= player.RoundMoney;
        }
        
    }
}
