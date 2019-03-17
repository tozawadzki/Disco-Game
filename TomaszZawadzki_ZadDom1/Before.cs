using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszZawadzki_ZadDom2
{
    /// <summary>
    /// Klasa publiczna before dziedzicząca po klasie drink - obiekt tej klasy to impreza przed dyskoteką, dzieki której niższym kosztem możemy wejść pijani na imprezę
    /// </summary>
    public class Before : Drink
    {
        // Prop decydujący o tym, jak będziemy podobać się dziewczynom na samym wejściu
        public int Awesomeness { get; set; }
        // Jak bardzo wchodzimy pijani na imprezę
        public int Alcohol { get; set; }
        // Domyślny, bezparametryczny konstruktor inicjalizujący wszystkie wartości zerem
        public Before()
        {
            this.Awesomeness = 0;
            this.Cost = 0;
            this.Alcohol = 0;
        }
        // Konstruktor parametryczny inicjalizujący pola klasy zadaną wartością
        public Before(int awe, int cost, int alco)
        {
            this.Awesomeness = awe;
            this.Cost = Cost;
            this.Alcohol = alco;
        }
    }
}
