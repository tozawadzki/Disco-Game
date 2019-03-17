using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaszZawadzki_ZadDom2;
// Do puszczania muzyki
using WMPLib;

namespace TomaszZawadzki_ZadDom1
{
    public partial class Form1 : Form
    {
        // Publiczne listy obiektów danych klas
        public List<Drink> DrinkList { get; set; }
        public List<Before> BeforeList { get; set; }
        public List<Weapon> WeaponList { get; set; }
        public List<Economy> EconomyList { get; set; }
        public List<Outfit> OutfitList { get; set; }
        public List<Drug> DrugList { get; set; }  
        // zmienna pomocnicza typu WMP służąca do puszczenia muzyki podczas gry
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        // Zmienna przechowująca ilość wypitych piw
        int beers = 0;
        // Długość kolejki (można wdrożyć poziom trudności i zmienić wartość na wyższą)
        int queue = 15;
        // Czas na imprezę
        int time = 180;
        // Ilość czasu ile zchodzi na taniec
        int dance = 10;
        // Ilość pieniędzy
        int money = 100;
        /// <summary>
        /// Inicjalizowanie wszystkiego
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // Inicjalizacja wszystkich list
            DrugList = new List<Drug>();
            DrinkList = new List<Drink>();
            BeforeList = new List<Before>();
            WeaponList = new List<Weapon>();
            EconomyList = new List<Economy>();
            OutfitList = new List<Outfit>();
            // Podanie ścieżki, gdzie znajduje się utwór muzyczny
            player.URL = "later.mp3";
        }
        /// <summary>
        /// Licznik czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            // Upływający czas
            time--;
            // Wprowadzamy czas do textboxa
            textBoxTime.Text = time.ToString();
            // Aktualizujemy ilość pieniędzy
            textBoxMoney.Text = money.ToString();
            // Kiedy czas się skończy ( 4 warunek na przegranie gry )
            if (time == 0)
            {
                // Powiadomienie o przegranej
                MessageBox.Show("Koniec Czasu!");
                // Zamknięcie programu
                Close();
            }
            // Kiedy pieniądze się skończą (5 warunek na przegranie gry)
            if (money <=0)
            {
                // Zatrzymujemy upływ czasu
                timerTime.Stop();
                MessageBox.Show("Jesteś spłukany. Idziesz do domu");
                Close();
            }

            // Zapełnianie pęcherza
            if (beers < 3)
                // Zmiana przyrostu pęcherza
                progressPee.Increment(2);
            else
                progressPee.Increment(3);
            // Podpis progress baru pęcherz
            labelBladder.Text = "Pęcherz: " + progressPee.Value.ToString() + "%";
            // 1 warunek na przegranie gry
            if (progressPee.Value == 100)
            {
                timerTime.Stop();
                MessageBox.Show("Zlałeś się w spodnie, idź już lepiej do domu");
                // Koniec gry
                Close();
            }
            // Zmęczenie
            if (beers < 3)
            {
                // Im więcej pijemy, tym wolniej schodzi nam energia
                progressEnergy.Increment(-4);
            }
            else if (beers >= 3 && beers < 5)
            {
                progressEnergy.Increment(-3);
            }
            else 
            {
                progressEnergy.Increment(-2);
                // Czas leci szybciej
                time--;
            }

