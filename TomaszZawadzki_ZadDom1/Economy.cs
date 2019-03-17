using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszZawadzki_ZadDom2
{
    /// <summary>
    /// Klasa publiczna Economy - obiekty tej klasy to akcje, dzięki której zarabiamy dodatkową kasę
    /// </summary>
    public class Economy
    {
        // Ile pieniędzy zarabiamy z przekrętu
        public int AdditionalMoney { get; set; }
        // Im większy przekręt robimy, tym bardziej denerwujemy bramkarza
        public int PissOff { get; set; }
        // Domyślny, bezparametryczny konstruktor inicjalizujący wszystkie wartości jedynką
        public Economy()
        {
            this.AdditionalMoney = 1;
            this.PissOff = 2;
        }
        // Konstruktor parametryczny inicjalizujący pola klasy zadaną wartością
        public Economy(int profit, int piss)
        {
            this.AdditionalMoney = profit;
            this.PissOff = piss;
        }
    }
}
