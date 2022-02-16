using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Game_RoulettLogic
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClearTextFields();
            InVisibleHiddenInitialize();
        }

        public void ClearTextFields()
        {
            //Txt_CashPerRound.Text = "";
            //Txt_Rounds.Text = "";
            Txt_Name.Text = "";
        }

        private void btnEingabenLöschen_Click(object sender, RoutedEventArgs e)
        {
            ClearTextFields();
        }

        private void GetPlayerInformation(Player playerOne)
        {
            Player.Name = Convert.ToString(Txt_Name.Text);
            //Player.Cash = Convert.ToDouble(Txt_CashPerRound.Text);
            //Player.PlayRounds = Convert.ToInt32(Txt_Rounds.Text);
            Player.CurrentAccountBalance = 55.74;
        }

        private void btnStarten_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Player player = new Player();
                if (Txt_Name.Text != "")
                {
                    GetPlayerInformation(player);
                    InVisibleHiddenStartBtn();
                    InVisibleGameStuff();
                    GetGameBelance();
                }
                else
                {
                    lblName.Content = " Name:   Bitte geben Sie Ihren Namen ein";
                }
            }
            catch (Exception ex)
            {
                lblFehlermeldung.Visibility = Visibility.Visible;
                lblFehlermeldung.Content = ex;
            }
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        public void InVisibleHiddenStartBtn()
        {
            Txt_Name.Visibility = Visibility.Hidden;
            lblName.Visibility = Visibility.Hidden;
            imageRoulettPremium.Visibility = Visibility.Hidden;
            btnEingabenLöschen.Visibility = Visibility.Hidden;
            btnStarten.Visibility = Visibility.Hidden;
        }

        public void InVisibleHiddenInitialize()
        {
            lblGameCurrentGameBalance.Visibility = Visibility.Hidden;
        }

        public void InVisibleGameStuff()
        {
            lblGameCurrentGameBalance.Visibility = Visibility.Visible;
            Ball.Visibility = Visibility.Visible;

            lblMoneyPerRound_Copy1.Visibility = Visibility.Visible;
            Txt_CashPerRound_Copy1.Visibility = Visibility.Visible;
           
            Txt_CashPerRound_Copy.Visibility = Visibility.Visible;
            lblMoneyPerRound_Copy.Visibility = Visibility.Visible;
            Txt_CashPerRound_Copy1.Visibility = Visibility.Visible;
            txtColor.Visibility = Visibility.Visible;
            lblColor.Visibility = Visibility.Visible;

        }

        public void InVisibleInputLbls()
        {

        }

        public void InVisibleTrue()
        {
            
        }

        public void GetGameBelance()
        {
            lblGameCurrentGameBalance.Content = $"Spieler {Player.Name}\n\nGuthaben:  { Player.CurrentAccountBalance}€";
        }
        public void CalculateCurrentsAccountBalance()
        {

        }

        
    }
}
