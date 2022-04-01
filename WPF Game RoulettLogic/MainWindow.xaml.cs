using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Game_RoulettLogic
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player player = new Player();
        private ValueChangeEventArgs VCEA;
        public MainWindow()
        {
            InitializeComponent();
            ClearTextFields();
            InVisibleHiddenInitialize();
            FillCombobox();
        }

        public void ClearTextFields()
        {
            Txt_Name.Text = "";
        }

        public void ClearGameTextFields()
        {
            Txt_MoneyPerRound.Text = "";
            Txt_Number.Text = "";
        }

        private void btnEingabenLöschen_Click(object sender, RoutedEventArgs e)
        {
            ClearTextFields();
        }

        private void GetPlayerInformation()
        {
            player.Name = Convert.ToString(Txt_Name.Text);
            player.CurrentAccountBalance = 55.74;
        }

        private void btnStarten_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Player player = new Player();
                if (Txt_Name.Text != "")
                {
                    btnGameRoundStarter.Visibility = Visibility.Visible;
                    GetPlayerInformation();
                    InVisibleHiddenStartBtn();
                    InVisibleGameStuff();
                    GetGameBelance();
                    ClearGameTextFields();
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
            Txt_MoneyPerRound.Visibility = Visibility.Visible;
            lblMoneyPerRound_Copy.Visibility = Visibility.Visible;
            Txt_Number.Visibility = Visibility.Visible;
            lblColor.Visibility = Visibility.Visible;
            ComboColorBox.Visibility = Visibility.Visible;
        }

        public void GetGameBelance()
        {
            Title.Visibility = Visibility.Hidden;
            lblGameCurrentGameBalance.Content = $"Spieler {player.Name}         Guthaben:  { player.CurrentAccountBalance}€";
        }
        public void CalculateCurrentsAccountBalance()
        {
            lblGameCurrentGameBalance.Content = $"Spieler {player.Name}         Guthaben:  { player.CurrentAccountBalance}€";
        }

        public void CheckCurrentAccount()
        {
            if (player.CurrentAccountBalance <= 0)
            {
                MessageBox.Show("Kein Geld mehr", "Game Over", MessageBoxButton.OK, MessageBoxImage.Error);
                if(MessageBoxResult.OK== MessageBoxResult.OK)
                {
                    Close();
                }
            }
        }

        private void btnGameRoundStarter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ball.Background = Brushes.Black;
                player.SetColor = ComboColorBox.SelectedItem.ToString();
                player.RoundMoney = Convert.ToDouble(Txt_MoneyPerRound.Text);
                player.SetOnNumber = Convert.ToInt32(Txt_Number.Text);

                player.PlayerGetToPlayRoom(player);
                player.OnValueChanged();
                player.PlayerLeaveThePlayRoom(player);
                CheckCurrentAccount();
                CalculateCurrentsAccountBalance();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unerwarteter Fehler bitte Achten sie auf die Zeichenkette", "Fehler", MessageBoxButton.OK);
            }
        }

        public void UpdateBorderColorNumber(ValueChangeEventArgs e)
        {
            BallLbl.Content = e.ResultNumber.ToString();

            if(e.ResultColor== "rot")
            {
                Ball.Background = Brushes.Red;
            }
            else
            {
                Ball.Background = Brushes.Black;
            }
        }
       
        private void FillCombobox()
        {
            List<string> ComboList = new List<string>();
            ComboList.Add("rot");
            ComboList.Add("schwarz");

            foreach( var element in ComboList)
            {
                ComboColorBox.Items.Add(element);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
