using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszZawadzki_ZadDom2
{
    /// <summary>
    /// Klasa publiczna drink - Obiekty tej klasy to drinki, które stawiamy dziewczynom
    /// </summary>
    public class Drink
    {
        // Koszt drinka
        public int Cost { get; set; }
        // Poziom ekskluzywności drinka. Im jest droższy, tym bardziej imponujemy partnerce
        public int ExclusiveDegree { get; set; }
        // Domyślny, bezparametryczny konstruktor inicjalizujący wszystkie wartości jedynką
        public Drink()
        {
            this.Cost = 1;
            this.ExclusiveDegree = 1;
        }
        // Konstruktor parametryczny inicjalizujący pola klasy zadaną wartością
        public Drink(int pow, int cost, int exD)
        {
            this.Cost = cost;
            this.ExclusiveDegree = exD;
        }
       
    }
}