            labelEnergy.Text = "Energia: " + progressEnergy.Value.ToString() + "%";
            // 2 warunek na przegranie gry
            if (progressEnergy.Value == 0)
            {
                // Zatrzymanie czasu, koniec gry
                timerTime.Stop();
                MessageBox.Show("Padłeś na parkiecie");
                Close();
            }
            // 1 warunek na zwycięstwo
            if (progressGirl.Value == 100)
            {
                timerTime.Stop();
                MessageBox.Show("Gratulacje! Idziesz z panną do domu. Wygranko");
                Close();
            }
            // Drinki
            if (DrinkList.Count() < 1)
                progressGirl.Increment(2);
            // Im więcej drinków postawimy, tym większa szansa na zdobycie partnerki
            // Używamy funkcji count, która zwraca ilość obiektów w liście ( zamiast poprzedniej zwykłej zmiennej drinks typu int )
            else if (DrinkList.Count() == 1)
                progressGirl.Increment(3);
            else if (DrinkList.Count() == 3)
                progressGirl.Increment(4);
            else if (DrinkList.Count() > 3)
            {          
                MessageBox.Show("Ta dziewczyna już jest zbyt pijana, musisz odpuścić");
                // Odpuszczamy jedną dziewczynę
                    progressGirl.Value -= 30;
                // Zamiast proceduralnego drinks = 0 - czyścimy liste
                DrinkList.Clear();
            }
            // Katastrofy i sukcesy
            if (time % 18 == 0)
            {
                // Event pomagający nam wygrać grę
                MessageBox.Show("Wpadłeś jakiejś blondynce w oko...");
                if(progressGirl.Value + 6 < 100)
                    progressGirl.Value += 6;
                else
                {
                    while (progressGirl.Value != 100 && progressGirl.Value < 101)
                        progressGirl.Value++;
                }



            }
            if (time % 25 == 0)
            {
                // Chowamy się przed dziewczynami więc trudniej nam je zdobyć, a od widoku byłej wszystkiego nam się odechciewa
                MessageBox.Show("Twoja była przyszła. Musisz się chować");
                progressGirl.Value -= 5;
            }
            if (time % 30 == 0)
            {
                if (progressAlcohol.Value < 20)
                {
                    // Tak jak wypicie piwa zwykłego
                    MessageBox.Show("Ktoś Cię zaczepia. Nie chcesz się bić, więc stawiasz mu i sobie piwo");
                    if(progressPee.Value+20 < 100)
                         progressPee.Value += 20;
                    else
                        while (progressPee.Value!=100 && progressPee.Value < 101)                       
                            progressPee.Value++;
                        
                    money -= 7;
                    beers++;
                    if (progressEnergy.Value + 15 < 100)
                        progressEnergy.Value += 15;
                    else
                        while (progressEnergy.Value != 100 & progressEnergy.Value < 101)
                            progressEnergy.Value++;
                }
                else
                { 
                    // Imponujemy kobietom, płacimy za szatnię, ale zmęczyliśmy się
                    MessageBox.Show("Ktoś Cię napada. Masz nóż?");
                    progressGirl.Value += 3;
                    money -= 2;
                    if (WeaponList.Count() > 0)
                    {
                        // Zraniliśmy typa i wzięliśmy mu drobne
                        money += 5;
                    }
                    else
                    {
                        if (progressEnergy.Value - 25 > 0)
                            progressEnergy.Value -= 25;
                        else
                            // Gdy energia potrzebna do walki jest mniejsza niż 0, to znaczy że padliśmy
                            MessageBox.Show("Walka Cię wykończyła");
                        Close();
                    }
                }
            }
            // Pijani denerwujemy bramkarza
            if (progressAlcohol.Value > 30)
                progressSympathy.Increment(-3);

