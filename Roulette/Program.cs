using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Player playerOne = new Player();
            p.GetPlayerInformation(playerOne);

            _greetingCurrentBalanace();
            //playerOne.ValueChanged += MyValueChanged;
            playerOne.PlayerGetToPlayRoom(playerOne);
            playerOne.OnValueChanged();
            playerOne.PlayerLeaveThePlayRoom(playerOne);
            Console.WriteLine("Spiel Ende");
            Console.ReadKey();

            //TODO   
            //Guthaben wird draufaddiet abgezoigen
            //spiellogik loop runde roundstart event einsatz wier agefragt  
            //event für spiel 
            //postfreundevent 
            //Abprüfungsevent
            //eventhandling
            //rotschwarz
            //gerade undgerade
            // Random instanz

        }

        private void GetPlayerInformation(Player playerOne)
        {
            try
            {                
                Console.WriteLine("Geben Sie Ihren Namen ein");
                Player.Name = Console.ReadLine();

                Console.WriteLine("Geben Sie an wie oft sie Spielen wollen");
                Player.PlayRounds = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben Sie an mit welchen Betrag Sie Spielen wollen");
                Player.Cash = Convert.ToDouble(Console.ReadLine());

                Player.CurrentAccountBalance = 55.45;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Der Fehler ist aufgetreten:" + ex);
            }
        }

        public static void MyValueChanged(object sender, ValueChangeEventArgs e)
        {
            //treffer
            try
            {
                int i = 0;
                SetRandomNumberColor(e);
                do
                {
                    Console.WriteLine("Runde: " + i);

                    Console.WriteLine("Setzen Sie ihre Zahl");
                    Player.SetOnNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Setzen Sie ihre Farbe (Schwarz || Rot)");
                    Player.SetOnColor = Console.ReadLine().ToLower();

                    if (Player.SetOnNumber % 2 == 0)
                    {
                        ExamineColorNumber(e);
                    }
                    else
                    {
                        ExamineColorNumber(e);
                    }
                    i++;

                } while (i != Player.PlayRounds);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler : " +ex);
            }

        }

        private static void ExamineColorNumber(ValueChangeEventArgs e)
        {
            if (Player.SetOnColor == e.ResultColor)
            {
                Console.WriteLine("Sie haben gewonnen");
                
                Player.CurrentAccountBalance += Player.Cash;
                _ShowCurrentBalance();
            }
            else
            {
                Console.WriteLine("Richtge Zahl Falsche Farbe");
                Player.CurrentAccountBalance -= Player.Cash;
                _ShowCurrentBalance();
            }
        }

        private static void SetRandomNumberColor(ValueChangeEventArgs e)
        {
            Random number = new Random();
            Random color = new Random();

            e.ResultNumber = number.Next(36);
            int colornumber = color.Next(2);
            switch (colornumber)
            {
                case 1: e.ResultColor = "schwarz"; break; //schwarz
                case 2: e.ResultColor = "rot"; break; //rot
            }
        }

        private static void _ShowCurrentBalance()
        {
            Console.WriteLine($"Guthaben Aktualisierung  {Player.CurrentAccountBalance} ");
        }

        private static void _greetingCurrentBalanace()
        {
            Console.WriteLine($"Hallo {Player.Name} : \n dein jetziges  Guthaben Beträgt  {Player.CurrentAccountBalance} ");
        }
    }   
}
