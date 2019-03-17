using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszZawadzki_ZadDom2
{
    /// <summary>
    /// Klasa publiczna Weapon - dzięki obiektom tej klasy jesteśmy bezpieczni podczas bójek
    /// </summary>
    public class Weapon : Outfit
    {

        // Tutaj jest dziedziczone pole "Comfort" Odpowiadające za ilość zużytej energii na noszenie broni
        // Pole wielkość, im broń jest większa tym bardziej zwracamy na siebie uwagę bramkarza
        public int Size { get; set; }
        // Domyślny, bezparametryczny konstruktor inicjalizujący wszystkie wartości jedynką
        public Weapon()
        {
            this.Comfort = 1;
            this.Size = 1;
        }
        // Konstruktor parametryczny inicjalizujący pola klasy zadaną wartością
        public Weapon(int c, int size)
        {
            this.Comfort = c;
            this.Size = size;
        }
    }
}