            // Warunek na przegranie: Wnerwienie bramkarza
            if (progressSympathy.Value==0)
            {
                timerTime.Stop();
                MessageBox.Show("Wypad z klubu!");
                Close();
            }
            
                
        }
        /// <summary>
        /// Pójście na piwo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBeer_Click(object sender, EventArgs e)
        {
            // Zwiększami ilość wypitych piw
            beers++;
            progressAlcohol.Value += 10;
            // Płacimy
            money -= 7;
            // 3 warunek na przegranie gry
            if (progressAlcohol.Value == 100)
            {
                MessageBox.Show("Idź do domu, obrzygałeś dziewczynę z którą tańczyłeś");
                Close();
            }
            if (progressPee.Value + 20 < 100)
                progressPee.Value += 20;
            // Kiedy chcemy wypić piwo ale nie starczy nam pęcherza
            else
            {            
                // Nie starczyło nam pęcherza
                MessageBox.Show("Zlałeś się w spodnie, idź już lepiej do domu");
                Close();
            }
            // Ale mamy więcej energii, zapobieganie błędowi
            if (progressEnergy.Value + 20 < 100)
                progressEnergy.Value += 20;
            else
            {
                while (progressEnergy.Value != 100 && progressEnergy.Value < 101)
                    progressEnergy.Value++;
            }
        }
        /// <summary>
        /// Pójście do toalety
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonToilet_Click(object sender, EventArgs e)
        {
            // Zmienna pomocnicza do wyświetlenia komunikatu
            string toiletMessage = "Wrociłeś na parkiet po " + queue + " minutach!";
            // Komunikat
            MessageBox.Show(toiletMessage);
            // Zerujemy wypełnienie pęcherza
            progressPee.Value = 0;
            // Zmniejszamy ilość pozostałego czasu
            time = time - queue;
        }
        /// <summary>
        /// Przycisk startu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaczynamy! Masz 3 godziny");
            // 1 minuta = 1 sekunda
            timerTime.Interval = 1000;
            // wystartowanie czasu
            timerTime.Start();

        }
        /// <summary>
        /// Taniec
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDance_Click(object sender, EventArgs e)
        {
            // Taniec zabiera nam 10 minut
            time = time - dance;
            // Imponujemy dziewczynie, asercja
            if (progressGirl.Value + 4 < 100)
                progressGirl.Value += 4;
            else
                while (progressGirl.Value != 100 && progressGirl.Value < 101)
                    progressGirl.Value++;
            // Męczymy się tańcem
            progressEnergy.Value -= 10;
            // Usypiamy czujność bramkarza
            progressSympathy.Value += 4;
        }   
        /// <summary>
        /// Wypicie drinka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrink_Click(object sender, EventArgs e)
        {
            #region MBM niedziałający
            // ZE WZGLĘDU NA TO, ŻE MBM POZWALA NA TYLKO JEDEN REGISTER, TO KOMENTUJE TE WYBORY DOPÓKI NIE ZNAJDĘ ROZWIĄZANIA NA WIĘCEJ AKCJI
            // Użycie interfejsu MessageBoxManager umożliwiającego nam zmianę tekstu w guzikach
            /*MessageBoxManager.Yes = "MadDog 10zł";
            MessageBoxManager.No = "BloodMary 15zł";
            MessageBoxManager.Cancel = "LongIsland 20zł";
            MessageBoxManager.Register();
            DialogResult result = MessageBox.Show("Co stawiasz?", "Bar",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Korzystamy z konstruktora parametrycznego (power, exclusivedegree)
                Drink drink1 = new Drink(2, 2);
                // Dodanie drinka do listy
                DrinkList.Add(drink1);
                // Płacimy za drinka
                money -= 10;
            }
            else if (result == DialogResult.No)
            {
                Drink drink2 = new Drink(3, 3);
                DrinkList.Add(drink2);
                money -= 15;
            }
            else if (result == DialogResult.Cancel)
            {
                Drink drink3 = new Drink(5, 5);
                DrinkList.Add(drink3);
                money -= 20;
            }*/
            #endregion           
            // Zwiększamy ilość postawionych drinków
            Drink drink = new Drink(1, 15, 12);
            // Dodajemy go do listy
            DrinkList.Add(drink);
            // Zwiększamy sobie szanse na zdobycie partnerki
            if (progressGirl.Value +  drink.ExclusiveDegree < 100)
               progressGirl.Value += drink.ExclusiveDegree;
            else
               while(progressGirl.Value != 100 && progressGirl.Value < 101)
                 progressGirl.Value++;
            // Płacimy za drinka
            money -= drink.Cost;
            
        
        }

        /// <summary>
        /// Funkcja włączająca się przy uruchomieniu programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Włączenie muzyki z podanej ścieżki URL
           player.controls.play();
        }
        /// <summary>
        /// Funkcja wyjścia z gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Kupowanie narkotyku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDealer_Click(object sender, EventArgs e)
        {
            // Korzystanie z interfejsu MBM i zmiana nazwy na guzikach
            MessageBoxManager.Yes = "Marihuana 5zł";
            // YesNoCancel to standardowy MB. Aby zmienić wyświetlany tekst musiałem zaincludować znaleziony w internecie specjalnie do tego napisany interfejs
            MessageBoxManager.No = "LSD 10zł";
            MessageBoxManager.Cancel = "Amfetamina 15zł";
            // Rejestracja (?) tekstu w guzikach. W każdym razie muszę to zrobić aby tekst się pojawiał, a utrudnia mi to życie ponieważ mogę to zrobić tylko raz
            MessageBoxManager.Register();
            // Tytuł okna, tekst powiadomienia, rodzaj defaultowego MB, ikonka pytajnik
            DialogResult result = MessageBox.Show("Co bierzesz?", "Dealer Sebastian",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Korzystamy z konstruktora parametrycznego (power, harmfulness)
                Drug drug1 = new Drug(1, 5, 1);
                // Dodajemy narkotyk do listy
                DrugList.Add(drug1);
                // Odejmujemy tyle pieniędzy,  ile kosztuje narkotyk
                money -= drug1.Cost;
                // Dostajemy tyle energii ile narkotyk ma powera
                progressEnergy.Value += 3 * drug1.Power;
            }
            else if (result == DialogResult.No)
            {
                // Analogicznie jak w poprzednich wariantach
                Drug drug2 = new Drug(2, 10,  2);
                DrugList.Add(drug2);
                money -= drug2.Cost;
                progressEnergy.Value += 3 * drug2.Power;
            }
            else if (result == DialogResult.Cancel)
            {
                // I tutaj też to samo
                Drug drug3 = new Drug(5, 15, 4);
                DrugList.Add(drug3);
                money -= drug3.Cost;
                progressEnergy.Value += 3 * drug3.Power;
            }
 
        }
        /// <summary>
        /// Zarabianie pieniędzy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMakeMoney_Click(object sender, EventArgs e)
        {
            // Okradamy kogoś
            Economy theft = new Economy(30, 20);
            MessageBox.Show("Okradles goscia");
            // Bierzemy pieniądze
            money += theft.AdditionalMoney;
            // W zależności jak poważne było to wykroczenie tak bardzo wkurzamy bramkarzy
            progressSympathy.Value -= theft.PissOff;
        }
        /// <summary>
        /// Zmiana outfitu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOutfit_Click(object sender, EventArgs e)
        {
            Outfit fit = new Outfit(3, 5);
            OutfitList.Add(fit);
            // Męczymy się bo strój jest niewygodny
            progressEnergy.Value -= fit.Comfort * 2;
            // Lepiej nam zdobyć partnerkę bo wyglądamy cool
            progressGirl.Value += fit.SexAppeal;
        }
        /// <summary>
        /// Uzbrojenie się
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeapon_Click(object sender, EventArgs e)
        {        
            // Nie dostaniemy w ryj przy katastrofie
            Weapon knife = new Weapon(2, 3);
            // Dodajemy broń do listy. Przy katastrofie jest sprawdzamy, czy mamy jakąkolwiek broń
            WeaponList.Add(knife);
            // To że mamy nóż nie podoba się bramkarzowi
            progressSympathy.Value -= knife.Size * 3;
        }
        /// <summary>
        /// Fajeczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCig_Click(object sender, EventArgs e)
        {
            // Lekko trzeźwiejemy
            progressAlcohol.Value -= 5;
            // Ale czas leci
            time -= 10;
        }
        /// <summary>
        /// Pójście na before
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBefore_Click(object sender, EventArgs e)
        {
            // Tak jak wszędzie, konstruktor parametryczny 
            Before party = new Before(5, 20, 30);
            BeforeList.Add(party);
            // Jak gruba była impreza
            progressAlcohol.Value += party.Alcohol;
            // Połowa spożytego alkoholu idzie na stratę energii
            progressEnergy.Value -= party.Alcohol / 2;
            // W jakim humorze przyszliśmy
            progressGirl.Value += party.Awesomeness;
            // Ile kosztował nas before
            money -= party.Cost;
        }
    }


}
