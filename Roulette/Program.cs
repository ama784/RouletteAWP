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
            Spieler player = null;
            player = GetSpielerInformations(player);
            Console.WriteLine("Guten TAG  "+ player.Name +" \n \n Hier Guthaben entspricht" + string.Format("{0:C}", player.Guthaben));
            player = GetSpielerEinsatzFarbe(player);
            

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

        private static void Player_InvaildMeasure(object sender, Spieler e)
        {
            Console.WriteLine("Invaction chain ");
            
        }

        public static Spieler GetSpielerInformations(Spieler player)
        {
            player = new Spieler();
            player.InvaildMeasure += Player_InvaildMeasure;
            Console.WriteLine("Geben Sie ihren Namen ein");
            player.Name = Console.ReadLine();
            player.Guthaben = 78.78;
            return player;
        }

        public static Spieler GetSpielerEinsatzFarbe(Spieler player)
        {
            Console.WriteLine("Geben Sie Ihren Wetteinsatz an");
            player.Einsatz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie ihre Zahl an");
            player.Zahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die Farbe ein");
            player.Farbe = Console.ReadLine().ToLower();

            return player;
        }
    }   
}
