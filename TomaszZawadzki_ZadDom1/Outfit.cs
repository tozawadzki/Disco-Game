using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszZawadzki_ZadDom2
{
    /// <summary>
    /// Klasa publiczna Outfit - obiekty tej klasy to przebrania, dzięki którym imponujemy dziewczynom
    /// </summary>
    public class Outfit
    {
        // Pole klasy przechowujący poziom wygody danego outfitu. Im mniej jest wygodny, tym więcej energii nam spada
        public int Comfort { get; set; }
        // Im seksowniej wyglądamy, tym bardziej imponujemy partnerce
        public int SexAppeal { get; set; }
        // Domyślny, bezparametryczny konstruktor inicjalizujący wszystkie wartości jedynką
        public Outfit()
        {
            this.Comfort = 1;
            this.SexAppeal = 1;
        }
        // Konstruktor parametryczny inicjalizujący pola klasy zadaną wartością
        public Outfit(int comfort, int sex)
        {
            this.Comfort = comfort;
            this.SexAppeal = sex;
        }

    }
}
