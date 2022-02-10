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

            Console.WriteLine($"Hallo {playerOne.Name} : \n dein jetziges  Guthaben Beträgt  {playerOne.CurrentAccountBalance} ");
            playerOne.ValueChanged += MyValueChanged;
            playerOne.OnValueChanged();
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

        public void GetPlayerInformation(Player playerOne)
        {
            Console.WriteLine("Geben Sie Ihren Namen ein");
            playerOne.Name = Console.ReadLine();

            Console.WriteLine("Geben Sie an wie oft sie Spielen wollen");
            playerOne.PlayRounds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie an mit welchen Betrag Sie Spielen wollen");
            playerOne.Cash = Convert.ToDouble(Console.ReadLine());

            playerOne.CurrentAccountBalance = 55.45;
        }

        public static void MyValueChanged(object sender, ValueChangeEventArgs e)
        {
            Console.WriteLine("Beginn the Game");
        }

    }   
}
