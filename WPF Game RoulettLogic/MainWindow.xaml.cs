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
        }

        public void ClearTextFields()
        {
            Txt_CashPerRound.Text = "";
            Txt_Rounds.Text = "";
            Txt_Name.Text = "";
        }

        private void btnEingabenLöschen_Click(object sender, RoutedEventArgs e)
        {
            ClearTextFields();
        }

        private void GetPlayerInformation(Player playerOne)
        {
            Player.Name = Convert.ToString(Txt_Name.Text);
            Player.Cash = Convert.ToDouble(Txt_CashPerRound.Text);
            Player.PlayRounds = Convert.ToInt32(Txt_Rounds.Text);
        }

        private void btnStarten_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player();
            GetPlayerInformation(player);
            InVisibleHiddenStartBtn();


        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        public void InVisibleHiddenStartBtn()
        {
            Txt_CashPerRound.Visibility = Visibility.Hidden;
            Txt_Rounds.Visibility=Visibility.Hidden;
            Txt_Name.Visibility = Visibility.Hidden;
            lblMoneyPerRound.Visibility = Visibility.Hidden;
            lblGameRound.Visibility = Visibility.Hidden;
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

        }

        public void InVisibleTrue()
        {
            
        }
    }
}
