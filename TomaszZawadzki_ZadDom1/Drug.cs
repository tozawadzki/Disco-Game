using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszZawadzki_ZadDom2
{
    /// <summary>
    /// Klasa publiczna Drug dziedzicząca po klasie drink - obiekty tej klasy to narkotyki, dzięki której możemy kosztem zdrowia psychicznego podreperować energię
    /// </summary>
    public class Drug : Drink
    {
        // Moc narkotyku - określa ilość dodanej energii
        public int Power { get; set; }
        // Dziedziczymi pole Cost po drinku
        // Szkodliwość narkotyku - wpływa na nasze zdrowie psychiczne
        public int Harmfulness { get; set; }
        // Domyślny, bezparametryczny konstruktor inicjalizujący wszystkie wartości jedynką
        public Drug()
        {
            this.Power = 1;
            this.Harmfulness = 1;
        }
        // Konstruktor parametryczny inicjalizujący pola klasy zadaną wartością
        public Drug(int pow, int c, int harm)
        {
            this.Power = pow;
            this.Harmfulness = harm;
        }

    }
}
